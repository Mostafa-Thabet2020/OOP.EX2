using OOP.EX2.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EX2.Models
{
    public class UserRole:BaseEntityWithName
    {
        public List<User> users { get; set; }
    }
}
