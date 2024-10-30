using Presidents.Models;
using Presidents.Models.DTOs;
using Presidents.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Presidents.AddControllers // Fixed namespace declaration
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartyController : ControllerBase
    {
        private readonly PresidentsDbContext _dbContext;

        public PartyController(PresidentsDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet()]
        public IActionResult GetAllParties()
        {
            List<Party> parties = _dbContext.Parties.ToList();

            return Ok(parties.Select(p => new PartyDTO
            {
                Id = p.Id,
                Name = p.Name,
                Color = p.Color
            }).ToList());
        }
    }
}