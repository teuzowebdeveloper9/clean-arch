# Clean Architecture API - C# Example

This project is a simple API developed in C# to serve as a foundation for Clean Architecture studies.

##Project Structure

The project is divided into layers following the Clean Architecture principles:

- **essential/**
- `MyApp.domain/`: Domain entities and interfaces.
- `MyApp.aplication/`: Business rules and use cases.
- **infrastructure/**
- `MyApp.persistence/`: Persistence implementation (EF Core, repositories).
- `MyApp.infrastructure/`: Other external dependencies.
- **presentation/**
- `cleanArch.API/`: ASP.NET Core API (system entry point).
- **tests/**
- `MyApp.Tests/`: Automated tests.

## How to Run

1. Install the [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0).
2. Restore the packages:
```sh
dotnet restore
```
3. Run an API:
```sh
dotnet run --project presentation/cleanArch.API/cleanArch.API.csproj
```
4. Access the `/weatherforecast` route to test the example endpoint.

## About

This project is just a starting point for learning Clean Architecture. Feel free to expand, create new use cases, entities, and implement business rules.

---
Made for study by [Your Name].