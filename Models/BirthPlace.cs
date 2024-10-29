namespace Presidents.Models;

public class BirthPlace {
    public int Id { get; set; }
    public int PersonId { get; set; }
    public int StateId { get; set; }
    public string CityName { get; set; }
}