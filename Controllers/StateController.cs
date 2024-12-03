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

        [HttpGet("{id}")]
        public IActionResult GetAState(int id, [FromQuery]bool? president, [FromQuery]bool? vicePresident)
        {
            State? state = _dbContext.States.FirstOrDefault(s => s.Id == id);

            if (state == null)
            {
                return NotFound("State could not be found");
            }

            bool isPresident = president ?? false;
            bool isVicePresident = vicePresident ?? false;

            List<PreviousExperience> stateExperiences = _dbContext.PreviousExperiences.Where(pE => pE.StateId == id).ToList();
            List<BirthPlace> stateBirths = _dbContext.BirthPlaces.Where(bP => bP.StateId == id).ToList();

            List<Person> people = new();

            foreach(var sE in stateExperiences)
            {
                Person? person = _dbContext.People.FirstOrDefault(p => p.Id == sE.PersonId);
                people.Add(person);
            }
            foreach(var sE in stateBirths)
            {
                Person? person = _dbContext.People.FirstOrDefault(p => p.Id == sE.PersonId);
                people.Add(person);
            }

            people = people.GroupBy(p => p.Id).Select(g => g.First()).ToList();

            List<PersonDTO> presidents = new();
            List<PersonDTO> vicePresidents = new();

            foreach(var p in people)
            {
                List<PresidentialAppointment> personAppointments = _dbContext.PresidentialAppointments.Where(pA => pA.PersonId == p.Id).ToList();
                
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

            StateDTO stateDTO = StateDTOCreator.ToStateWithPeopleDTO(state, presidents, vicePresidents);
            
            return Ok(stateDTO);
        }
    }
}