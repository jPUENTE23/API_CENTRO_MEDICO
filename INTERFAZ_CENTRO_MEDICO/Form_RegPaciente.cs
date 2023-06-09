﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INTERFAZ_CENTRO_MEDICO.API_REQUEST;
using INTERFAZ_CENTRO_MEDICO.Modelos;



namespace INTERFAZ_CENTRO_MEDICO
{
    public partial class Form_RegPaciente : Form
    {
        public Form_RegPaciente()
        {
            InitializeComponent();
            PacientesDataGrid();
        }

        private void btn_RegMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Inicio formInicio = new Form_Inicio();
            formInicio.Show();
        }

        private async void btn_AgregarPac_Click(object sender, EventArgs e)
        {

            /*Almacenamos los datos ingresados en un nuevo objeto*/
            MPaciente Paciente = new MPaciente();
            Paciente.Nombre = txtNombre.Text;
            Paciente.Apaterno = txtApaterno.Text;
            Paciente.Amaterno = txtAmaterno.Text;
            Paciente.Edad = int.Parse(txtEdad.Text);

            int index = cb_sexo.SelectedIndex;
            Paciente.Sexo = cb_sexo.Items[index].ToString();

            /*Iniciamos una instancia para mandasr los datos a una peticion */
            var agregarPaciente = new RequestPaciente();

            /*Mandamos la peticion al servidor*/
            HttpResponseMessage resp = await agregarPaciente.AgregarPaciente(Paciente);


            /*Si la peticion nos devuelve un statusCode 200, significa que los datos han sido registrados correctamente */
            if (resp.IsSuccessStatusCode)
            {
                MessageBox.Show("El paciente se ah registrado correctamente");
            }

            recargarPantalla();

        }


        public async void PacientesDataGrid()
        {
            var funcionPaciente = new RequestPaciente();
            List<MPaciente> lstPacientes = await funcionPaciente.MostrarPacientes();

            int indexPaciente;
            foreach (MPaciente paciente in lstPacientes)
            {
                indexPaciente = dataGrid_Paciente.Rows.Add();
                dataGrid_Paciente.Rows[indexPaciente].Cells[0].Value = paciente.idPaciente;
                dataGrid_Paciente.Rows[indexPaciente].Cells[1].Value = paciente.Nombre;
                dataGrid_Paciente.Rows[indexPaciente].Cells[2].Value = paciente.Apaterno;
                dataGrid_Paciente.Rows[indexPaciente].Cells[3].Value = paciente.Amaterno;
                dataGrid_Paciente.Rows[indexPaciente].Cells[4].Value = paciente.Edad;
                dataGrid_Paciente.Rows[indexPaciente].Cells[5].Value = paciente.Sexo;

            }
        }

        public void recargarPantalla()
        {
            this.Hide();
            Form_RegPaciente formPaciente = new Form_RegPaciente();
            formPaciente.Show();
        }
    }
}
