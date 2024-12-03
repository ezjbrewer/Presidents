namespace Presidents.Models.DTOs;

public class PersonDTO {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }
    public BirthPlaceDTO BirthPlace { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime? DateOfDeath { get; set; }
    public StateDTO? State { get; set; }
    public PartyDTO? Party { get; set; }
    public List<PersonDTO>? Presidents { get; set; }
    public List<PersonDTO>? VicePresidents { get; set; }
    public List<PreviousExperienceDTO>? PreviousExperiences { get; set; }
}

public static class PersonDTOCreator
{
    public static PersonDTO ToPersonWithPreviousExperienceDTO(Person person, List<PreviousExperienceDTO> previousExperiences, BirthPlaceDTO birthPlaceDTO, PartyDTO partyDTO)
    {
        if (person == null)
        {
            throw new ArgumentNullException(nameof(person));
        }

        List<PreviousExperienceDTO>? PreviousExperiences = previousExperiences?.ToList() ?? new List<PreviousExperienceDTO>();

        PersonDTO personDTO = new PersonDTO
        {
            Id = person.Id,
            FirstName = person.FirstName,
            MiddleName = person?.MiddleName,
            LastName = person.LastName,
            DateOfBirth = person.DateOfBirth ?? DateTime.MinValue,
            DateOfDeath = person.DateOfDeath,
            PreviousExperiences = PreviousExperiences.ToList(),
            BirthPlace = birthPlaceDTO,
            Party = partyDTO
        };

        return personDTO;
    }

    public static PersonDTO ToPersonDTO(Person person)
    {
        if (person == null)
        {
            throw new ArgumentNullException(nameof(person));
        }

        PersonDTO personDTO = new PersonDTO
        {
            Id = person.Id,
            FirstName = person.FirstName,
            MiddleName = person?.MiddleName,
            LastName = person.LastName,
            DateOfBirth = (DateTime)person.DateOfBirth,
            DateOfDeath = person.DateOfDeath.HasValue ? person.DateOfDeath : null
        };

        return personDTO;
    }
}