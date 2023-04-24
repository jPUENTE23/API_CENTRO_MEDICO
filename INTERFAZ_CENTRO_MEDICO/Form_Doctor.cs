using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using INTERFAZ_CENTRO_MEDICO.API_REQUEST;
using INTERFAZ_CENTRO_MEDICO.Modelos;

namespace INTERFAZ_CENTRO_MEDICO
{
    public partial class Form_Doctor : Form
    {
        public Form_Doctor()
        {
            InitializeComponent();
            datosAreas();
        }

        private void btn_RegMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Inicio formInicio = new Form_Inicio();
            formInicio.Show();
        }

        private async void btn_AgregarDoc_Click(object sender, EventArgs e)
        {
            MDoctor Doctor = new MDoctor();
            Doctor.Nombre = txtNombre.Text;
            Doctor.Apeterno = txtApaterno.Text;
            Doctor.Amaterno = txtAmaterno.Text;
            Doctor.Edad = int.Parse(txtEdad.Text);

            int index = cb_sexo.SelectedIndex;
            Doctor.Sexo = cb_sexo.Items[index].ToString();
            Doctor.IsActivo = 1;

            var areaSelect = await areaSeleccionada();
            Doctor.IdArea = areaSelect;

            var agregarDoc = new RequestDoctor();
            HttpResponseMessage response = await agregarDoc.AgregarDoctor(Doctor);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("El doctor se a registrado correctamente");
            }
        }


        public async void datosAreas()
        {
            var request = new RequestArea();
            List<MArea> lstAreas = await request.GetAreasMedicas();

            foreach (MArea areas in lstAreas)
            {
                cb_AreasM.Items.Add(areas.NombreArea);
            }
        }

        public async Task<int> areaSeleccionada()
        {
            var request = new RequestArea();
            List<MArea> lstAreas = await request.GetAreasMedicas();
            int index = cb_AreasM.SelectedIndex;
            string areaSelect = cb_AreasM.Items[index].ToString();

            MArea Area = new MArea();
            int idArea = 0;
            foreach (MArea dtArea in lstAreas)
            {
                if (areaSelect == dtArea.NombreArea.ToString())
                {
                    idArea = dtArea.IdArea;
                }
            }
            return idArea;
        }
    }
}
