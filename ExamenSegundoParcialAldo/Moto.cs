using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSegundoParcialAldo
{
    public class Moto : Vehiculo
    {
        public int Cilindraje { get; set; }

        public override string ToString()
        {
            return $"Moto - Modelo: {Modelo}, Marca: {Marca}, Año: {Año}";
        }
    }
}
