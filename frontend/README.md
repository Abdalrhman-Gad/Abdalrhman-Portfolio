# Front-end (Angular)

This folder contains the Angular 20 single-page application for Abdalrhman Gad's portfolio. It consumes the .NET API in `../backend/Portfolio.Api` to populate all sections dynamically.

## Prerequisites

- Node.js 18+
- The back-end API running locally (see the repository root `README.md`)

## Development

```bash
cd frontend
npm install
npm start
```

The dev server runs on `http://localhost:4200/` and the app calls the API at `http://localhost:5000/api` (configurable via the environment files below).

## Configuration

- `src/environments/environment.ts` — development API base URL (`http://localhost:5000/api` by default)
- `src/environments/environment.production.ts` — production build API base URL (`/api` by default)

## Building

```bash
npm run build
```

The optimized build is emitted to `dist/abdalrhman-portfolio`.

## Testing

```bash
npm test
```

Runs the Angular unit tests with the HttpClient testing backend.
