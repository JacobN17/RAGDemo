namespace RAGDemo.Domain.Exceptions;

public sealed class VectorDimensionMismatchException : DomainException
{
    public int ExpectedDimension { get; }
    public int ActualDimension { get; }

    public VectorDimensionMismatchException(int expectedDimension, int actualDimension)
        : base($"Vector dimension mismatch: expected {expectedDimension}, but got {actualDimension}.")
    {
        ExpectedDimension = expectedDimension;
        ActualDimension = actualDimension;
    }
}
