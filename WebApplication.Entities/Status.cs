using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Entities
{
    public class Status
    {
        public int StatusId { get; set; }
        public string Description { get; set; }
        public ICollection<Person> People { get; set; }
    }
}
