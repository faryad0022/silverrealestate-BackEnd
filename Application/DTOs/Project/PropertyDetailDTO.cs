using Application.DTOs.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Project
{
    public class PropertyDetailDTO : BaseEntityDTO
    {
        #region Properties
        [Display(Name = "تاریخ شروع پروژه")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public DateTime StartDate { get; set; }
        [Display(Name = "تاریخ تحویل پروژه")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public DateTime EndTime { get; set; }
        [Display(Name = "نحوه پرداخت")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public string PaymentPlan { get; set; }
        [Display(Name = "زمان تحویل کلید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public DateTime KeyHandOver { get; set; }
        [Display(Name = "مبلغ مالیات")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public int VAT { get; set; }
        [Display(Name = "مبلغ اتصالات")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public int ConnectionFee { get; set; }
        [Display(Name = "هزینه تمبر")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public int Stamp { get; set; }
        [Display(Name = "آدرس")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public string Address { get; set; }
        #endregion

    }
}
