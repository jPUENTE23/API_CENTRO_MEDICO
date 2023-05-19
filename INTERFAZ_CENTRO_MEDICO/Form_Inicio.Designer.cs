namespace INTERFAZ_CENTRO_MEDICO
{
    partial class Form_Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_regCita = new System.Windows.Forms.Button();
            this.btn_pacientes = new System.Windows.Forms.Button();
            this.btnDoctores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regCita
            // 
            this.btn_regCita.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_regCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regCita.FlatAppearance.BorderSize = 0;
            this.btn_regCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regCita.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regCita.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_regCita.Image = global::INTERFAZ_CENTRO_MEDICO.Properties.Resources.registrarcita4;
            this.btn_regCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_regCita.Location = new System.Drawing.Point(187, 141);
            this.btn_regCita.Name = "btn_regCita";
            this.btn_regCita.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_regCita.Size = new System.Drawing.Size(258, 50);
            this.btn_regCita.TabIndex = 0;
            this.btn_regCita.Text = "Registrar Cita";
            this.btn_regCita.UseVisualStyleBackColor = false;
            this.btn_regCita.Click += new System.EventHandler(this.btn_regCita_Click);
            // 
            // btn_pacientes
            // 
            this.btn_pacientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_pacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pacientes.FlatAppearance.BorderSize = 0;
            this.btn_pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pacientes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pacientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_pacientes.Image = global::INTERFAZ_CENTRO_MEDICO.Properties.Resources.pacientes;
            this.btn_pacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pacientes.Location = new System.Drawing.Point(187, 230);
            this.btn_pacientes.Name = "btn_pacientes";
            this.btn_pacientes.Size = new System.Drawing.Size(258, 50);
            this.btn_pacientes.TabIndex = 1;
            this.btn_pacientes.Text = "Pacientes";
            this.btn_pacientes.UseVisualStyleBackColor = false;
            this.btn_pacientes.Click += new System.EventHandler(this.btn_pacientes_Click);
            // 
            // btnDoctores
            // 
            this.btnDoctores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDoctores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctores.FlatAppearance.BorderSize = 0;
            this.btnDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDoctores.Image = global::INTERFAZ_CENTRO_MEDICO.Properties.Resources.doctores;
            this.btnDoctores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctores.Location = new System.Drawing.Point(187, 308);
            this.btnDoctores.Name = "btnDoctores";
            this.btnDoctores.Size = new System.Drawing.Size(258, 50);
            this.btnDoctores.TabIndex = 2;
            this.btnDoctores.Text = "Doctores";
            this.btnDoctores.UseVisualStyleBackColor = false;
            this.btnDoctores.Click += new System.EventHandler(this.btnDoctores_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = global::INTERFAZ_CENTRO_MEDICO.Properties.Resources.titulo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menú principal";
            // 
            // Form_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(641, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_regCita);
            this.Controls.Add(this.btn_pacientes);
            this.Controls.Add(this.btnDoctores);
            this.Name = "Form_Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regCita;
        private System.Windows.Forms.Button btn_pacientes;
        private System.Windows.Forms.Button btnDoctores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

