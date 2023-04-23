using System;

namespace INTERFAZ_CENTRO_MEDICO.Modelos
{
    public class MCita
    {
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public int IdDoctor { get; set; }
        public DateTime Fecha_Cita { get; set; }
    }
}
