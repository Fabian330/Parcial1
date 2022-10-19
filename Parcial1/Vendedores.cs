using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Vendedores
    {
        public Vendedores() { }

        public void ListadoVendedores()
        {
            Dictionary<int, string> vendedores = new Dictionary<int, string>();
            vendedores.Add(4321, "Luis");
            vendedores.Add(1234, "Adrian");

            foreach (var ven in vendedores)
            {
                Console.WriteLine($"Codigo: {ven.Key} Nombre: {ven.Value}");
            }
        }

        class Vendedor1 : Ivendedor1
        {
            public void VentasContado()
            {

            }
        }

        class Vendedor2 : Ivendedor2
        {
            public void VentasCredito()
            {

            }
          
        }
    }
}
