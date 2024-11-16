using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        public int UserId { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public string UserRole { get; set; }
    }
}
