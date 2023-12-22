using System.ComponentModel.DataAnnotations;
using Pw.Account.Manager.Abstract;

namespace Pw.Account.Manager.Entities;

public class AccountEntity : EntityBase
{
    /// <summary>
    /// VK Play логин
    /// </summary>
    public string Login { get; set; }
    
    /// <summary>
    /// Игровой аккаунт
    /// </summary>
    public string GameAccount { get; set; }
    
    /// <summary>
    /// Аватар
    /// </summary>
    public string AvatarUri { get; set; }
    
    /// <summary>
    /// Древние монеты
    /// </summary>
    public double ChestPoints { get; set; }

    /// <summary>
    /// Персонажи
    /// </summary>
    public List<CharacterEntity> Characters { get; set; }

    /// <summary>
    /// Коробки
    /// </summary>
    public List<PromoBoxEntity> PromoBoxes { get; set; }

    /// <summary>
    /// Предметы
    /// </summary>
    public List<PromoItemEntity> PromoItems { get; set; }

    /// <summary>
    /// Настройки аккаунта
    /// </summary>
    public AccountSettingsEntity Settings { get; set; }
    
    /// <summary>
    /// Настройки аккаунта
    /// </summary>
    public string SettingsId { get; set; }
}