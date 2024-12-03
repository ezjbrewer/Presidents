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

        [HttpGet("{id}")]
        public IActionResult GetAParty(int id, [FromQuery]bool? president, [FromQuery]bool? vicePresident)
        {
            Party? party = _dbContext.Parties.FirstOrDefault(p => p.Id == id);

            if (party == null)
            {
                return NotFound("Party could not be found");
            }

            bool isPresident = president ?? false;
            bool isVicePresident = vicePresident ?? false;

            List<PresidentialAppointment> partyAppointments = _dbContext.PresidentialAppointments
                                                                .Where(pA => pA.PartyId == id)
                                                                .ToList();

            List<Person> people = new();

            foreach(var pA in partyAppointments)
            {
                Person? person = _dbContext.People.FirstOrDefault(p => p.Id == pA.PersonId);
                people.Add(person);
            }

            people = people.GroupBy(p => p.Id).Select(g => g.First()).ToList();

            List<PersonDTO> presidents = new();
            List<PersonDTO> vicePresidents = new();

            foreach(var p in people)
            {
                List<PresidentialAppointment> personAppointments = _dbContext.PresidentialAppointments
                                                                            .Where(pA => pA.PersonId == p.Id)
                                                                            .ToList();

                PersonDTO personDTO = PersonDTOCreator.ToPersonDTO(p);

                int isPresidentAndOrVicePresident = PresidentialAppointmentDTOCreator.isPresidentAndOrVicePresident(personDTO.Id, personAppointments);
            
            
                switch(isPresidentAndOrVicePresident)
                {
                    case 1:
                        if (isVicePresident)
                        {
                            vicePresidents.Add(personDTO);
                        }
                        break;
                    case 2:
                        if (isPresident)
                        {
                            presidents.Add(personDTO);
                        }
                        break;
                    case 3:
                        if (isVicePresident)
                        {
                            vicePresidents.Add(personDTO);
                        }
                        if (isPresident)
                        {
                            presidents.Add(personDTO);
                        }
                        break;
                    default:
                        return NotFound("Error while handling presidential sorting.");
                }

            }     
            
            PartyDTO partyDTO = PartyDTOCreator.ToPartyWithPeopleDTO(party, presidents, vicePresidents);

            return Ok(partyDTO);
        }
    }
}