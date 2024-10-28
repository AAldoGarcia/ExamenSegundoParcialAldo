using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenSegundoParcialAldo
{
    public partial class CocheForm : Form
    {
        public CocheForm()
        {
            InitializeComponent();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuardarCoche_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un objeto coche y llenar sus propiedades
                Coche nuevoCoche = new Coche
                {
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Año = int.Parse(txtAño.Text),
                    NumeroPuertas = int.Parse(txtNumeroPuertas.Text),
                    TipoCombustible = txtTipoCombustible.Text
                };

                // Aquí puedes agregar el nuevo coche a una lista en el formulario principal
                ((Form1)this.Owner).AgregarVehiculo(nuevoCoche);

                // Cerrar el formulario después de guardar
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos para Año y Número de Puertas.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el coche: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
