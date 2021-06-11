using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.API.DTO;
using WebApplication.Business.Services;
using WebApplication.Entities;

namespace WebApplication.API.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        public IPersonService _personService { get; set; }
        public IMapper _mapper { get; set; }
        public PeopleController(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<StatusDTO> GetPersonCalculus([FromQuery]int personId)
        {
            if (personId == 0)
                return BadRequest();

            var person = new PersonDTO()
            {
                PersonId = 1,
                Name = "Luis",
                BirthDate = new DateTime(1996, 7, 3),
                Weigth = 201.5f,
                Heigth = 6.2f
            };

            var personEntity = _mapper.Map<Person>(person);

            var status = _personService.CalculateStatus(personEntity);

            var result = _mapper.Map<StatusDTO>(status);

            return Ok(result);
        }
    }
}
