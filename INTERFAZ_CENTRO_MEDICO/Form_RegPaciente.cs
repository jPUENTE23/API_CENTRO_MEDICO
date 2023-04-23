using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void btn_RegMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Inicio formInicio = new Form_Inicio();
            formInicio.Show();
        }

        private void btn_AgregarPac_Click(object sender, EventArgs e)
        {
            MPaciente Paciente = new MPaciente();
            Paciente.Nombre = txtNombre.Text;
            Paciente.Apaterno = txtApaterno.Text;
            Paciente.Amaterno = txtAmaterno.Text;
            Paciente.Edad = int.Parse(txtEdad.Text);
            Paciente.Sexo = txtSexo.Text;

            var agregarPaciente = new RequestPaciente();
            agregarPaciente.AgregarPaciente(Paciente);

        }
    }
}
