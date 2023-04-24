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
            DoctoresDataGrid();
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

        private void link_NuevaArea_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_AreaMedica formAreaMedica = new Form_AreaMedica();
            formAreaMedica.Show();
        }

        public async void DoctoresDataGrid()
        {
            var funcionDoctores = new RequestDoctor();
            List<MDoctor> lstDoctores = await funcionDoctores.MostrarDoctores();

            int indexDoctor;
            foreach (MDoctor doctor in lstDoctores)
            {
                indexDoctor = dataGrid_Doctores.Rows.Add();
                dataGrid_Doctores.Rows[indexDoctor].Cells[0].Value = doctor.IdDoctor;
                dataGrid_Doctores.Rows[indexDoctor].Cells[1].Value = doctor.Nombre;
                dataGrid_Doctores.Rows[indexDoctor].Cells[2].Value = doctor.Apeterno;
                dataGrid_Doctores.Rows[indexDoctor].Cells[3].Value = doctor.Amaterno;
                dataGrid_Doctores.Rows[indexDoctor].Cells[4].Value = doctor.Edad;
                dataGrid_Doctores.Rows[indexDoctor].Cells[5].Value = doctor.Sexo;
                dataGrid_Doctores.Rows[indexDoctor].Cells[6].Value = doctor.IsActivo;
                dataGrid_Doctores.Rows[indexDoctor].Cells[7].Value = doctor.IdArea;
            }
        }
    }
}
