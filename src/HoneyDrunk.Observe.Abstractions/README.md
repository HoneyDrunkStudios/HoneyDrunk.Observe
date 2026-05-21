# HoneyDrunk.Observe.Abstractions

Contracts package for the Grid inbound observation layer.

## Public surface

- `IObservationTarget` — declares an external system to observe, including target identity, connector selection, and a Vault-backed credential reference.
- `IObservationConnector` — provider-slot interface implemented by future connector packages.
- `IObservationEvent` — canonical normalized event shape emitted by connectors before events leave the Observe boundary.

## Boundary rules

- This package has no runtime HoneyDrunk dependencies.
- Targets carry credential references only; raw credentials do not belong in contracts.
- Connectors normalize source-specific payloads into `IObservationEvent` before handing events to downstream consumers.
