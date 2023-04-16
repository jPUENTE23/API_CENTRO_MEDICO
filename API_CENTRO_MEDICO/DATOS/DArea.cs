using System.Data.SqlClient;
using System.Data;
using API_CENTRO_MEDICO.MODELOS;
using API_CENTRO_MEDICO.DB_CONEXION;



namespace API_CENTRO_MEDICO.DATOS
{
    public class DArea
    {
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public void AgragrArea(MArea Area)
        {
            cmd.Connection = conn.AbrirConexionDB();
            cmd.CommandText = "SP_AgregarArea";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Area", Area.NombreArea);

            cmd.ExecuteNonQuery();
        }
    }
}
