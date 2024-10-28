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
    public partial class MotoForm : Form
    {
        public MotoForm()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MotoForm_Load(object sender, EventArgs e)
        {

        }

        private void Año_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarMoto_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un objeto moto y llenar sus propiedades
                Moto nuevaMoto = new Moto
                {
                    Marca = txtMarcaMoto.Text,
                    Modelo = txtModeloMoto.Text,
                    Año = int.Parse(txtAñoMoto.Text),
                    Cilindraje = int.Parse(txtCilindrajeMoto.Text)
                };

                // Agregar la nueva moto a la lista en el formulario principal
                ((Form1)this.Owner).AgregarVehiculo(nuevaMoto);

                // Cerrar el formulario después de guardar
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos para Año y Cilindraje.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la moto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
   
    }

