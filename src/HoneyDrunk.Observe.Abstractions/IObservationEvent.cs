namespace HoneyDrunk.Observe.Abstractions;

/// <summary>
/// Represents a normalized observation event emitted by an observation connector.
/// </summary>
/// <remarks>
/// Raw provider payloads must be translated into this canonical shape before they
/// cross the Observe boundary.
/// </remarks>
public interface IObservationEvent
{
    /// <summary>
    /// Gets the stable event identifier assigned by the connector or normalization runtime.
    /// </summary>
    public string EventId { get; }

    /// <summary>
    /// Gets the observation target identifier associated with the event.
    /// </summary>
    public string TargetId { get; }

    /// <summary>
    /// Gets the UTC timestamp when the external condition was observed.
    /// </summary>
    public DateTimeOffset ObservedAt { get; }

    /// <summary>
    /// Gets the normalized event kind.
    /// </summary>
    /// <remarks>
    /// Examples include <c>health</c>, <c>state-change</c>, <c>alert</c>,
    /// <c>issue</c>, <c>pull-request</c>, and <c>workflow</c>.
    /// </remarks>
    public string Kind { get; }

    /// <summary>
    /// Gets the normalized severity for the observation event.
    /// </summary>
    /// <remarks>
    /// Examples include <c>trace</c>, <c>information</c>, <c>warning</c>,
    /// <c>error</c>, and <c>critical</c>.
    /// </remarks>
    public string Severity { get; }

    /// <summary>
    /// Gets normalized event data safe to pass beyond the Observe boundary.
    /// </summary>
    public IReadOnlyDictionary<string, string> Payload { get; }

    /// <summary>
    /// Gets the connector kind that produced the observation event.
    /// </summary>
    public string SourceConnector { get; }
}
