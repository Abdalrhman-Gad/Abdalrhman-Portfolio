# Abdalrhman Portfolio

This repository is now split into a front-end Angular application and a back-end ASP.NET Core API so that the portfolio content can be managed dynamically from a SQLite database.

## Project structure

```
backend/
  Portfolio.sln          # Solution that wires the clean architecture backend
  Portfolio.Api/         # ASP.NET Core Web API (presentation layer)
  Portfolio.Application/ # Application layer with DTOs and service contracts
  Portfolio.Domain/      # Domain entities
  Portfolio.Infrastructure/ # EF Core persistence and service implementations
frontend/
  ...                    # Angular 20 SPA that consumes the API
```

## Prerequisites

- Node.js 18+
- .NET 8 SDK (the API uses EF Core with SQLite)

## Running the back end

```bash
cd backend/Portfolio.Api
# Restore dependencies (first time only)
dotnet restore
# Run the API (listening on http://localhost:5000 by default)
dotnet run --urls http://localhost:5000
```

The first run creates `portfolio.db` and seeds it with the profile, experience, skills, and projects that the Angular app renders.

## Running the front end

```bash
cd frontend
npm install
npm start
```

The Angular app expects the API at `http://localhost:5000/api`. You can change the base URL in `frontend/src/environments/environment.ts` (development) or `frontend/src/environments/environment.production.ts` (production builds).

## Useful commands

- **Front end build:** `npm run build` (from `frontend/`)
- **Front end tests:** `npm test`
- **Back end build:** `dotnet build backend/Portfolio.sln`

## API overview

The API currently exposes a single endpoint:

- `GET /api/profile` — returns the entire portfolio payload, including summary, links, skills, experience, education, and interests.

The Angular application consumes this endpoint to populate all sections of the portfolio dynamically.
