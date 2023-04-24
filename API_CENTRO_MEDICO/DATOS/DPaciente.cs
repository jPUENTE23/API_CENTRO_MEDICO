using System.Data.SqlClient;
using System.Data;
using API_CENTRO_MEDICO.MODELOS;
using API_CENTRO_MEDICO.DB_CONEXION;


namespace API_CENTRO_MEDICO.DATOS
{
    public class DPaciente
    {
        private Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public void GuardarPaciente(MPaciente Paciente)
        {
            cmd.Connection = conn.AbrirConexionDB();
            cmd.CommandText = "SP_GuardarPaciente";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", Paciente.Nombre);
            cmd.Parameters.AddWithValue("@Apaterno", Paciente.Apaterno);
            cmd.Parameters.AddWithValue("@Amaterno", Paciente.Amaterno);
            cmd.Parameters.AddWithValue("@Edad", Paciente.Edad);
            cmd.Parameters.AddWithValue("@Sexo", Paciente.Sexo);

            cmd.ExecuteNonQuery();

        }

        public SqlDataReader MostratPacientes()
        {
            cmd.Connection = conn.AbrirConexionDB();
            cmd.CommandText = "SP_LISTAR_PACIENTES";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader datosPacientes = cmd.ExecuteReader();

            return datosPacientes;
        }
    }
}
