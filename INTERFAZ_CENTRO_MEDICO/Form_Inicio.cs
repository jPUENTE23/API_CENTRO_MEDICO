using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFAZ_CENTRO_MEDICO
{
    public partial class Form_Inicio : Form
    {
        public Form_Inicio()
        {
            InitializeComponent();
        }

        private void btn_pacientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_RegPaciente formRegPacientes = new Form_RegPaciente();
            formRegPacientes.Show();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Doctor formDoctor = new Form_Doctor();
            formDoctor.Show();
        }
    }
}
