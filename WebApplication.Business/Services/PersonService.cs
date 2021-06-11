using System;
using System.Collections.Generic;
using System.Text;
using WebApplication.Entities;

namespace WebApplication.Business.Services
{
    public class PersonService : IPersonService
    {
        public PersonService()
        {

        }

        public Status CalculateStatus(Person person)
        {
            var calculus = person.Weigth / person.Heigth;
            int maxValue = 10;

            var result = new Status()
            {
                StatusId = 1,
                Description = calculus > maxValue ? "BAD" : "GOOD"
            };

            return result;
        }
    }
}
