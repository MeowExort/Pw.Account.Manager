using System.ComponentModel.DataAnnotations;

namespace Pw.Account.Manager.Contracts;

public enum CharacterClass
{
    [Display(Name = "Воин")]
    Hw,
    [Display(Name = "Маг")]
    Hm,
    [Display(Name = "Стрелок")]
    Hg,
    [Display(Name = "Оборотень")]
    Wb,
    [Display(Name = "Друид")]
    Wf,
    [Display(Name = "Странник")]
    Mk,
    [Display(Name = "Лучник")]
    Ea,
    [Display(Name = "Жрец")]
    Ep,
    [Display(Name = "Паладин")]
    Pl,
    [Display(Name = "Шаман")]
    Tp,
    [Display(Name = "Убийца")]
    Ta,
    [Display(Name = "Цинь")]
    Tc,
    [Display(Name = "Страж")]
    Es,
    [Display(Name = "Мистик")]
    Em,
    [Display(Name = "Жнец")]
    Sb,
    [Display(Name = "Призрак")]
    Db
}