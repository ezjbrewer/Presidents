namespace Presidents.Models.DTOs;

public class StateDTO {
    public int Id { get; set; }
    public string Name { get; set; }
    public string CapitalName { get; set; }
    public int Population { get; set; }
    public List<PersonDTO>? Presidents { get; set; }
    public List<PersonDTO>? VicePresidents{ get; set; }
}