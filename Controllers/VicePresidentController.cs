using Presidents.Models;
using Presidents.Models.DTOs;
using Presidents.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Presidents.AddControllers // Fixed namespace declaration
{
    [ApiController]
    [Route("api/[controller]")]
    public class VicePresidentController : ControllerBase
    {
        private readonly PresidentsDbContext _dbContext;

        public VicePresidentController(PresidentsDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet()]
        public IActionResult GetAllVicePresidents()
        {
            List<Person> presidents = [];

            foreach (PresidentialAppointment presidentialAppointment in _dbContext.PresidentialAppointments.Where(pa => pa.PublicOfficeId == 11).ToList())
            {
                Person president = _dbContext.People.FirstOrDefault(p => p.Id == presidentialAppointment.PersonId);
                presidents.Add(president);
            }

            return Ok(presidents.Select(p => new PersonDTO
            {
                Id = p.Id,
                FirstName = p.FirstName,
                MiddleName = p?.MiddleName,
                LastName = p.LastName,
                DateOfBirth = (DateTime)p.DateOfBirth,
                DateOfDeath = p.DateOfDeath.HasValue ? p.DateOfDeath : null,
            }).ToList());
        }
    }
}