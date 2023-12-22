namespace Pw.Account.Manager.Abstract;


/// <summary>
/// Сущность
/// </summary>
/// <typeparam name="T">Тип идентификатора</typeparam>
public interface IEntity<T>
{
    T Id { get; set; }
}