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
            this.panel_menuLateral = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_botones = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_pacientes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel_menuLateral.SuspendLayout();
            this.panel_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menuLateral
            // 
            this.panel_menuLateral.Controls.Add(this.panel_botones);
            this.panel_menuLateral.Controls.Add(this.panel_logo);
            this.panel_menuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menuLateral.Location = new System.Drawing.Point(0, 0);
            this.panel_menuLateral.Name = "panel_menuLateral";
            this.panel_menuLateral.Size = new System.Drawing.Size(258, 656);
            this.panel_menuLateral.TabIndex = 0;
            // 
            // panel_logo
            // 
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(258, 217);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_botones
            // 
            this.panel_botones.Controls.Add(this.button4);
            this.panel_botones.Controls.Add(this.button3);
            this.panel_botones.Controls.Add(this.btn_pacientes);
            this.panel_botones.Controls.Add(this.button1);
            this.panel_botones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_botones.Location = new System.Drawing.Point(0, 217);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.Size = new System.Drawing.Size(258, 245);
            this.panel_botones.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar Cita";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_pacientes
            // 
            this.btn_pacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pacientes.Location = new System.Drawing.Point(0, 50);
            this.btn_pacientes.Name = "btn_pacientes";
            this.btn_pacientes.Size = new System.Drawing.Size(258, 50);
            this.btn_pacientes.TabIndex = 1;
            this.btn_pacientes.Text = "Pacientes";
            this.btn_pacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pacientes.UseVisualStyleBackColor = true;
            this.btn_pacientes.Click += new System.EventHandler(this.btn_pacientes_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Doctores";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(258, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Facturacion";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 656);
            this.Controls.Add(this.panel_menuLateral);
            this.Name = "Form_Inicio";
            this.Text = "Inicio";
            this.panel_menuLateral.ResumeLayout(false);
            this.panel_botones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menuLateral;
        private System.Windows.Forms.Panel panel_botones;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_pacientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_logo;
    }
}

