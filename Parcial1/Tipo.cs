using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Tipo
    {
        String[] tipo = {"Motocicleta","Automovil","Dron" };
        public Tipo() { }

        public void Tipo_Vehiculo()
        {
            Console.WriteLine("Existen diferentes tipos de vehiculos");
        }

        public class Automovil : Tipo
        {
            public virtual void TipoVehiculo() { Console.WriteLine("Vehiculo de cuadro ruedas"); }
        }

        public class Motocicleta : Automovil
        {
            public override void TipoVehiculo() { Console.WriteLine("Vehiculo de dos ruedas"); }
        }

        public class Dron : Automovil
        {
            public override void TipoVehiculo() { Console.WriteLine("Vehiculo volador"); }
        }
    }
}
