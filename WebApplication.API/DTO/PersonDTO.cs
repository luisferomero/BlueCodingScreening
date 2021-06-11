using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.API.DTO
{
    public class PersonDTO
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public float Weigth { get; set; }
        public float Heigth { get; set; }
        public  StatusDTO Status { get; set; }
    }
}
