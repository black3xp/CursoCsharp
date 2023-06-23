using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CsharpPOO.Models
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public short Age { get; set; }
        public bool IsValid()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) || Age < 0 || Age > 250)
            {
                return false;
            }
            return true;
        }
    }
}
