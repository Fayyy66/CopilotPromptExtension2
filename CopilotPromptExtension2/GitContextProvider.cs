using System;
using System.Diagnostics;
using System.IO;

namespace CopilotPromptExtension2
{
    internal sealed class GitContextProvider
    {
        public GitContextInfo GetContext(string solutionPath)
        {
            if (string.IsNullOrWhiteSpace(solutionPath))
            {
                return GitContextInfo.NotAvailable("Solution path is not available.");
            }

            var workingDirectory = Path.GetDirectoryName(solutionPath);
            if (string.IsNullOrWhiteSpace(workingDirectory) || !Directory.Exists(workingDirectory))
            {
                return GitContextInfo.NotAvailable("Solution directory does not exist.");
            }

            try
            {
                var status = RunGit(workingDirectory, "status --short");
                var history = RunGit(workingDirectory, "log --oneline -5");

                return new GitContextInfo
                {
                    IsAvailable = status.ExitCode == 0 && history.ExitCode == 0,
                    ModifiedFiles = status.Output,
                    RecentHistory = history.Output,
                    Error = status.ExitCode == 0 ? history.Error : status.Error
                };
            }
            catch (Exception ex)
            {
                return GitContextInfo.NotAvailable(ex.Message);
            }
        }

        private static GitCommandResult RunGit(string workingDirectory, string arguments)
        {
            using (var process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = arguments,
                    WorkingDirectory = workingDirectory,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                process.Start();

                if (!process.WaitForExit(2000))
                {
                    try
                    {
                        process.Kill();
                    }
                    catch (InvalidOperationException)
                    {
                    }

                    return new GitCommandResult(-1, string.Empty, "Git command timed out.");
                }

                return new GitCommandResult(
                    process.ExitCode,
                    process.StandardOutput.ReadToEnd().Trim(),
                    process.StandardError.ReadToEnd().Trim());
            }
        }
    }

    internal sealed class GitContextInfo
    {
        public bool IsAvailable { get; set; }

        public string ModifiedFiles { get; set; }

        public string RecentHistory { get; set; }

        public string Error { get; set; }

        public static GitContextInfo NotAvailable(string error)
        {
            return new GitContextInfo
            {
                IsAvailable = false,
                ModifiedFiles = string.Empty,
                RecentHistory = string.Empty,
                Error = error
            };
        }
    }

    internal sealed class GitCommandResult
    {
        public GitCommandResult(int exitCode, string output, string error)
        {
            ExitCode = exitCode;
            Output = output;
            Error = error;
        }

        public int ExitCode { get; }

        public string Output { get; }

        public string Error { get; }
    }
}
