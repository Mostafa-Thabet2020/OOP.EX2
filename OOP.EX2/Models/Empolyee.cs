using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EX2.Models
{
    public class Empolyee: People
    {
        public double Salary { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
