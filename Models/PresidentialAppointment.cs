namespace Presidents.Models;

public class PresidentialAppointment {
    public int Id { get; set; }
    public int PersonId { get; set; }
    public int PublicOfficeId { get; set; }
    public int PartyId { get; set; }
    public DateTime? StartDay { get; set; }
    public DateTime? EndDay { get; set; }
}