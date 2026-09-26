# Changelog

## [0.1.1] - 2026-09-26

### Changed

- Refresh dependency and shared build-tooling versions; preserve target frameworks and existing public contracts. See the [repository dependency changes](../../CHANGELOG.md).

## Unreleased

- Refreshed HoneyDrunk.Standards to 0.2.9 for ADR-0047 testing/tooling alignment.

## 0.1.0 - Initial release

- Created the Abstractions package scaffold with package metadata and README/CHANGELOG files.
- Added `IObservationTarget` for external-system target declarations with credential references.
- Added `IObservationConnector` for provider-slot connector implementations.
- Added `IObservationEvent` as the canonical normalized observation event contract.
