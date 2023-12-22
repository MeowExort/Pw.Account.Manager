namespace Pw.Account.Manager.Contracts.Models;

public class PromoItemDto : EntityDto
{
    /// <summary>
    /// Иденификатор конкретного экземляра предмета
    /// </summary>
    public int ItemId { get; set; }
    
    /// <summary>
    /// Название предмета
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Описание предмета
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Тип предмета
    /// </summary>
    public string Type { get; set; }
    
    /// <summary>
    /// Статус привязки
    /// </summary>
    public bool IsTied { get; set; }
    
    /// <summary>
    /// Может ли передаваться через общий банк
    /// </summary>
    public bool CanMoveToAccountStash { get; set; }
    
    /// <summary>
    /// Дата сгорания
    /// </summary>
    public DateTime Until { get; set; }
    
    /// <summary>
    /// Картинка
    /// </summary>
    public string ImageUri { get; set; }
}