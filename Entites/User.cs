using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace Entites
{
    public class User
    {
        public int UserId { get; set; }
        //
        
        [EmailAddress]
        public string UserName { get; set; }

        [StringLength(20, ErrorMessage = "password can be betwenn 2 till 20 letters", MinimumLength = 2)]
        public string Password { get; set; }

        [StringLength(20, ErrorMessage = "password can be betwenn 2 till 20 letters", MinimumLength = 2),]
        public string FirstName { get; set; }

        [StringLength(20, ErrorMessage = "password can be betwenn 2 till 20 letters", MinimumLength = 2)]
        public string LastName { get; set; }
    }
}
