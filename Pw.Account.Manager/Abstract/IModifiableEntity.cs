namespace Pw.Account.Manager.Abstract;

/// <summary>
/// Изменяемая сущность
/// </summary>
public interface IModifiableEntity
{
    DateTime? ModifiedAt { get; set; }
}