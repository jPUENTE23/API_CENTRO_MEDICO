namespace INTERFAZ_CENTRO_MEDICO
{
    partial class Form_Doctor
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.link_NuevaArea = new System.Windows.Forms.LinkLabel();
            this.cb_AreasM = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_RegMenu = new System.Windows.Forms.Button();
            this.btn_AgregarDoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_sexo);
            this.panel2.Controls.Add(this.link_NuevaArea);
            this.panel2.Controls.Add(this.cb_AreasM);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtEdad);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_RegMenu);
            this.panel2.Controls.Add(this.btn_AgregarDoc);
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
            this.panel2.Size = new System.Drawing.Size(287, 655);
            this.panel2.TabIndex = 2;
            // 
            // link_NuevaArea
            // 
            this.link_NuevaArea.AutoSize = true;
            this.link_NuevaArea.Location = new System.Drawing.Point(135, 542);
            this.link_NuevaArea.Name = "link_NuevaArea";
            this.link_NuevaArea.Size = new System.Drawing.Size(101, 13);
            this.link_NuevaArea.TabIndex = 14;
            this.link_NuevaArea.TabStop = true;
            this.link_NuevaArea.Text = "Agregar nueva area";
            this.link_NuevaArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_AreasM
            // 
            this.cb_AreasM.FormattingEnabled = true;
            this.cb_AreasM.Location = new System.Drawing.Point(36, 505);
            this.cb_AreasM.Name = "cb_AreasM";
            this.cb_AreasM.Size = new System.Drawing.Size(200, 21);
            this.cb_AreasM.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Area del Doctor";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(36, 369);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(200, 20);
            this.txtEdad.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Edad";
            // 
            // btn_RegMenu
            // 
            this.btn_RegMenu.Location = new System.Drawing.Point(36, 25);
            this.btn_RegMenu.Name = "btn_RegMenu";
            this.btn_RegMenu.Size = new System.Drawing.Size(75, 23);
            this.btn_RegMenu.TabIndex = 1;
            this.btn_RegMenu.Text = "< Regresar";
            this.btn_RegMenu.UseVisualStyleBackColor = true;
            this.btn_RegMenu.Click += new System.EventHandler(this.btn_RegMenu_Click);
            // 
            // btn_AgregarDoc
            // 
            this.btn_AgregarDoc.Location = new System.Drawing.Point(36, 606);
            this.btn_AgregarDoc.Name = "btn_AgregarDoc";
            this.btn_AgregarDoc.Size = new System.Drawing.Size(200, 23);
            this.btn_AgregarDoc.TabIndex = 9;
            this.btn_AgregarDoc.Text = "Agregar Doctor";
            this.btn_AgregarDoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AgregarDoc.UseVisualStyleBackColor = true;
            this.btn_AgregarDoc.Click += new System.EventHandler(this.btn_AgregarDoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Doctor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sexo";
            // 
            // txtAmaterno
            // 
            this.txtAmaterno.Location = new System.Drawing.Point(36, 301);
            this.txtAmaterno.Name = "txtAmaterno";
            this.txtAmaterno.Size = new System.Drawing.Size(200, 20);
            this.txtAmaterno.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido Materno";
            // 
            // txtApaterno
            // 
            this.txtApaterno.Location = new System.Drawing.Point(36, 233);
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.Size = new System.Drawing.Size(200, 20);
            this.txtApaterno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido Paterno";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(36, 168);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cb_sexo.Location = new System.Drawing.Point(36, 440);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(200, 21);
            this.cb_sexo.TabIndex = 15;
            // 
            // Form_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 655);
            this.Controls.Add(this.panel2);
            this.Name = "Form_Doctor";
            this.Text = "Form_octor";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_RegMenu;
        private System.Windows.Forms.Button btn_AgregarDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_AreasM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel link_NuevaArea;
        private System.Windows.Forms.ComboBox cb_sexo;
    }
}