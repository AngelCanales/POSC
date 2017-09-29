using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSC.ModelsView
{
public class LoginViewModeL
    {
        //[Required(ErrorMessageResourceType = typeof(MiLonchera.Site.Resources.Accounts.Account), ErrorMessageResourceName = "EmailRequired")]
        [EmailAddress]
       // [Display(Name = "ClassEmail", ResourceType = typeof(MiLonchera.Site.Resources.Accounts.Account))]
        public string Email { get; set; }

       // [Required(ErrorMessageResourceType = typeof(MiLonchera.Site.Resources.Accounts.Account), ErrorMessageResourceName = "PasswordRequired")]
        [DataType(DataType.Password)]
       // [Display(Name = "ClassPassword", ResourceType = typeof(MiLonchera.Site.Resources.Accounts.Account))]
        public string Password { get; set; }

       // [Display(Name = "ClassRememberMe", ResourceType = typeof(MiLonchera.Site.Resources.Accounts.Account))]
        public bool RememberMe { get; set; } 
    

    }
}
