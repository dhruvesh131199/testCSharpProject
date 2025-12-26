# Prompts for C# test project

This folder contains prompt templates you can use with the Streamlit UI or orchestrator when testing code generation against this sample C# project.

Files:
- `001_create_discount_service.txt` — add a DiscountService and a simple xUnit test.
- `002_implement_get_recommended.txt` — implement the GetRecommendedBooks TODO in BookService.

Usage:
- Open the prompt file, copy the contents into the Streamlit prompt box, and run a dry-run first.
- Alternatively, the orchestrator can load prompt files programmatically if configured.

Safety:
- Start with the sandbox: `testCSharpProject-sandbox` if you don't want to modify the original sample project.
