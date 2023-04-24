namespace INTERFAZ_CENTRO_MEDICO
{
    partial class Form_AreaMedica
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
            this.txt_areaMedica = new System.Windows.Forms.TextBox();
            this.btn_agrearArea = new System.Windows.Forms.Button();
            this.link_Regresar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la area medica:";
            // 
            // txt_areaMedica
            // 
            this.txt_areaMedica.Location = new System.Drawing.Point(27, 75);
            this.txt_areaMedica.Name = "txt_areaMedica";
            this.txt_areaMedica.Size = new System.Drawing.Size(253, 20);
            this.txt_areaMedica.TabIndex = 1;
            // 
            // btn_agrearArea
            // 
            this.btn_agrearArea.Location = new System.Drawing.Point(27, 114);
            this.btn_agrearArea.Name = "btn_agrearArea";
            this.btn_agrearArea.Size = new System.Drawing.Size(253, 23);
            this.btn_agrearArea.TabIndex = 2;
            this.btn_agrearArea.Text = "Agregar";
            this.btn_agrearArea.UseVisualStyleBackColor = true;
            this.btn_agrearArea.Click += new System.EventHandler(this.btn_agrearArea_Click);
            // 
            // link_Regresar
            // 
            this.link_Regresar.AutoSize = true;
            this.link_Regresar.Location = new System.Drawing.Point(24, 18);
            this.link_Regresar.Name = "link_Regresar";
            this.link_Regresar.Size = new System.Drawing.Size(59, 13);
            this.link_Regresar.TabIndex = 3;
            this.link_Regresar.TabStop = true;
            this.link_Regresar.Text = "< Regresar";
            this.link_Regresar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Regresar_LinkClicked);
            // 
            // Form_AreaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 165);
            this.Controls.Add(this.link_Regresar);
            this.Controls.Add(this.btn_agrearArea);
            this.Controls.Add(this.txt_areaMedica);
            this.Controls.Add(this.label1);
            this.Name = "Form_AreaMedica";
            this.Text = "Areas Medicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_areaMedica;
        private System.Windows.Forms.Button btn_agrearArea;
        private System.Windows.Forms.LinkLabel link_Regresar;
    }
}