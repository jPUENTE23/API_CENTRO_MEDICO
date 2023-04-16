namespace API_CENTRO_MEDICO.MODELOS
{
    public class MCita
    {
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public int IdDoctor { get; set; }
        public DateTime Fecha_Cita { get; set; }
        public DateTime Hora_Cita { get; set; }
    }
}
