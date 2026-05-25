# Changelog

## Unreleased

### Changed

- Onboarded Observe to SonarQube Cloud (ADR-0011 D11). Wired a `sonarcloud` job in `pr.yml` (renamed from `pr-core.yml` to match the Grid convention) that calls `HoneyDrunkStudios/HoneyDrunk.Actions/.github/workflows/job-sonarcloud.yml` on both `pull_request` (after `pr-core` succeeds) and `push` to `main` (standalone), both gated by the existing `preflight` solution-detection so analysis skips cleanly while the Node is still scaffold-only. PR analysis gates the merge on new-code findings; main-branch analysis populates the SonarCloud Overview dashboard and the leak-period baseline. The job-level `name: PR Core` is preserved so the existing branch-protection check name continues to match after the file rename. Branch-protection requirement for the new SonarQube Cloud check added separately after the first successful run lands.
- Refreshed HoneyDrunk.Standards to 0.2.9 for ADR-0047 testing/tooling alignment.

## 0.1.0 - Initial scaffold

### Added

- Created the `HoneyDrunk.Observe` solution scaffold.
- Added the `HoneyDrunk.Observe.Abstractions` package.
- Added `IObservationTarget`, `IObservationConnector`, and `IObservationEvent` contracts for the Observation Layer Phase 1 surface.
- Added repo and package README/CHANGELOG files.
