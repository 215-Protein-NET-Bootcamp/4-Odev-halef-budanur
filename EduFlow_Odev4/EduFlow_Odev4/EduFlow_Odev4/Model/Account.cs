using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduflow_Odev4.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime LastActivity { get; set; }
    }
}
