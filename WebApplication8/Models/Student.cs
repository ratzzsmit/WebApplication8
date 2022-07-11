using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public string Course { get; set; }
    }
}
