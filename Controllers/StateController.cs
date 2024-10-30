using Presidents.Models;
using Presidents.Models.DTOs;
using Presidents.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Presidents.AddControllers // Fixed namespace declaration
{
    [ApiController]
    [Route("api/[controller]")]
    public class StateController : ControllerBase
    {
        private readonly PresidentsDbContext _dbContext;

        public StateController(PresidentsDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet()]
        public IActionResult GetAllStates()
        {
            List<State> states = _dbContext.States.ToList();

            return Ok(states.Select(s => new StateDTO
            {
                Id = s.Id,
                Name = s.Name,
                CapitalName = s.CapitalName,
                Population = s.Population
            }).ToList());
        }
    }
}