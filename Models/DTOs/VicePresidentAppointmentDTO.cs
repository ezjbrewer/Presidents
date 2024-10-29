namespace Presidents.Models.DTOs;

public class VicePresidentAppointmentDTO {
    public int PresidentId { get; set; }
    public PersonDTO President { get; set; }
    public int VicePresidentId { get; set; }
    public PersonDTO VicePresident { get; set; }
}