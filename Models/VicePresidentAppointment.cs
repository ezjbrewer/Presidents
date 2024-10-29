namespace Presidents.Models;

public class VicePresidentAppointment {
    public int Id { get; set; }
    public int PresidentId { get; set; }
    public int VicePresidentId { get; set; }
}