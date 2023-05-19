using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using INTERFAZ_CENTRO_MEDICO.API_REQUEST;
using INTERFAZ_CENTRO_MEDICO.Modelos;

namespace INTERFAZ_CENTRO_MEDICO
{
    public partial class CITA : Form
    {
        public int IdPaciente;
        public int IdDoctor;
        public CITA()
        {
            InitializeComponent();
            cbpacienntes();
            cbdoctores();
        }

        public async void cbpacienntes()
        {
            RequestPaciente funcionPacientes = new RequestPaciente();
            List<MPaciente> lstPcientes = await funcionPacientes.MostrarPacientes();

            foreach(MPaciente pac in lstPcientes)
            {
                //string nomPacientes = pac.Nombre + "" + pac.Apaterno + "" + pac.Amaterno;
                cb_Pacientes.Items.Add(pac.Nombre);
            }
        }

        public async void cbdoctores()
        {
            RequestDoctor funcionDoctor = new RequestDoctor();
            List<MDoctor> lsDoctores = await funcionDoctor.MostrarDoctores();

            foreach (MDoctor doc in lsDoctores)
            {
                cb_Doctor.Items.Add(doc.Nombre);
            }
        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Inicio formInicio = new Form_Inicio();
            formInicio.Show();
        }

        private async void cb_Pacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequestPaciente funcionPacientes = new RequestPaciente();
            List<MPaciente> lstPcientes = await funcionPacientes.MostrarPacientes();

            int index = cb_Pacientes.SelectedIndex; ;
            string nomPaciente = cb_Pacientes.Items[index].ToString();

            foreach (MPaciente pac in lstPcientes)
            {
                if(nomPaciente == pac.Nombre)
                {
                    IdPaciente = pac.idPaciente;
                }
            }
        }

        private async void cb_Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequestDoctor funcionDoctor = new RequestDoctor();
            List<MDoctor> lsDoctores = await funcionDoctor.MostrarDoctores();

            int index = cb_Doctor.SelectedIndex; ;
            string nomDoctor = cb_Doctor.Items[index].ToString();

            foreach (MDoctor doc in lsDoctores)
            {
                if (nomDoctor == doc.Nombre)
                {
                    IdDoctor = doc.IdDoctor;
                }
            }
        }

        private async void regCita_Click(object sender, EventArgs e)
        {
            Twillio funcionTwilio = new Twillio();
            MCita Cita = new MCita();

            Cita.Fecha_Cita = dateTimePicker_Cita.Value;
            Cita.IdPaciente = IdPaciente;
            Cita.IdDoctor = IdDoctor;

            RequestCita funcionCita = new RequestCita();
            HttpResponseMessage resp = await funcionCita.AgregarCita(Cita);

            if (resp.IsSuccessStatusCode)
            {
                MessageBox.Show("La cita se ah registrado correctamente");
                dynamic telefono = txt_Telefono.Text;
                funcionTwilio.enviarMensaje(telefono);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
