# Changelog

## Unreleased

### Changed

- Onboarded Observe to SonarQube Cloud (ADR-0011 D11). Added `sonar-project.properties` at the repo root and wired a `sonarcloud` job in `pr.yml` (renamed from `pr-core.yml` to match the Grid convention) that calls `HoneyDrunk.Actions/.github/workflows/job-sonarcloud.yml` after `pr-core`, gated by the existing `preflight` solution-detection so it skips cleanly while the Node is still scaffold-only. The job-level `name: PR Core` is preserved so the existing branch-protection check name continues to match. Sources cover `src/`; Abstractions excluded from coverage. As runtime + provider packages land, they are picked up automatically via the `src/` glob. Branch-protection requirement for the SonarQube Cloud check added separately after the first successful run lands.
- Refreshed HoneyDrunk.Standards to 0.2.9 for ADR-0047 testing/tooling alignment.

## 0.1.0 - Initial scaffold

### Added

- Created the `HoneyDrunk.Observe` solution scaffold.
- Added the `HoneyDrunk.Observe.Abstractions` package.
- Added `IObservationTarget`, `IObservationConnector`, and `IObservationEvent` contracts for the Observation Layer Phase 1 surface.
- Added repo and package README/CHANGELOG files.
