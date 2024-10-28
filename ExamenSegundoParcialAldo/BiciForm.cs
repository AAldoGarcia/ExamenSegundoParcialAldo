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
    public partial class BiciForm : Form
    {
        public BiciForm()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuardarBicicleta_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un objeto bicicleta y llenar sus propiedades
                Bicicleta nuevaBicicleta = new Bicicleta
                {
                    Marca = txtMarcaBicicleta.Text,
                    Modelo = txtModeloBicicleta.Text,
                    Año = int.Parse(txtAñoBicicleta.Text),
                    TipoFreno = txtTipoFrenoBicicleta.Text
                };

                // Agregar la nueva bicicleta a la lista en el formulario principal
                ((Form1)this.Owner).AgregarVehiculo(nuevaBicicleta);

                // Cerrar el formulario después de guardar
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el Año.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la bicicleta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
