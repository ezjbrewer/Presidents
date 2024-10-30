using Presidents.Models;
using Presidents.Models.DTOs;
using Presidents.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Presidents.AddControllers // Fixed namespace declaration
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublicOfficeController : ControllerBase
    {
        private readonly PresidentsDbContext _dbContext;

        public PublicOfficeController(PresidentsDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet()]
        public IActionResult GetAllPublicOffices()
        {
            List<PublicOffice> publicOffices = _dbContext.PublicOffices.ToList();

            return Ok(publicOffices.Select(pO => new PublicOfficeDTO
            {
                Id = pO.Id,
                Role = pO.Role
            }).ToList());
        }
    }
}