using API_CENTRO_MEDICO.MODELOS;
using API_CENTRO_MEDICO.DB_CONEXION;
using System.Data.SqlClient;
using System.Data;


namespace API_CENTRO_MEDICO.DATOS
{
    public class DCitas
    {
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public void RegistrarCita(MCita Cita)
        {
            cmd.Connection = conn.AbrirConexionDB();
            cmd.CommandText = "SP_RegistrarCita";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdPaciente", Cita.IdPaciente);
            cmd.Parameters.AddWithValue("@IdDoctor", Cita.IdDoctor);
            cmd.Parameters.AddWithValue("@FechaCita", Cita.Fecha_Cita);

            cmd.Parameters.Clear();
            cmd.ExecuteNonQuery();
        }


    }
}
