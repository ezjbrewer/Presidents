namespace Presidents.Models.DTOs;

public class YearDTO {
    public int CurrentPresidentId { get; set; }
    public PersonDTO? CurrentPresident { get; set; }
    public int? CurrentVicePresidentId { get; set; }
    public PersonDTO? CurrentVicePresident { get; set; }
    public List<PersonDTO>? AlivePresidents { get; set; }
    public List<PersonDTO>? AliveVicePresidents { get; set; }
}