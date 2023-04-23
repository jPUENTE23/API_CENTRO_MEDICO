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

        private void btn_AgregarDoc_Click(object sender, EventArgs e)
        {
            
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
    }
}
