using System;
using System.Collections.Generic;
using System.Text;
using WebApplication.Entities;

namespace WebApplication.Business.Services
{
    public interface IPersonService
    {
        public Status CalculateStatus(Person person);
    }
}
