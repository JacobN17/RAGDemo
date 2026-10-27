using RAGDemo.Domain.Entities;
using RAGDemo.Domain.Enums;

namespace RAGDemo.Domain.Models;

public sealed record ScoredChunk(
    DocumentChunk Chunk,
    float Score,
    int Rank = 1,
    SearchMode SearchMode = SearchMode.DenseVector
);
