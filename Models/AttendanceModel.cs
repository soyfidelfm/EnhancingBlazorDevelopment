namespace EventEase.Models
{
    public class AttendanceModel
    {
        public int EventId { get; set; }  // ID del evento
        public string EventName { get; set; } = string.Empty;  // Nombre del evento
        public string UserName { get; set; } = string.Empty;  // Nombre del usuario
        public DateTime Timestamp { get; set; } = DateTime.Now;  // Fecha de asistencia
    }
}
