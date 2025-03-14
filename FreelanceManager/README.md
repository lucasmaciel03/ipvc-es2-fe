# Freelance Manager

A freelance management application built with .NET and Syncfusion Blazor components.

## Setup Instructions

### Environment Variables

This project uses Syncfusion components that require a license key. To set up your environment:

1. Create a `.env` file in the root directory (or copy from `.env.example`)
2. Add your Syncfusion license key to the `.env` file:

```
SYNCFUSION_LICENSE_KEY=YOUR_SYNCFUSION_LICENSE_KEY
```

**Note:** The `.env` file is included in `.gitignore` to prevent committing sensitive information to the repository.

### Running the Application

To run the application:

```bash
dotnet watch run --project FreelanceManager.csproj
```

## Features

- Modern UI with Syncfusion Blazor components
- Material3 theme for consistent styling
- Responsive sidebar navigation
- Project management capabilities

## Dependencies

- .NET 8.0+
- Syncfusion Blazor Components
- DotNetEnv (for environment variable management)
