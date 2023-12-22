using Pw.Account.Manager.Abstract;

namespace Pw.Account.Manager.Entities;

/// <summary>
/// 
/// </summary>
public class AccountSettingsEntity : EntityBase
{
    public AccountEntity Account { get; set; }
    public string AccountId { get; set; }

    /// <summary>
    /// Использовать отдельный профиль браузера
    /// </summary>
    public bool UseBrowserProfile { get; set; } = true;
}