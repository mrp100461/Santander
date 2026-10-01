# Santander

> [One-sentence description of what the application does.]

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4)
![C#](https://img.shields.io/badge/C%23-14-239120)
![License](https://img.shields.io/badge/license-MIT-blue)

## Overview
[What problem it solves, who uses it, and the key design idea.]

## Features
- The main endpoint is to provide a simple and efficient way to interact with the Santander API. https://localhost:7230/api/v1/Stories?n=5 could not be tested in 2026 http file request is timing out 
- Test features  https://localhost:7230/api/v1/Stories?id=1 gets the story with id 1
- Test features  https://localhost:7230/api/v1/Stories?n=5 gets thethe top five storeies ordered by score

## Requirements
- Windows 10/11
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Visual Studio 2026 (or a recent 2022 release with .NET 10 support), or VS Code with the C# Dev Kit

Check your installed SDK:
```powershell
dotnet --version
```

## Getting Started

### Clone and build
```powershell
git clone <repository-url> C:\Dev\Santander
cd C:\Dev\Santander\Santander
dotnet restore
dotnet build --configuration debug
```

### Run
```powershell
dotnet run --project .\Santander.csproj
or 
press https5**.
```
## Configuration
TODO: Add a sample `appsettings.json` with placeholders for sensitive information.
Settings are read from `appsettings.json`, with environment variables and user secrets taking precedence.
```json
{
  "ConnectionStrings": {
    "Default": "Server=...;Database=...;Trusted_Connection=True;"
  },
  "Logging": {
    "LogLevel": { "Default": "Information" }
  }
}
```
TODO: Add instructions for setting environment variables for sensitive information.
Store secrets locally with:
```powershell
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:Default" "<value>"
```

## Usage
[Short example: CLI command, API request, or screenshot.]

```powershell
dotnet run -- --help
```

## Project Structure
```
Santander/
├── Santander.sln
└── Santander/
    ├── Program.cs          # Entry point
    ├── appsettings.json    # Configuration
    ├── Models/             # Domain and DTO classes
    ├── Services/           # Business logic
    └── Santander.csproj    # TargetFramework: net10.0
```

## Testing
TODO: Add unit and integration tests in a `Tests` project. Run tests with:

```
Visual studio test explorer
```

## TODO
1. Add caching and performance optimizations
2. Add resilence pipeline
3. Add or update tests
4. Add appsettings.json with placeholders for sensitive information
5. Add instructions for setting environment variables for sensitive information
6. Get OpenAPI to work 2026 seems not work 
7. Find out why http file request is not working in 2026 with main request times out after 20 seconds, but works in 2022 with other application.
8. Add to docker
9. Add docker instructions and docker compose file for local development and testing




## License
Distributed under the MIT License. See `LICENSE` for details.