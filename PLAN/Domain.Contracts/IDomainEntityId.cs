namespace Domain.Contracts;

public class IDomainEntityId : IDomainEntityId<Guid>
{
}

public class IDomainEntityId<TKey>
where TKey: struct, IEquatable<TKey>
{
    private TKey Id { get; set; }
}