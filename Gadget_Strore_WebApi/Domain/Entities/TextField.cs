using System;
using System.ComponentModel.DataAnnotations;
namespace Gadget_Strore_WebApi.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Назва сторінки (заголовок)")]
        public override string Title { get; set; } = "Інформаційна сторінка";

        [Display(Name = "Зміст сторінки")]
        public override string Text { get; set; } = "Зміст заповнюється адміном";
    }
}
