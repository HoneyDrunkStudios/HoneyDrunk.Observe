# HoneyDrunk.Observe agent instructions

Own inbound observation contracts for external systems. Current main is an Abstractions scaffold; runtime and connectors are planned. Do not claim connectors or watchers work from package names or planned documentation.

Start with [README.md](README.md) and the relevant source/tests. Project files and lockfiles own SDK, framework and dependency versions.

Read the [shared engineering conventions](https://github.com/HoneyDrunkStudios/HoneyDrunk.Standards/blob/main/HoneyDrunk.Standards/docs/CONVENTIONS.md) and this repository's owning documentation before editing. Apply the parts relevant to this stack; preserve existing public contracts, dependency direction and repository-specific behavior. Verify shared capabilities in current code before reusing them; a catalog entry or scaffold is not an implemented integration.

Work within the selected request. Preserve unrelated changes and use a separate worktree when needed. Review the final diff, use Conventional Commits and ready-for-review PRs with exactly one accurate `Authorship:` line and a `Request:` line; include the authorship in commit trailers. Run meaningful checks for the affected behavior and report the reviewed/tested revision, failures and unrun checks. For documentation-only changes, check links, paths and instruction consistency. Preserve required checks and inspect actual latest-head Sonar new-code findings where analysis applies; do not suppress findings or weaken gates to obtain a pass. Legacy Grid Review is retired; do not restore its workers, queues or bypass labels. A configured replacement reviewer is not evidence of a completed review or enforcing merge check.

## Verification

From the repository root for code/build changes:

```sh
dotnet restore HoneyDrunk.Observe.slnx
dotnet build HoneyDrunk.Observe.slnx -c Release --no-restore
```

Current main has no test project; a successful `dotnet test` invocation would not prove executed tests. Use the checked-in workflow for current contract/build checks and document missing runtime/connector verification. Do not use live resources or credentials merely to make a local check pass.

## Code Review Rules

Apply the [shared review criteria](https://github.com/HoneyDrunkStudios/HoneyDrunk.Standards/blob/main/HoneyDrunk.Standards/docs/CONVENTIONS.md#code-review) to changed behavior, using the repository boundaries above. Report actionable findings with the failing path, concrete impact and a small corrective action; disclose unavailable evidence. These rules grant no cross-repository access or merge authority.

- Preserve inbound observation contracts and the current Abstractions-only boundary. Do not describe planned connectors/watchers as working or add runtime dependencies to contracts without an approved implementation scope.
- For new or changed event contracts, check source identity, tenant/context isolation, time semantics and compatibility. Treat external observations as untrusted input; they must not implicitly authorize outbound actions.
- Require contract evidence for changed shapes and appropriate failure/replay/cancellation tests if runtime behavior is actually introduced. Do not fabricate executable verification for the scaffold or propose a generic watcher framework from the repository name.
