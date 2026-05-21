namespace HoneyDrunk.Observe.Abstractions;

/// <summary>
/// Defines the provider-slot contract implemented by external-system observation connectors.
/// </summary>
/// <remarks>
/// Connector implementations translate source-specific events into normalized
/// <see cref="IObservationEvent" /> instances before the event leaves the Observe boundary.
/// </remarks>
public interface IObservationConnector
{
    /// <summary>
    /// Gets the connector kind handled by this connector implementation.
    /// </summary>
    /// <remarks>
    /// The value is matched against <see cref="IObservationTarget.ConnectorKind" />.
    /// </remarks>
    public string ConnectorKind { get; }

    /// <summary>
    /// Establishes connector state for the specified observation target.
    /// </summary>
    /// <param name="target">The external system target to observe.</param>
    /// <param name="cancellationToken">A token that cancels the connection attempt.</param>
    /// <returns>A task that completes when the connector is ready to observe the target.</returns>
    public Task ConnectAsync(IObservationTarget target, CancellationToken cancellationToken = default);

    /// <summary>
    /// Streams normalized observation events for the specified target.
    /// </summary>
    /// <param name="target">The external system target being observed.</param>
    /// <param name="cancellationToken">A token that cancels event streaming.</param>
    /// <returns>An asynchronous stream of normalized observation events.</returns>
    public IAsyncEnumerable<IObservationEvent> ObserveAsync(IObservationTarget target, CancellationToken cancellationToken = default);

    /// <summary>
    /// Releases connector state for the specified observation target.
    /// </summary>
    /// <param name="target">The external system target to disconnect.</param>
    /// <param name="cancellationToken">A token that cancels the disconnect operation.</param>
    /// <returns>A task that completes when connector state has been released.</returns>
    public Task DisconnectAsync(IObservationTarget target, CancellationToken cancellationToken = default);
}
