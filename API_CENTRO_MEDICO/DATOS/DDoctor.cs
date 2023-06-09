﻿using API_CENTRO_MEDICO.MODELOS;
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

        public SqlDataReader ListarDoctores()
        {
            cmd.Connection = conn.AbrirConexionDB();
            cmd.CommandText = "SP_LISTAR_DOCTORES";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader doctores = cmd.ExecuteReader();

            return doctores;
        }

        public void elimnarDoctor(int IdDoctor)
        {
            cmd.Connection = conn.AbrirConexionDB();
            cmd.CommandText = "SP_ELIMINAR_DOCTOR";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdDoctor", IdDoctor);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
