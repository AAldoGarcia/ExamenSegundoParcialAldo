using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSegundoParcialAldo
{
    
        public class Vehiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Año { get; set; }

        public virtual string ObtenerInfo() => $"{Marca} {Modelo} ({Año})";
    }

    

}
