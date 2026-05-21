namespace HoneyDrunk.Observe.Abstractions;

/// <summary>
/// Declares an external system that can be observed by an observation connector.
/// </summary>
/// <remarks>
/// Targets carry a credential reference only. Connector implementations resolve the
/// referenced secret through the Grid secret boundary at connection time; raw tokens,
/// passwords, or API keys must never be stored on the target contract.
/// </remarks>
public interface IObservationTarget
{
    /// <summary>
    /// Gets the stable target identifier within the Observe boundary.
    /// </summary>
    public string TargetId { get; }

    /// <summary>
    /// Gets the connector kind used to select a provider-slot connector implementation.
    /// </summary>
    /// <remarks>
    /// Examples include <c>github</c>, <c>azure</c>, and <c>http</c>.
    /// </remarks>
    public string ConnectorKind { get; }

    /// <summary>
    /// Gets the Vault secret name or handle used by the connector to resolve credentials.
    /// </summary>
    public string CredentialSecretName { get; }

    /// <summary>
    /// Gets the optional human-readable display name for operators and planning surfaces.
    /// </summary>
    public string? DisplayName { get; }

    /// <summary>
    /// Gets connector-specific configuration values for the target.
    /// </summary>
    /// <remarks>
    /// Values must be non-secret configuration only. Secrets belong behind
    /// <see cref="CredentialSecretName" />.
    /// </remarks>
    public IReadOnlyDictionary<string, string> Configuration { get; }
}
