using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Entities
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public float Weigth { get; set; }
        public float Heigth { get; set; }
        public Status Status { get; set; }
    }
}
