using Presidents.Models;
using Presidents.Models.DTOs;
using Presidents.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Presidents.AddControllers // Fixed namespace declaration
{
    [ApiController]
    [Route("api/[controller]")]
    public class PresidentController : ControllerBase
    {
        private readonly PresidentsDbContext _dbContext;

        public PresidentController(PresidentsDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet()]
        public IActionResult GetAllPresidents()
        {
            List<Person> presidents = new();
            List<PresidentialAppointment> presidentialAppointments =  _dbContext.PresidentialAppointments.Where(pa => pa.PublicOfficeId == 10).ToList();

            foreach (PresidentialAppointment presidentialAppointment in presidentialAppointments)
            {
                Person? president = _dbContext.People.FirstOrDefault(p => p.Id == presidentialAppointment.PersonId);
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

        [HttpGet("{id}")]
        public IActionResult GetAPresident(int id)
        {
            // Person Collector
            Person? person = _dbContext.People.FirstOrDefault(p => p.Id == id);

            if (person == null)
            {
                return NotFound($"Person does not exist with id: {id}");
            }

            // Party Collection
            PresidentialAppointment? appointmentWithParty = _dbContext.PresidentialAppointments
                                                            .FirstOrDefault(pA => pA.PersonId == person.Id);
            Party? party = _dbContext.Parties.FirstOrDefault(p => p.Id == appointmentWithParty.PartyId);
            PartyDTO partyDTO = PartyDTOCreator.ToPartyDTO(party);

            //BirthPlace Collection
            BirthPlace? birthPlace = _dbContext.BirthPlaces
                                    .FirstOrDefault(bP => bP.PersonId == person.Id);
            State? birthState = _dbContext.States
                                .FirstOrDefault(s => s.Id == birthPlace.StateId);
            BirthPlaceDTO birthPlaceDTO = BirthPlaceDTOCreator.ToBirthPlaceDTO(birthPlace, birthState);

            // Previous Experience Collection
            List<PreviousExperience> previousExperiences = _dbContext.PreviousExperiences.Where(pE => pE.PersonId == person.Id).ToList();
            List<PreviousExperienceDTO> previousExperienceDTOs = new();

            foreach(var pE in previousExperiences)
            {
                State? state = _dbContext.States.FirstOrDefault(s => s.Id == pE.StateId);
                PublicOffice? publicOffice = _dbContext.PublicOffices.FirstOrDefault(pO => pO.Id == pE.PublicOfficeId);

                PreviousExperienceDTO newPreviousExperienceDTO = PreviousExperienceDTOCreator.ToPreviousExperienceDTO(pE, publicOffice, state);
                previousExperienceDTOs.Add(newPreviousExperienceDTO);
            }

            // PersonDTO Compiler
            PersonDTO newPersonDTO = PersonDTOCreator.ToPersonWithPreviousExperienceDTO(person, previousExperienceDTOs, birthPlaceDTO, partyDTO);

            return Ok(newPersonDTO);
        }
    }
}
