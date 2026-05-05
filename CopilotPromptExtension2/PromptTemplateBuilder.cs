using System;
using System.Linq;
using System.Text;

namespace CopilotPromptExtension2
{
    internal sealed class PromptTemplateBuilder
    {
        public string Build(DomainScaffoldingRequest request, ProjectContextSnapshot snapshot)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (snapshot == null)
            {
                throw new ArgumentNullException(nameof(snapshot));
            }

            var prompt = new StringBuilder();
            prompt.AppendLine("# Copilot Domain Scaffold Prompt");
            prompt.AppendLine();
            prompt.AppendLine("## Goal");
            prompt.AppendLine("Generate a production-ready feature scaffold using an existing domain as the reference implementation.");
            prompt.AppendLine();
            prompt.AppendLine("## Feature Mapping");
            prompt.AppendLine("- Target feature: " + Normalize(request.TargetFeatureName));
            prompt.AppendLine("- Reference feature: " + Normalize(request.SourceFeatureName));
            prompt.AppendLine();
            prompt.AppendLine("## Technical Requirement");
            prompt.AppendLine(Normalize(request.TechnicalRequirement));
            prompt.AppendLine();
            prompt.AppendLine("## Engineering Standards");
            prompt.AppendLine("- Follow the existing project structure and naming conventions.");
            prompt.AppendLine("- Apply SOLID principles and keep responsibilities separated.");
            prompt.AppendLine("- Prefer async/await for I/O-bound work and avoid blocking calls.");
            prompt.AppendLine("- Reuse internal logging, validation, mapping, requestor, and error-handling patterns already present in the solution.");
            prompt.AppendLine("- Generate controllers, models, mappers, requestors, service interfaces, implementations, and unit tests when the reference feature contains equivalent artifacts.");
            prompt.AppendLine("- Keep public contracts explicit and avoid leaking transport models into domain logic.");
            prompt.AppendLine("- Include meaningful unit tests for success, validation failure, dependency failure, and mapping behavior.");
            prompt.AppendLine();
            prompt.AppendLine("## Current Solution Context");
            prompt.AppendLine("- Solution: " + snapshot.SolutionPath);

            foreach (var project in snapshot.Projects.OrderBy(p => p.Name))
            {
                prompt.AppendLine("- Project: " + project.Name);
                AppendDetectedPatterns(prompt, project);

                foreach (var item in project.Items.Take(120))
                {
                    prompt.AppendLine("  " + new string(' ', item.Depth * 2) + "- " + item.Name + " [" + item.Kind + "]");
                }

                if (project.Items.Count > 120)
                {
                    prompt.AppendLine("  - ... " + (project.Items.Count - 120).ToString() + " additional items omitted for prompt size.");
                }
            }

            AppendGitContext(prompt, snapshot.GitContext);

            prompt.AppendLine();
            prompt.AppendLine("## Output Required");
            prompt.AppendLine("1. Summarise the reference-domain patterns you found.");
            prompt.AppendLine("2. Propose the target-domain file list before generating code.");
            prompt.AppendLine("3. Generate code in small, reviewable chunks.");
            prompt.AppendLine("4. List modified files and explain how each file maps to the requirement.");
            prompt.AppendLine("5. Call out any assumptions, missing requirement details, or security concerns.");

            return prompt.ToString();
        }

        private static void AppendGitContext(StringBuilder prompt, GitContextInfo gitContext)
        {
            prompt.AppendLine();
            prompt.AppendLine("## Git Context");

            if (gitContext == null || !gitContext.IsAvailable)
            {
                prompt.AppendLine("- Git context unavailable: " + Normalize(gitContext == null ? null : gitContext.Error));
                return;
            }

            prompt.AppendLine("### Modified Files");
            prompt.AppendLine(string.IsNullOrWhiteSpace(gitContext.ModifiedFiles) ? "No modified files reported by git status." : gitContext.ModifiedFiles);
            prompt.AppendLine();
            prompt.AppendLine("### Recent History");
            prompt.AppendLine(string.IsNullOrWhiteSpace(gitContext.RecentHistory) ? "No recent commits reported by git log." : gitContext.RecentHistory);
        }

        private static void AppendDetectedPatterns(StringBuilder prompt, ProjectContextInfo project)
        {
            var controllerCount = CountBySuffix(project, "Controller.cs");
            var modelCount = CountByFolderOrSuffix(project, "Models", ".cs");
            var mapperCount = CountByName(project, "Mapper");
            var requestorCount = CountByName(project, "Requestor");
            var testCount = CountByName(project, "Test");

            if (controllerCount + modelCount + mapperCount + requestorCount + testCount == 0)
            {
                return;
            }

            prompt.AppendLine("  Detected patterns:");
            prompt.AppendLine("  - Controllers: " + controllerCount.ToString());
            prompt.AppendLine("  - Models: " + modelCount.ToString());
            prompt.AppendLine("  - Mappers: " + mapperCount.ToString());
            prompt.AppendLine("  - Requestors: " + requestorCount.ToString());
            prompt.AppendLine("  - Tests: " + testCount.ToString());
        }

        private static int CountBySuffix(ProjectContextInfo project, string suffix)
        {
            return project.Items.Count(i => i.Name.EndsWith(suffix, StringComparison.OrdinalIgnoreCase));
        }

        private static int CountByName(ProjectContextInfo project, string token)
        {
            return project.Items.Count(i => i.Name.IndexOf(token, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private static int CountByFolderOrSuffix(ProjectContextInfo project, string folderToken, string suffix)
        {
            return project.Items.Count(i =>
                i.Name.IndexOf(folderToken, StringComparison.OrdinalIgnoreCase) >= 0 ||
                i.Name.EndsWith(suffix, StringComparison.OrdinalIgnoreCase) &&
                (i.Name.IndexOf("Model", StringComparison.OrdinalIgnoreCase) >= 0 ||
                 i.Name.IndexOf("Dto", StringComparison.OrdinalIgnoreCase) >= 0 ||
                 i.Name.IndexOf("Request", StringComparison.OrdinalIgnoreCase) >= 0 ||
                 i.Name.IndexOf("Response", StringComparison.OrdinalIgnoreCase) >= 0));
        }

        private static string Normalize(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? "Not specified" : value.Trim();
        }
    }
}
