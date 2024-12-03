namespace Presidents.Models.DTOs;

public class PartyDTO {
    public int Id { get; set; }
    public string Name { get; set;}
    public string Color { get; set; }
    public List<PersonDTO>? Presidents { get; set; }
    public List<PersonDTO>? VicePresidents{ get; set; }
}

public static class PartyDTOCreator
{
    public static PartyDTO ToPartyDTO(Party party)
    {
        if (party == null)
        {
            throw new ArgumentNullException(nameof(party));
        }

        PartyDTO partyDTO = new PartyDTO
        {
            Id = party.Id,
            Name = party.Name,
            Color = party.Color
        };

        return partyDTO;
    }

    public static PartyDTO ToPartyWithPeopleDTO(Party party, List<PersonDTO> presidents, List<PersonDTO> vicePresidents)
    {
        if (party == null)
        {
            throw new ArgumentNullException(nameof(party));
        }

        PartyDTO partyDTO = new PartyDTO
        {
            Id = party.Id,
            Name = party.Name,
            Color = party.Color,
            Presidents = presidents,
            VicePresidents = vicePresidents
        };

        return partyDTO;
    }
}