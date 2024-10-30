namespace Presidents.Models.DTOs;

public class PublicOfficeDTO {
    public int Id { get; set; }
    public string Role {get; set; }
    public List<PersonDTO>? Presidents { get; set; }
    public List<PersonDTO>? VicePresidents{ get; set; }
}