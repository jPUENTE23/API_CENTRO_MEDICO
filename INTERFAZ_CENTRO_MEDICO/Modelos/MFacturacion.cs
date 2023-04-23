using System;

namespace INTERFAZ_CENTRO_MEDICO.Modelos
{
    public class MFacturacion
    {
        public int Folio { get; set; }
        public int IdCita { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public string NombreRec { get; set; }
        public dynamic Concepto { get; set; }
        public decimal Valor_Unitario { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total_Consulta { get; set; }
    }
}
