# HoneyDrunk.Observe

HoneyDrunk.Observe is the Grid's Ops-sector inbound observation Node for external projects and services. It provides contracts and, later, runtime connector packages that let the Hive watch systems it does not own, normalize external signals, and maintain observation state for future planning surfaces.

## Status

Seed. The first package is the contracts-only Abstractions package; runtime and connector implementations are planned follow-up work.

## Packages

| Package | Status | Purpose |
|---------|--------|---------|
| `HoneyDrunk.Observe.Abstractions` | Initial scaffold | Observation targets, connector provider-slot contract, and normalized observation event contract. |
| `HoneyDrunk.Observe` | Planned | Runtime composition, event normalization pipeline, and observation state. |
| `HoneyDrunk.Observe.Connectors.GitHub` | Planned | GitHub webhook intake, repository health checks, PR and issue state. |
| `HoneyDrunk.Observe.Connectors.Azure` | Planned | Azure Monitor alerts, deployment state, and resource health. |
| `HoneyDrunk.Observe.Connectors.Http` | Planned | Generic HTTP health check observation. |

## Catalog

Canonical Node metadata lives in the HoneyDrunk Architecture catalog: <https://github.com/HoneyDrunkStudios/HoneyDrunk.Architecture/blob/main/catalogs/nodes.json>.

## Boundary

Observe receives and normalizes external-system signals. It does not own outbound telemetry routing, internal Grid telemetry, credential storage, or planning decisions.
