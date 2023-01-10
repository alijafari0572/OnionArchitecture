using Onion.Data.Access;
using Onion.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Data.Account
{
    public class User:BaseEntity
    {
        [Display(Name ="نام کاربری ")]
        [MaxLength(100,ErrorMessage ="تعداد کاراکترهای {0} نمی تواند بیشتر از {1} باشد")]
        [Required(ErrorMessage ="لطفا صفر را وارد کنید")]
        public string UseName { get; set; }
        [Display(Name = "ایمیل ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمی تواند بیشتر از {1} باشد")]
        [Required(ErrorMessage = "لطفا صفر را وارد کنید")]
        [EmailAddress(ErrorMessage ="ایمیل وارد شده معتبر نیست")]
        public string  Email { get; set; }
        [Display(Name = "رمز عبور ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمی تواند بیشتر از {1} باشد")]
        [Required(ErrorMessage = "لطفا صفر را وارد کنید")]
        public string PassWord { get; set; }
        public bool IsDelete { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
