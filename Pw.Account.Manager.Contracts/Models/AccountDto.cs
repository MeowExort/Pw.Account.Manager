using System.ComponentModel.DataAnnotations;

namespace Pw.Account.Manager.Contracts.Models;

public class AccountDto : EntityDto
{
    /// <summary>
    /// VK Play логин
    /// </summary>
    [Display(Name = "VK PLay логин")]
    public string Login { get; set; }
    
    /// <summary>
    /// Игровой аккаунт
    /// </summary>
    [Display(Name = "Игровой аккаунт")]
    public string GameAccount { get; set; }
    
    /// <summary>
    /// Аватар
    /// </summary>
    [Display(Name = "Аватар")]
    public string AvatarUri { get; set; }
    
    /// <summary>
    /// Древние монеты
    /// </summary>
    [Display(Name = "Древние монеты")]
    public double ChestPoints { get; set; }

    /// <summary>
    /// Персонажи
    /// </summary>
    [Display(Name = "Персонажи")]
    public List<CharacterDto> Characters { get; set; }

    /// <summary>
    /// Коробки
    /// </summary>
    [Display(Name = "Коробки")]
    public List<PromoBoxDto> PromoBoxes { get; set; }

    /// <summary>
    /// Предметы
    /// </summary>
    [Display(Name = "Предметы")]
    public List<PromoItemDto> PromoItems { get; set; }

    /// <summary>
    /// Настройки аккаунта
    /// </summary>
    [Display(Name = "Настройки аккаунта")]
    public AccountSettingsDto Settings { get; set; }
    
    /// <summary>
    /// Настройки аккаунта
    /// </summary>
    public string SettingsId { get; set; }
}