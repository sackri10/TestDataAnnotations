using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webapi.Models
{
    public class User
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
