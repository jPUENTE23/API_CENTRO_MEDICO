using API_CENTRO_MEDICO.MODELOS;
using API_CENTRO_MEDICO.DB_CONEXION;
using System.Data.SqlClient;
using System.Data;

namespace API_CENTRO_MEDICO.DATOS
{
    public class DDoctor
    {
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public void AgregarDoctor (MDoctor Doctor)
        {
            cmd.Connection = conn.AbrirConexionDB();
            cmd.CommandText = "SP_AgragarDoctor";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", Doctor.Nombre);
            cmd.Parameters.AddWithValue("@Apaterno", Doctor.Apeterno);
            cmd.Parameters.AddWithValue("@AMaterno", Doctor.Amaterno);
            cmd.Parameters.AddWithValue("@Edad", Doctor.Edad);
            cmd.Parameters.AddWithValue("@Sexo", Doctor.Sexo);
            cmd.Parameters.AddWithValue("@IsActivo", Doctor.IsActivo);
            cmd.Parameters.AddWithValue("@IdArea", Doctor.IdArea);


            cmd.ExecuteNonQuery();
        }
    }
}
