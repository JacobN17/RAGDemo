using RAGDemo.Domain.Models;

namespace RAGDemo.Domain.Entities;

public sealed class RagInteraction
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string SessionId { get; init; } = string.Empty;
    public string UserPrompt { get; init; } = string.Empty;
    public string GeneratedResponse { get; init; } = string.Empty;
    public IReadOnlyList<long> RetrievedChunkIds { get; init; } = [];
    public TimeSpan Latency { get; init; } = TimeSpan.Zero;
    public int PromptTokens { get; init; }
    public int CompletionTokens { get; init; }
    public IReadOnlyList<EvaluationMetric> EvaluationMetrics { get; set; } = [];
    public DateTimeOffset CreatedAtUtc { get; init; } = DateTimeOffset.UtcNow;
}
