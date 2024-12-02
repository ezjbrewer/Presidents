namespace Presidents.Models.DTOs;

public class BirthPlaceDTO {
    public int Id { get; set; }
    public int PersonId { get; set; }
    public PersonDTO? Person { get; set; }
    public int StateId { get; set; }
    public StateDTO? State { get; set; }
    public string CityName { get; set; }
}

public static class BirthPlaceDTOCreator
{
    public static BirthPlaceDTO ToBirthPlaceDTO(BirthPlace birthPlace, State state)
    {
        if (birthPlace == null)
        {
            throw new ArgumentNullException(nameof(birthPlace));
        }

        StateDTO? stateDTO = state != null
        ? new StateDTO
        {
            Id = state.Id,
            Name = state.Name,
            CapitalName = state.CapitalName,
            Population = state.Population
        }
        : null;

        BirthPlaceDTO birthPlaceDTO = new BirthPlaceDTO
        {
            Id = birthPlace.Id,
            PersonId = birthPlace.PersonId,
            StateId = birthPlace.StateId,
            State = stateDTO,
            CityName = birthPlace.CityName
        };

        return birthPlaceDTO;
    }
}