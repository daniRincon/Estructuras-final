using System;
using System.Collections.Generic;
using System.Text;

namespace Estructuras_final
{
    class Clientes
    {
        public string identificacion;
        public String nombre;
        public String apellidos;
        public String edad;
        public String tipo_cliente;
        public string silla;
        public string pelicula;
        public string sala;
        public double pago;
       
        List<Clientes> comprador = new List<Clientes>();


        public string Identificacion { get => identificacion; set => identificacion = value; }

        public String Nombre { get => nombre; set => nombre = value; }

        public String Apellidos { get => apellidos; set => apellidos = value; }

        public String Edad { get => edad; set => edad = value; }

        public String Tipo_cliente { get => tipo_cliente; set => tipo_cliente = value; }

        public String Pelicula{ get => pelicula; set => pelicula = value; }

        public String Silla { get => silla; set => silla = value; }
        public double Pago { get => pago; set => pago = value; }

        public String Sala { get => sala; set => sala = value; }





        public void Tipodecliente()
        {
            int oro=0, plata=0, vip=0, genera=0;

            Console.WriteLine("Tipo de Cliente");
            Console.WriteLine("");
            Console.WriteLine("1. Cliente Oro");
            Console.WriteLine("2. Cliente Plata");
            Console.WriteLine("3. Cliente Bronce");
            Console.WriteLine("4. Cliente General");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    oro++;
                    break;
                case 2:
                    plata++;
                    break;
                case 3:
                    vip++;
                    break;
                case 4:
                    genera++;
                    break;

            }
            
        }


        public void edades()
        {

        }





        public void Agregar()
        {
            Clientes añadir = new Clientes();

            Console.WriteLine("Ingrese su número de identificación");
            añadir.identificacion = Console.ReadLine();
            Console.WriteLine("Ingrese su nombre");
            añadir.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sus apellidos");
            añadir.apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese sus edad");
            añadir.edad= Console.ReadLine();
            Console.WriteLine("Ingresa el tipo de cliente que eres");
            añadir. tipo_cliente= Console.ReadLine();
            Console.WriteLine("¿ en qué sala deseas estar?");
            añadir.sala =Console.ReadLine();
            Console.WriteLine("¿ qué pelicula verás?");
            añadir.pelicula = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad que ha pagado por su pelicula");
            añadir.pago = double.Parse(Console.ReadLine());
            comprador.Add(añadir);
            Console.WriteLine("Se agregó este cliente ");

            Console.ReadKey();
        }



        public void Mostrar()
        {
            Console.WriteLine("Listado de clientes");

            foreach (Clientes p in comprador)
            {
                Console.WriteLine("_____________________________");
               
                Console.WriteLine(" Nuestr@ cliente : " + p.Nombre);
                Console.WriteLine(" Que se apellida: " + p.Apellidos);
                Console.WriteLine(" Con número de indentificación: " + p.Identificacion);
                Console.WriteLine(" con la edad de: " + p.Edad);
                Console.WriteLine(" que es cliente: " + p.Tipo_cliente);
                Console.WriteLine("Estará en la sala: " + p.Sala);
                Console.WriteLine("Su número de asiento es: " + p.Silla);
                Console.WriteLine("que pagó: " + p.pago);
                Console.WriteLine("_____________________________");
            }
        }

    }
}
