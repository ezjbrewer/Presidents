namespace Presidents.Models.DTOs;

public class BirthPlaceDTO {
    public int Id { get; set; }
    public int PersonId { get; set; }
    public PersonDTO? Person { get; set; }
    public int StateId { get; set; }
    public StateDTO? State { get; set; }
    public string CityName { get; set; }
}