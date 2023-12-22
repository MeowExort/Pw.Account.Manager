namespace Pw.Account.Manager.Abstract;

/// <summary>
/// Создаваемая сущность
/// </summary>
public interface ICreatableEntity
{
    DateTime CreatedAt { get; set; }   
}