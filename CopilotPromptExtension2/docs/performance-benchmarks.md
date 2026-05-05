# Performance Benchmarks

## Prototype Baseline

The current prototype extracts project-item metadata through Visual Studio DTE and limits each project to 120 items in the prompt. This keeps prompt generation responsive for small and medium solutions.

## Measurement Plan

- Measure prompt generation time for solutions with 1, 10, and 50 projects.
- Measure generated prompt size in characters and approximate tokens.
- Track Visual Studio UI-thread time separately from background extraction work.
- Add benchmarks for Roslyn analysis once syntax-aware extraction is introduced.

## Initial Target

- Prompt generation for a medium solution should complete in under 2 seconds.
- UI-thread blocking work should stay under 250 ms where possible.
