namespace Pw.Account.Manager.Abstract;

/// <summary>
/// Базовая сущность
/// </summary>
public abstract class EntityBase : IEntity<string>, IModifiableEntity, ICreatableEntity
{
    public string Id { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public DateTime CreatedAt { get; set; }
}