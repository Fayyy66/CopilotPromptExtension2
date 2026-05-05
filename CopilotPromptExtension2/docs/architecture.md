# Copilot Prompt Extension Architecture

## Purpose

This Visual Studio extension builds structured prompts for GitHub Copilot from an existing solution. The prompt captures solution structure, reference-domain naming patterns, engineering standards, and a technical requirement so developers can scaffold a parallel feature with consistent conventions.

## Current Prototype Flow

1. The user opens a solution in Visual Studio.
2. The user runs `Tools > Generate Copilot Scaffold Prompt`.
3. The extension extracts solution and project-item context through Visual Studio DTE.
4. `PromptTemplateBuilder` creates a structured prompt with feature mapping, standards, solution context, and expected output.
5. The prompt is copied to the clipboard and displayed for review.

## Main Components

- `CopilotPromptExtension2Package`: async VS package registration and command initialization.
- `GeneratePromptCommand`: Visual Studio command handler, DTE context extraction, clipboard integration, and user feedback.
- `ProjectContextSnapshot`: neutral model for extracted solution context.
- `DomainScaffoldingRequest`: request model for target feature, reference feature, and technical requirement.
- `PromptTemplateBuilder`: deterministic prompt generation logic that can be unit tested outside Visual Studio.

## Next Technical Milestones

- Replace DTE-only context extraction with Roslyn workspace analysis for syntax-aware controllers, models, mappers, requestors, async patterns, and test patterns.
- Add a Visual Studio dialog for target feature, source feature, and requirement document input.
- Add Git integration to show changed files and recent history after Copilot-assisted generation.
- Add a separate test project for prompt builder behavior and Roslyn extraction rules.
