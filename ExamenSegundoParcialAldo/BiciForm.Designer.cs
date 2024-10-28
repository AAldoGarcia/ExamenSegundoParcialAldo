namespace ExamenSegundoParcialAldo
{
    partial class BiciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiciForm));
            this.Marca = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.Año = new System.Windows.Forms.Label();
            this.TipoDeFreno = new System.Windows.Forms.Label();
            this.txtMarcaBicicleta = new System.Windows.Forms.TextBox();
            this.txtModeloBicicleta = new System.Windows.Forms.TextBox();
            this.txtAñoBicicleta = new System.Windows.Forms.TextBox();
            this.txtTipoFrenoBicicleta = new System.Windows.Forms.TextBox();
            this.btnGuardarBicicleta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(415, 33);
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
            this.Modelo.Location = new System.Drawing.Point(415, 98);
            this.Modelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(53, 16);
            this.Modelo.TabIndex = 1;
            this.Modelo.Text = "Modelo";
            // 
            // Año
            // 
            this.Año.AutoSize = true;
            this.Año.Location = new System.Drawing.Point(415, 159);
            this.Año.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(31, 16);
            this.Año.TabIndex = 2;
            this.Año.Text = "Año";
            this.Año.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TipoDeFreno
            // 
            this.TipoDeFreno.AutoSize = true;
            this.TipoDeFreno.Location = new System.Drawing.Point(415, 234);
            this.TipoDeFreno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TipoDeFreno.Name = "TipoDeFreno";
            this.TipoDeFreno.Size = new System.Drawing.Size(88, 16);
            this.TipoDeFreno.TabIndex = 3;
            this.TipoDeFreno.Text = "TipoDeFreno";
            // 
            // txtMarcaBicicleta
            // 
            this.txtMarcaBicicleta.Location = new System.Drawing.Point(419, 53);
            this.txtMarcaBicicleta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMarcaBicicleta.Name = "txtMarcaBicicleta";
            this.txtMarcaBicicleta.Size = new System.Drawing.Size(132, 22);
            this.txtMarcaBicicleta.TabIndex = 4;
            // 
            // txtModeloBicicleta
            // 
            this.txtModeloBicicleta.Location = new System.Drawing.Point(419, 130);
            this.txtModeloBicicleta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModeloBicicleta.Name = "txtModeloBicicleta";
            this.txtModeloBicicleta.Size = new System.Drawing.Size(132, 22);
            this.txtModeloBicicleta.TabIndex = 5;
            // 
            // txtAñoBicicleta
            // 
            this.txtAñoBicicleta.Location = new System.Drawing.Point(419, 194);
            this.txtAñoBicicleta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAñoBicicleta.Name = "txtAñoBicicleta";
            this.txtAñoBicicleta.Size = new System.Drawing.Size(132, 22);
            this.txtAñoBicicleta.TabIndex = 6;
            // 
            // txtTipoFrenoBicicleta
            // 
            this.txtTipoFrenoBicicleta.Location = new System.Drawing.Point(419, 267);
            this.txtTipoFrenoBicicleta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipoFrenoBicicleta.Name = "txtTipoFrenoBicicleta";
            this.txtTipoFrenoBicicleta.Size = new System.Drawing.Size(132, 22);
            this.txtTipoFrenoBicicleta.TabIndex = 7;
            // 
            // btnGuardarBicicleta
            // 
            this.btnGuardarBicicleta.Location = new System.Drawing.Point(419, 320);
            this.btnGuardarBicicleta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarBicicleta.Name = "btnGuardarBicicleta";
            this.btnGuardarBicicleta.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarBicicleta.TabIndex = 8;
            this.btnGuardarBicicleta.Text = "GuardarBici";
            this.btnGuardarBicicleta.UseVisualStyleBackColor = true;
            this.btnGuardarBicicleta.Click += new System.EventHandler(this.btnGuardarBicicleta_Click);
            // 
            // BiciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnGuardarBicicleta);
            this.Controls.Add(this.txtTipoFrenoBicicleta);
            this.Controls.Add(this.txtAñoBicicleta);
            this.Controls.Add(this.txtModeloBicicleta);
            this.Controls.Add(this.txtMarcaBicicleta);
            this.Controls.Add(this.TipoDeFreno);
            this.Controls.Add(this.Año);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.Marca);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BiciForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Label Año;
        private System.Windows.Forms.Label TipoDeFreno;
        private System.Windows.Forms.TextBox txtMarcaBicicleta;
        private System.Windows.Forms.TextBox txtModeloBicicleta;
        private System.Windows.Forms.TextBox txtAñoBicicleta;
        private System.Windows.Forms.TextBox txtTipoFrenoBicicleta;
        private System.Windows.Forms.Button btnGuardarBicicleta;
    }
}