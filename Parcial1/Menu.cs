using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Menu:Vehiculos
    {

        public Menu() { }


        public void SeleccionOpc()
        {
            byte num1 = 0;
            Console.WriteLine("***Menu Principal***");
            Console.WriteLine("1- Vehiculos" + "\n" + "2- Ventas" + "\n" + "3- Reportes" + "\n" + "4- Salir");
            Console.Write("Digite una opcion: ");
            num1 = byte.Parse(Console.ReadLine());

            if (num1 == 1) { Console.Clear(); MenuV();}
            if (num1 == 2) { Console.Clear(); Ventas();}
            if (num1 == 3) { Console.Clear(); Reportes(); }
            if (num1 == 4) { Console.Clear(); Salir(); }
            
        }

        public void MenuV()
        {

            byte num2 = 0;

            Console.WriteLine("***Vehiculos***");
            Console.WriteLine("1- Agregar" + "\n" + "2- Modificar" + "\n" + "3- Consultar" + "\n" + "4- Volver");
            Console.Write("Digite una opcion: ");
            num2 = byte.Parse(Console.ReadLine());

            if (num2 == 1) { Console.Clear(); AgregarV(); }
            if (num2 == 2) { Console.Clear(); ModificarV(); }
            if (num2 == 3) { Console.Clear(); ConsultarV(); }
            if (num2 == 4) { Console.Clear(); SeleccionOpc(); }
        }

        public void AgregarV()
        {

            if (codigo[0] == 0)
            {
                for (int i = 0; i < codigo.Length; i++)
                {
                    Console.WriteLine("Ingrese el codigo del vehiculo " + (i + 1));
                    this.codigo[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la marca del vehiculo " + (i + 1));
                    this.marca[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese el costo del vehiculo " + (i + 1));
                    this.costo[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el modelo(año) del vehiculo " + (i + 1));
                    this.modelo[i] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                Console.WriteLine("Vehiculos agregados.");
                MenuV();
            }
            else
            {       
                Console.WriteLine("La cantidad maxima de vehiculos ya fue agregada.");
                Console.WriteLine("Presione enter para volver...");
                Console.ReadKey();
                Console.Clear();
                MenuV();
            }

        }

        public void ModificarV()
        {
            Console.Write("Ingrese el codigo del vehiculo a modificar: ");
            int codigo1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigo1 == this.codigo[i])
                {
                    Console.WriteLine("Codigo: " + this.codigo[i]);
                    Console.WriteLine("Ingrese la nueva marca: ");
                    this.marca[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo costo: ");
                    this.costo[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nuevo modelo: ");
                    this.modelo[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Presione enter para volver...");
                    Console.ReadKey();
                    Console.Clear();
                    MenuV();

                }

            }
            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigo1 != this.codigo[i])
                {
                    Console.WriteLine("Este vehiculo no existe.");
                    Console.WriteLine("Presione enter para volver...");
                    Console.ReadKey();
                    Console.Clear();
                    MenuV();
                }

            }

        }

        public void ConsultarV()
        {
            Console.Write("Ingrese el codigo del vehiculo a consultar: ");
            int codigo2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigo2 == this.codigo[i])
                {
                    Console.WriteLine("Codigo: " + this.codigo[i]);
                    Console.WriteLine("Marca: " + this.marca[i] + "\n" + "Costo: " + this.costo[i] + "\n" + "Modelo: " + this.modelo[i]);
                    Console.WriteLine("Presione enter para volver...");
                    Console.ReadKey();
                    Console.Clear();
                    MenuV();
                }
                
            }
            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigo2 != this.codigo[i])
                {
                    Console.WriteLine("Este vehiculo no existe.");
                    Console.WriteLine("Presione enter para volver...");
                    Console.ReadKey();
                    Console.Clear();
                    MenuV();
                }

            }
        }

        public void Ventas()
        {
            Console.Clear();
            Console.WriteLine("***Ventas***");

            Console.Write("Ingrese el codigo del vehiculo: ");
            int codigo1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigo1 == this.codigo[i])
                {
                    Console.WriteLine("Vehiculo existente: ");
                    Console.WriteLine("Codigo: " + this.codigo[i]);
                    Console.WriteLine("Marca: " + this.marca[i] + "\n" + "Costo: " + this.costo[i] + "\n" + "Modelo: " + this.modelo[i]);
                    
                }
                
            }


            Console.Write("Ingrese el codigo del vendedor: ");
            int codigo2 = int.Parse(Console.ReadLine());
           
                if (codigo2 == 4321)
                {  
                    Console.WriteLine("Vendedor encontrado:");
                    Console.WriteLine("Codigo: " + 4321);
                    Console.WriteLine("Vendedor: Luis");
                    
                }
                else if (codigo2 == 1234)
                {
                    Console.WriteLine("Vendedor encontrado:");
                    Console.WriteLine("Codigo: " + 1234);
                    Console.WriteLine("Vendedor: Adrian");
                }
                else
                {
                    Console.WriteLine("Este vendedor no existe.");
                    Console.WriteLine("Presione enter para volver...");
                    Console.ReadKey();
                    Console.Clear();
                    SeleccionOpc();
                }

            Console.Write("Indique la cantidad de vehiculos a comprar: ");
            int cant = int.Parse(Console.ReadLine());

            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigo1 == this.codigo[i])
                {
                    int resultado = (cant * this.costo[i]);
                    Console.WriteLine("La cantidad a pagar es de: " + resultado + " colones.");
                    Console.WriteLine("Presione enter para volver...");
                    Console.ReadKey();
                    Console.Clear();
                    SeleccionOpc();
                }
            }
            
        }

        public void Reportes()
        {
            Vendedores v = new Vendedores();
            Tipo t = new Tipo();
            Tipo.Automovil v1 = new Tipo.Automovil();
            Tipo.Motocicleta v2 = new Tipo.Motocicleta();
            Tipo.Dron v3 = new Tipo.Dron();
            Console.Clear();
            Console.WriteLine("***Reportes***");
            Console.WriteLine("Vendedores: ");
            v.ListadoVendedores();
            Console.WriteLine("\n"+"Tipos: ");
            t.Tipo_Vehiculo();
            v1.TipoVehiculo();
            v2.TipoVehiculo();
            v3.TipoVehiculo();

            Console.WriteLine("\n" +"Vehiculos ingresados: ");
            for (int i = 0; i < codigo.Length; i++)
            {
                Console.WriteLine(this.codigo[i]+" - "+this.marca[i]);
            }

            Console.WriteLine("\n"+"Presione enter para volver...");
            Console.ReadKey();
            Console.Clear();
            SeleccionOpc();
    
            
        }

        public void Salir() { Environment.Exit(1); }
    
    }

    
}
