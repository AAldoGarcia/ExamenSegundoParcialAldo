namespace ExamenSegundoParcialAldo
{
    partial class MotoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotoForm));
            this.Marca = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.Año = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarcaMoto = new System.Windows.Forms.TextBox();
            this.txtModeloMoto = new System.Windows.Forms.TextBox();
            this.txtAñoMoto = new System.Windows.Forms.TextBox();
            this.txtCilindrajeMoto = new System.Windows.Forms.TextBox();
            this.btnGuardarMoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(499, 44);
            this.Marca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(45, 16);
            this.Marca.TabIndex = 0;
            this.Marca.Text = "Marca";
            this.Marca.Click += new System.EventHandler(this.label1_Click);
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Location = new System.Drawing.Point(499, 129);
            this.Modelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(53, 16);
            this.Modelo.TabIndex = 1;
            this.Modelo.Text = "Modelo";
            // 
            // Año
            // 
            this.Año.AutoSize = true;
            this.Año.Location = new System.Drawing.Point(499, 203);
            this.Año.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(31, 16);
            this.Año.TabIndex = 2;
            this.Año.Text = "Año";
            this.Año.Click += new System.EventHandler(this.Año_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cilindraje";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMarcaMoto
            // 
            this.txtMarcaMoto.Location = new System.Drawing.Point(503, 85);
            this.txtMarcaMoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMarcaMoto.Name = "txtMarcaMoto";
            this.txtMarcaMoto.Size = new System.Drawing.Size(132, 22);
            this.txtMarcaMoto.TabIndex = 4;
            // 
            // txtModeloMoto
            // 
            this.txtModeloMoto.Location = new System.Drawing.Point(503, 164);
            this.txtModeloMoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModeloMoto.Name = "txtModeloMoto";
            this.txtModeloMoto.Size = new System.Drawing.Size(132, 22);
            this.txtModeloMoto.TabIndex = 5;
            // 
            // txtAñoMoto
            // 
            this.txtAñoMoto.Location = new System.Drawing.Point(503, 233);
            this.txtAñoMoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAñoMoto.Name = "txtAñoMoto";
            this.txtAñoMoto.Size = new System.Drawing.Size(132, 22);
            this.txtAñoMoto.TabIndex = 6;
            // 
            // txtCilindrajeMoto
            // 
            this.txtCilindrajeMoto.Location = new System.Drawing.Point(503, 295);
            this.txtCilindrajeMoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCilindrajeMoto.Name = "txtCilindrajeMoto";
            this.txtCilindrajeMoto.Size = new System.Drawing.Size(132, 22);
            this.txtCilindrajeMoto.TabIndex = 7;
            // 
            // btnGuardarMoto
            // 
            this.btnGuardarMoto.Location = new System.Drawing.Point(503, 368);
            this.btnGuardarMoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarMoto.Name = "btnGuardarMoto";
            this.btnGuardarMoto.Size = new System.Drawing.Size(111, 28);
            this.btnGuardarMoto.TabIndex = 8;
            this.btnGuardarMoto.Text = "GuardarMoto";
            this.btnGuardarMoto.UseVisualStyleBackColor = true;
            this.btnGuardarMoto.Click += new System.EventHandler(this.btnGuardarMoto_Click);
            // 
            // MotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnGuardarMoto);
            this.Controls.Add(this.txtCilindrajeMoto);
            this.Controls.Add(this.txtAñoMoto);
            this.Controls.Add(this.txtModeloMoto);
            this.Controls.Add(this.txtMarcaMoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Año);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.Marca);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MotoForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MotoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Label Año;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarcaMoto;
        private System.Windows.Forms.TextBox txtModeloMoto;
        private System.Windows.Forms.TextBox txtAñoMoto;
        private System.Windows.Forms.TextBox txtCilindrajeMoto;
        private System.Windows.Forms.Button btnGuardarMoto;
    }
}