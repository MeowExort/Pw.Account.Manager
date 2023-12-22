using System.ComponentModel.DataAnnotations;

namespace Pw.Account.Manager.Contracts.Models;

public class AccountSettingsDto : EntityDto
{
    public AccountDto Account { get; set; }
    public string AccountId { get; set; }

    /// <summary>
    /// Использовать отдельный профиль браузера
    /// </summary>
    [Display(Name = "Использовать отдельный профиль браузера",
        Description =
            "Создает под этот аккаунт отдельный профиль в браузере (хранится в папке data рядом с приложением")]
    public bool UseBrowserProfile { get; set; } = true;
}