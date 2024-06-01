﻿using Domain.Contracts.Base;

namespace Base.Domain;

public class DomainEntityId : DomainEntityId<Guid>, IDomainEntityId
{
}

public abstract class DomainEntityId<TKey> : IDomainEntityId<TKey>
    where TKey: struct, IEquatable<TKey>
{
    public TKey Id { get; set; }
}