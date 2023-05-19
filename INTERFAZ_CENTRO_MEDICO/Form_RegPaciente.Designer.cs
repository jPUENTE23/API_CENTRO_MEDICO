namespace INTERFAZ_CENTRO_MEDICO
{
    partial class Form_RegPaciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_AgregarPac = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid_Paciente = new System.Windows.Forms.DataGridView();
            this.id_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_RegMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Paciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Paciente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btn_RegMenu);
            this.panel2.Controls.Add(this.cb_sexo);
            this.panel2.Controls.Add(this.txtEdad);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_AgregarPac);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAmaterno);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtApaterno);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 627);
            this.panel2.TabIndex = 1;
            // 
            // cb_sexo
            // 
            this.cb_sexo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cb_sexo.Location = new System.Drawing.Point(36, 491);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(200, 25);
            this.cb_sexo.TabIndex = 12;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(36, 424);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(200, 25);
            this.txtEdad.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Edad";
            // 
            // btn_AgregarPac
            // 
            this.btn_AgregarPac.BackColor = System.Drawing.Color.Silver;
            this.btn_AgregarPac.FlatAppearance.BorderSize = 0;
            this.btn_AgregarPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarPac.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarPac.Location = new System.Drawing.Point(35, 567);
            this.btn_AgregarPac.Name = "btn_AgregarPac";
            this.btn_AgregarPac.Size = new System.Drawing.Size(200, 32);
            this.btn_AgregarPac.TabIndex = 9;
            this.btn_AgregarPac.Text = "Agregar Paciente";
            this.btn_AgregarPac.UseVisualStyleBackColor = false;
            this.btn_AgregarPac.Click += new System.EventHandler(this.btn_AgregarPac_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sexo";
            // 
            // txtAmaterno
            // 
            this.txtAmaterno.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmaterno.Location = new System.Drawing.Point(36, 337);
            this.txtAmaterno.Name = "txtAmaterno";
            this.txtAmaterno.Size = new System.Drawing.Size(200, 25);
            this.txtAmaterno.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido Materno";
            // 
            // txtApaterno
            // 
            this.txtApaterno.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApaterno.Location = new System.Drawing.Point(36, 249);
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.Size = new System.Drawing.Size(200, 25);
            this.txtApaterno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido Paterno";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(36, 166);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 25);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // dataGrid_Paciente
            // 
            this.dataGrid_Paciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Paciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pac,
            this.nom_pac,
            this.Apaterno,
            this.Amaterno,
            this.edad_pac,
            this.sexo_pac});
            this.dataGrid_Paciente.Location = new System.Drawing.Point(342, 166);
            this.dataGrid_Paciente.Name = "dataGrid_Paciente";
            this.dataGrid_Paciente.Size = new System.Drawing.Size(695, 433);
            this.dataGrid_Paciente.TabIndex = 2;
            // 
            // id_pac
            // 
            this.id_pac.HeaderText = "ID PACIENTE";
            this.id_pac.Name = "id_pac";
            // 
            // nom_pac
            // 
            this.nom_pac.HeaderText = "NOMBRE";
            this.nom_pac.Name = "nom_pac";
            // 
            // Apaterno
            // 
            this.Apaterno.HeaderText = "A. PATERNO";
            this.Apaterno.Name = "Apaterno";
            // 
            // Amaterno
            // 
            this.Amaterno.HeaderText = "A. MATERNO";
            this.Amaterno.Name = "Amaterno";
            // 
            // edad_pac
            // 
            this.edad_pac.HeaderText = "EDAD";
            this.edad_pac.Name = "edad_pac";
            // 
            // sexo_pac
            // 
            this.sexo_pac.HeaderText = "SEXO";
            this.sexo_pac.Name = "sexo_pac";
            // 
            // btn_RegMenu
            // 
            this.btn_RegMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RegMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegMenu.FlatAppearance.BorderSize = 0;
            this.btn_RegMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegMenu.Image = global::INTERFAZ_CENTRO_MEDICO.Properties.Resources.ant1;
            this.btn_RegMenu.Location = new System.Drawing.Point(26, 3);
            this.btn_RegMenu.Name = "btn_RegMenu";
            this.btn_RegMenu.Size = new System.Drawing.Size(63, 62);
            this.btn_RegMenu.TabIndex = 1;
            this.btn_RegMenu.UseVisualStyleBackColor = true;
            this.btn_RegMenu.Click += new System.EventHandler(this.btn_RegMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INTERFAZ_CENTRO_MEDICO.Properties.Resources.titulo;
            this.pictureBox1.Location = new System.Drawing.Point(342, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form_RegPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1060, 627);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGrid_Paciente);
            this.Controls.Add(this.panel2);
            this.Name = "Form_RegPaciente";
            this.Text = "Pacientes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Paciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RegMenu;
        private System.Windows.Forms.Button btn_AgregarPac;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.DataGridView dataGrid_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo_pac;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}