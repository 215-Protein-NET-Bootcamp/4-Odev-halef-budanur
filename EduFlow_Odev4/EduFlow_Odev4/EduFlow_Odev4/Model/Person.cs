using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduflow_Odev4.Model
{
    public class Person
    {
        public int AccountId { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }       
        public string Description { get; set; }       
        public string Phone { get; set; }       
        public DateTime DateOfBirth { get; set; }
    }
}
