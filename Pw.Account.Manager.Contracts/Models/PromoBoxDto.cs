namespace Pw.Account.Manager.Contracts.Models;

public class PromoBoxDto : EntityDto
{
    /// <summary>
    /// Идентификатор коробки
    /// </summary>
    public int BoxId { get; set; }
    
    /// <summary>
    /// Название коробки
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Тип коробки
    /// </summary>
    public PromoBoxType Type { get; set; }
    
    /// <summary>
    /// Предметы в коробке
    /// </summary>
    public List<string> Items { get; set; }
    
    /// <summary>
    /// Картинка
    /// </summary>
    public string ImageUri { get; set; }
}