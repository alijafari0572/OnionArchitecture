using Onion.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Onion.Data.Access
{
    public class Role:BaseEntity
    {
        [Display(Name = "عنوان ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمی تواند بیشتر از {1} باشد")]
        [Required(ErrorMessage = "لطفا صفر را وارد کنید")]
        public string Title {get; set;}
        [Display(Name = "نام سیستمی ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکترهای {0} نمی تواند بیشتر از {1} باشد")]
        [Required(ErrorMessage = "لطفا صفر را وارد کنید")]
        public string Name { get; set; }
        public int IsDelete { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
