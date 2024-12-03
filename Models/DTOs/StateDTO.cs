namespace Presidents.Models.DTOs;

public class StateDTO {
    public int Id { get; set; }
    public string Name { get; set; }
    public string CapitalName { get; set; }
    public int Population { get; set; }
    public List<PersonDTO>? Presidents { get; set; }
    public List<PersonDTO>? VicePresidents{ get; set; }
}

public static class StateDTOCreator
{
    public static StateDTO ToStateWithPeopleDTO(State state, List<PersonDTO> presidents, List<PersonDTO> vicePresidents)
    {
        if (state == null)
        {
            throw new ArgumentNullException(nameof(state));
        }

        StateDTO stateDTO = new StateDTO
        {
            Id = state.Id,
            Name = state.Name,
            CapitalName = state.Name,
            Population = state.Population,
            Presidents = presidents,
            VicePresidents = vicePresidents
        };

        return stateDTO;
    }
}