namespace Presidents.Models.DTOs;

public class PartyDTO {
    public int Id { get; set; }
    public string Name { get; set;}
    public string Color { get; set; }
    public List<PersonDTO>? Presidents { get; set; }
    public List<PersonDTO>? VicePresidents{ get; set; }
}