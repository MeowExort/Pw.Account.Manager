using System.ComponentModel.DataAnnotations;

namespace Pw.Account.Manager.Contracts;

public enum PromoBoxType
{
    [Display(Name = "Один из")]
    OneOf,
    [Display(Name = "Все")]
    All
}