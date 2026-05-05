namespace CopilotPromptExtension2
{
    internal sealed class DomainScaffoldingRequest
    {
        public string TargetFeatureName { get; set; }

        public string SourceFeatureName { get; set; }

        public string TechnicalRequirement { get; set; }

        public static DomainScaffoldingRequest CreateDefault()
        {
            return new DomainScaffoldingRequest
            {
                TargetFeatureName = "NewFeature",
                SourceFeatureName = "ExistingFeature",
                TechnicalRequirement = "Paste the technical requirement document here before sending this prompt to Copilot."
            };
        }
    }
}
