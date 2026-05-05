# Usage Guide

## Generate a Scaffold Prompt

1. Open a solution in Visual Studio 2022.
2. Install and run the VSIX in the Experimental instance.
3. Select `Tools > Generate Copilot Scaffold Prompt`.
4. Review the generated prompt.
5. Replace the placeholder feature names and technical requirement text.
6. Paste the prompt into Copilot Chat.

## Recommended Prompt Inputs

- Target feature name, for example `PaymentSchedule`.
- Existing reference feature name, for example `CustomerProfile`.
- Technical requirement document content or a concise requirement summary.
- Any internal API, logging, security, or validation constraints that should be enforced.

## Expected Copilot Output

Copilot should first describe the reference patterns it detected, then propose a target file list, then generate controllers, models, mappers, requestors, and unit tests in small chunks.
