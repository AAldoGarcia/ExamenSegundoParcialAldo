using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSegundoParcialAldo
{
    public class Coche : Vehiculo
    {
        public int NumeroPuertas { get; set; }
        public string TipoCombustible { get; set; }

        public override string ToString()
        {
            return $"Coche - Modelo: {Modelo}, Marca: {Marca}, Año: {Año}";
        }
    }
}
