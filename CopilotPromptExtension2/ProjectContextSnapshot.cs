using System.Collections.Generic;

namespace CopilotPromptExtension2
{
    internal sealed class ProjectContextSnapshot
    {
        public ProjectContextSnapshot(string solutionPath)
        {
            SolutionPath = solutionPath;
            Projects = new List<ProjectContextInfo>();
        }

        public string SolutionPath { get; }

        public IList<ProjectContextInfo> Projects { get; }

        public GitContextInfo GitContext { get; set; }
    }

    internal sealed class ProjectContextInfo
    {
        public ProjectContextInfo(string name)
        {
            Name = name;
            Items = new List<ProjectItemContextInfo>();
        }

        public string Name { get; }

        public IList<ProjectItemContextInfo> Items { get; }
    }

    internal sealed class ProjectItemContextInfo
    {
        public ProjectItemContextInfo(string name, string kind, int depth)
        {
            Name = name;
            Kind = kind;
            Depth = depth;
        }

        public string Name { get; }

        public string Kind { get; }

        public int Depth { get; }
    }
}
