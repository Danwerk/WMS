using Base.Contracts.Domain;

namespace Base.Domain;

public abstract class DomainEntityIdMetadata : DomainEntityIdMetadata<Guid>, IDomainEntityMetadata
{
    
}

public abstract class DomainEntityIdMetadata<TKey> : DomainEntityId<TKey> , IDomainEntityMetadata
    where TKey : struct, IEquatable<TKey>
{
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
}