namespace Presidents.Models.DTOs;

public class PresidentialAppointmentDTO {
    public int Id { get; set; }
    public int PersonId { get; set; }
    public PersonDTO? Person { get; set; }
    public int PublicOfficeId { get; set; }
    public PublicOfficeDTO? PublicOffice { get; set; }
    public int PartyId { get; set; }
    public PartyDTO? Party { get; set; }
    public DateTime StartDay { get; set; }
    public DateTime EndDay { get; set; }
}