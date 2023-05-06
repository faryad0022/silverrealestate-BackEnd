using Application.DTOs.Common;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Project
{
    public class PropertyDTO : BaseEntityDTO
    {
        #region Properties
        [Display(Name = "عکس اولیه")]
        public string Image { get; set; }
        [Display(Name = "فروخته شده؟")]
        public bool IsSold { get; set; } = false;
        [Display(Name = "اجاره شده؟")]
        public bool IsRent { get; set; } = false;
        [Display(Name = "تلفن صاحب خانه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمائید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public string OwnerPhoneNumber { get; set; }
        [Display(Name = "تلفن ایجنت خانه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمائید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public string AgentPhoneNmber { get; set; }
        #endregion
    }
}
