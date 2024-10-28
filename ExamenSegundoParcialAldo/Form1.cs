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
    public partial class Form1 : Form
    {
        private List<Vehiculo> listaVehiculos;

        public Form1()
        {
            InitializeComponent();
            listaVehiculos = new List<Vehiculo>(); // Inicializa la lista de vehículos
            ActualizarLista();

        }
       

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            listaVehiculos.Add(vehiculo);
            ActualizarLista();
        }

    
         private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            switch (cmbTipoVehiculo.SelectedItem.ToString())
            {
                case "Coche":
                    CocheForm cocheForm = new CocheForm();
                    cocheForm.Owner = this; // Establece el formulario principal como propietario
                    cocheForm.ShowDialog(); // Muestra el formulario de coche
                    break;

                case "Moto":
                    MotoForm motoForm = new MotoForm();
                    motoForm.Owner = this;
                    motoForm.ShowDialog();
                    break;

                case "Bicicleta":
                    BiciForm bicicletaForm = new BiciForm();
                    bicicletaForm.Owner = this;
                    bicicletaForm.ShowDialog();
                    break;
            }

            ActualizarLista(); // Actualiza la lista después de agregar
        }

        private void ActualizarLista()
        {
            lstVehiculos.Items.Clear(); // Limpia los elementos actuales del ListBox

            foreach (var vehiculo in listaVehiculos)
            {
                lstVehiculos.Items.Add(vehiculo.ToString()); // Añade el vehículo al ListBox
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizarLista_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            if (lstVehiculos.SelectedIndex != -1)
            {
                listaVehiculos.RemoveAt(lstVehiculos.SelectedIndex);
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Seleccione un vehículo para eliminar.");
            }

        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
