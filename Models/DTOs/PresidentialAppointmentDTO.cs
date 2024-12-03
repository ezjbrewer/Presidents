namespace Presidents.Models.DTOs;
using Presidents.Data;

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

public static class PresidentialAppointmentDTOCreator
{
    public static int isPresidentAndOrVicePresident(int id, List<PresidentialAppointment> personAppointments)
    {
        bool isPresident = personAppointments.Any(pA => pA.PublicOfficeId == 10);
        bool isVicePresident = personAppointments.Any(pA => pA.PublicOfficeId == 11);

        if (isPresident && isVicePresident)
        {
            return 3;
        }
        else if (isPresident)
        {
            return 2;
        }
        else if (isVicePresident)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}