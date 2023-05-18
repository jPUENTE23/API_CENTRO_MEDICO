namespace INTERFAZ_CENTRO_MEDICO
{
    partial class CITA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Reg = new System.Windows.Forms.Button();
            this.cb_Pacientes = new System.Windows.Forms.ComboBox();
            this.cb_Doctor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_Cita = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.regCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Reg
            // 
            this.btn_Reg.Location = new System.Drawing.Point(47, 48);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(75, 23);
            this.btn_Reg.TabIndex = 10;
            this.btn_Reg.Text = "Reegresar";
            this.btn_Reg.UseVisualStyleBackColor = true;
            this.btn_Reg.Click += new System.EventHandler(this.btn_Reg_Click);
            // 
            // cb_Pacientes
            // 
            this.cb_Pacientes.FormattingEnabled = true;
            this.cb_Pacientes.Location = new System.Drawing.Point(47, 163);
            this.cb_Pacientes.Name = "cb_Pacientes";
            this.cb_Pacientes.Size = new System.Drawing.Size(238, 21);
            this.cb_Pacientes.TabIndex = 11;
            this.cb_Pacientes.SelectedIndexChanged += new System.EventHandler(this.cb_Pacientes_SelectedIndexChanged);
            // 
            // cb_Doctor
            // 
            this.cb_Doctor.FormattingEnabled = true;
            this.cb_Doctor.Location = new System.Drawing.Point(47, 251);
            this.cb_Doctor.Name = "cb_Doctor";
            this.cb_Doctor.Size = new System.Drawing.Size(238, 21);
            this.cb_Doctor.TabIndex = 12;
            this.cb_Doctor.SelectedIndexChanged += new System.EventHandler(this.cb_Doctor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Doctor";
            // 
            // dateTimePicker_Cita
            // 
            this.dateTimePicker_Cita.Location = new System.Drawing.Point(47, 331);
            this.dateTimePicker_Cita.Name = "dateTimePicker_Cita";
            this.dateTimePicker_Cita.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker_Cita.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(47, 420);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(238, 20);
            this.txt_Telefono.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Numero telefonico";
            // 
            // regCita
            // 
            this.regCita.Location = new System.Drawing.Point(47, 483);
            this.regCita.Name = "regCita";
            this.regCita.Size = new System.Drawing.Size(238, 23);
            this.regCita.TabIndex = 19;
            this.regCita.Text = "Registrar Cita";
            this.regCita.UseVisualStyleBackColor = true;
            this.regCita.Click += new System.EventHandler(this.regCita_Click);
            // 
            // CITA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 581);
            this.Controls.Add(this.regCita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_Cita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Doctor);
            this.Controls.Add(this.cb_Pacientes);
            this.Controls.Add(this.btn_Reg);
            this.Name = "CITA";
            this.Text = "CITA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Reg;
        private System.Windows.Forms.ComboBox cb_Pacientes;
        private System.Windows.Forms.ComboBox cb_Doctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Cita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button regCita;
    }
}