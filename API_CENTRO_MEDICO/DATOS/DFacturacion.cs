using System.Data.SqlClient;
using System.Data;
using API_CENTRO_MEDICO.DB_CONEXION;
using API_CENTRO_MEDICO.MODELOS;


namespace API_CENTRO_MEDICO.DATOS
{
    public class DFacturacion
    {
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public void GenrarFactura (MFacturacion Factura)
        {
            cmd.Connection = conn.AbrirConexionDB();
            cmd.CommandText = "SP_GenerarFact";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@IdCita", Factura.IdCita);
            cmd.Parameters.AddWithValue("@NomPac", Factura.NombreRec);
            string concepto = Convert.ToString(Factura.Concepto);
            cmd.Parameters.AddWithValue("@Concepto", concepto);
            cmd.Parameters.AddWithValue("@ValorUnitario", Factura.Valor_Unitario);
            cmd.Parameters.AddWithValue("@Descuento", Factura.Descuento);
            cmd.Parameters.AddWithValue("@TotakConsulta", Factura.Total_Consulta);

            cmd.ExecuteNonQuery();
        }
    }
}
