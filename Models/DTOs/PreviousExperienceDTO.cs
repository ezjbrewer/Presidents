namespace Presidents.Models.DTOs;

public class PreviousExperienceDTO {
    public int Id { get; set; }
    public int PersonId { get; set; }
    public PersonDTO? Person { get; set; }
    public int PublicOfficeId { get; set; }
    public PublicOfficeDTO? PublicOffice { get; set; }
    public int StateId { get; set; }
    public StateDTO? StateDTO { get; set; }
    public DateTime StartDay { get; set; }
    public DateTime EndDay { get; set; }
}