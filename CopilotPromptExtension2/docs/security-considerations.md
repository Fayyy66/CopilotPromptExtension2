# Security Considerations

- Do not include secrets, credentials, connection strings, tokens, or private customer data in generated prompts.
- Treat requirement documents as potentially sensitive. Review copied prompt content before sharing it with any external service.
- Keep generated code subject to normal pull request review, static analysis, and test gates.
- When internal APIs or libraries are referenced, include only the minimum context needed for code generation.
- Future Roslyn extraction should redact literal secrets and large data payloads before prompt construction.
