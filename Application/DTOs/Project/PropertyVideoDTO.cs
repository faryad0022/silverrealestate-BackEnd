using Application.DTOs.Common;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Project
{
    public class PropertyVideoDTO : BaseEntityDTO
    {
        #region Properties
        [Display(Name = "عنوان ویدیو")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمائید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public string VideoName { get; set; }
        [Display(Name = "محل ذخیره")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمائید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public string VideoAddress { get; set; }
        #endregion
 
    }
}
