using System.Data.SqlClient;


namespace API_CENTRO_MEDICO.DB_CONEXION
{
    public class Conexion
    {
        private string conect = string.Empty;
        public Conexion()
        {
            var constructor = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            conect = constructor.GetSection("ConnectionStrings:conexion").Value;
        }

        public string cadenaSQL()
        {
            return conect;
        }

        public SqlConnection AbrirConexionDB()
        {
            string cadena = cadenaSQL();
            SqlConnection conexionDB = new SqlConnection(cadena);
            SqlConnection abrirConn = conexionDB;
            abrirConn.Open();


            return abrirConn;
        }
    }
}
