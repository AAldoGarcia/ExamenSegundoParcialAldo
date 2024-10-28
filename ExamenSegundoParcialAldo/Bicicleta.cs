using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSegundoParcialAldo
{
    public class Bicicleta : Vehiculo
    {
        public string TipoFreno { get; set; }

        public override string ToString()
        {
            return $"Bicicleta - Modelo: {Modelo}, Marca: {Marca}, Año: {Año}, Tipo de Freno: {TipoFreno}";
        }
    }
}
