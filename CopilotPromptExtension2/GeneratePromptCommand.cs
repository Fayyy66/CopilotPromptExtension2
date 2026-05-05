using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace CopilotPromptExtension2
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class GeneratePromptCommand
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("801c8bdb-46e2-4929-9ac9-7fcef7d5e593");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly AsyncPackage package;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePromptCommand"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        /// <param name="commandService">Command service to add command to, not null.</param>
        private GeneratePromptCommand(AsyncPackage package, OleMenuCommandService commandService)
        {
            this.package = package ?? throw new ArgumentNullException(nameof(package));
            commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

            var menuCommandID = new CommandID(CommandSet, CommandId);
            var menuItem = new MenuCommand(this.Execute, menuCommandID);
            commandService.AddCommand(menuItem);
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static GeneratePromptCommand Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private Microsoft.VisualStudio.Shell.IAsyncServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static async Task InitializeAsync(AsyncPackage package)
        {
            // Switch to the main thread - the call to AddCommand in GeneratePromptCommand's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            OleMenuCommandService commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new GeneratePromptCommand(package, commandService);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void Execute(object sender, EventArgs e)
        {
            ThreadHelper.ThrowIfNotOnUIThread();

            var dte = Package.GetGlobalService(typeof(SDTE)) as DTE2;
            if (dte == null)
            {
                VsShellUtilities.ShowMessageBox(
                    this.package,
                    "Cannot access Visual Studio DTE.",
                    "Copilot Prompt Extension",
                    OLEMSGICON.OLEMSGICON_WARNING,
                    OLEMSGBUTTON.OLEMSGBUTTON_OK,
                    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
                return;
            }

            var solution = dte.Solution;

            if (solution == null || string.IsNullOrEmpty(solution.FullName))
            {
                VsShellUtilities.ShowMessageBox(
                    this.package,
                    "No solution is currently open.",
                    "Copilot Prompt Extension",
                    OLEMSGICON.OLEMSGICON_INFO,
                    OLEMSGBUTTON.OLEMSGBUTTON_OK,
                    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
                return;
            }

            var message = new System.Text.StringBuilder();
            message.AppendLine("Solution: " + solution.FullName);
            message.AppendLine();

            foreach (Project project in solution.Projects)
            {
                if (project == null)
                    continue;

                message.AppendLine("Project: " + project.Name);

                try
                {
                    if (project.ProjectItems != null)
                    {
                        foreach (ProjectItem item in project.ProjectItems)
                        {
                            AppendProjectItem(item, message, "  ");
                        }
                    }
                }
                catch (Exception ex)
                {
                    message.AppendLine("  [Error reading project items: " + ex.Message + "]");
                }

                message.AppendLine();
            }

            VsShellUtilities.ShowMessageBox(
                this.package,
                message.ToString(),
                "Solution Explorer Info",
                OLEMSGICON.OLEMSGICON_INFO,
                OLEMSGBUTTON.OLEMSGBUTTON_OK,
                OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
        }
        private void AppendProjectItem(ProjectItem item, System.Text.StringBuilder message, string indent)
        {
            ThreadHelper.ThrowIfNotOnUIThread();

            if (item == null)
                return;

            message.AppendLine(indent + "- " + item.Name);

            if (item.ProjectItems == null)
                return;

            foreach (ProjectItem childItem in item.ProjectItems)
            {
                AppendProjectItem(childItem, message, indent + "  ");
            }
        }
    }
}
