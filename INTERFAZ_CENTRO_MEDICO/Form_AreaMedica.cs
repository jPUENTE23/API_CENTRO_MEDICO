using System;
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
using INTERFAZ_CENTRO_MEDICO.Modelos;
using INTERFAZ_CENTRO_MEDICO.API_REQUEST;

namespace INTERFAZ_CENTRO_MEDICO
{
    public partial class Form_AreaMedica : Form
    {
        public Form_AreaMedica()
        {
            InitializeComponent();
        }

        private async void btn_agrearArea_Click(object sender, EventArgs e)
        {
            
            MArea area = new MArea();
            area.NombreArea = txt_areaMedica.Text;

            var agregarArea = new RequestArea();

            HttpResponseMessage response = await agregarArea.agregarArea(area);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("La area medica se ah agrgado correctaente");
            }
        }

        private void link_Regresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Doctor formDoctor = new Form_Doctor();
            formDoctor.Show();
        }
    }
}
