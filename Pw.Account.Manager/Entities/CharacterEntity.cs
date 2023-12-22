using Pw.Account.Manager.Abstract;
using Pw.Account.Manager.Contracts;

namespace Pw.Account.Manager.Entities;

public class CharacterEntity : EntityBase
{
    /// <summary>
    /// Имя персонажа
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Уровень персонажа
    /// </summary>
    public int Level { get; set; }
    
    /// <summary>
    /// Класс
    /// </summary>
    public CharacterClass Class { get; set; }
    
    /// <summary>
    /// Аккаунт
    /// </summary>
    public AccountEntity Account { get; set; }
    public string AccountId { get; set; }
}