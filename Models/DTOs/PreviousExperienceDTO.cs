namespace Presidents.Models.DTOs;

public class PreviousExperienceDTO {
    public int Id { get; set; }
    public int PersonId { get; set; }
    public PersonDTO? Person { get; set; }
    public int PublicOfficeId { get; set; }
    public PublicOfficeDTO? PublicOffice { get; set; }
    public int StateId { get; set; }
    public StateDTO? State { get; set; }
    public DateTime StartDay { get; set; }
    public DateTime EndDay { get; set; }
}

public static class PreviousExperienceDTOCreator
{
    public static PreviousExperienceDTO ToPreviousExperienceDTO(PreviousExperience previousExperience, PublicOffice publicOffice, State state)
    {
        if (previousExperience == null)
        {
            throw new ArgumentNullException(nameof(previousExperience));
        }

        PublicOfficeDTO? publicOfficeDTO = publicOffice != null
        ? new PublicOfficeDTO
        {
            Id = publicOffice.Id,
            Role = publicOffice.Role
        }
        : null;

        StateDTO? stateDTO = state != null
        ? new StateDTO
        {
            Id = state.Id,
            Name = state.Name,
            CapitalName = state.CapitalName,
            Population = state.Population
        }
        : null;

        PreviousExperienceDTO previousExperienceDTO = new PreviousExperienceDTO
        {
            Id = previousExperience.Id,
            PersonId = previousExperience.PersonId,
            PublicOfficeId = previousExperience.PublicOfficeId,
            PublicOffice = publicOfficeDTO,
            StateId = previousExperience.StateId,
            State = stateDTO,
            StartDay = (DateTime)previousExperience.StartDay,
            EndDay = (DateTime)previousExperience.EndDay
        };

        return previousExperienceDTO;
    }
}