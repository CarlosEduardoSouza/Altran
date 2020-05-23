using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Business.Models
{
    public class Usuario : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Claims { get; set; }
    }
}
