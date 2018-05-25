using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DennisUlffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la cocina que desea cocinar");

            Console.WriteLine("Presiona Enter para continua");
            Console.ReadLine();

            Console.Write("Que desea cocinar?");
            List<String> list = new List<String>();
            list.Add("1)Huevo frito");
            list.Add("2)Pollo frito");
            list.Add("3)Lomo Saltado");
            list.Add("4)Carne asada");

            foreach (string prime in list)
            {
                System.Console.WriteLine(prime);
                Console.ReadLine();

            }


            Console.ReadLine();

            Console.WriteLine("Estos son los ingredientes Organicos que se usaran");
            Organicos organicos = new Organicos();
            Console.WriteLine(organicos.nombre1);
            Console.WriteLine(organicos.nombre2);
            Console.WriteLine(organicos.nombre3);

            Console.ReadKey();

            Console.WriteLine("Estos son los ingredientes Procesados que se usaran");
            Procesados procesados = new Procesados();
            Console.WriteLine(procesados.nombre1);
            Console.WriteLine(procesados.nombre2);
            Console.WriteLine(procesados.nombre3);

            Console.ReadKey();

            Console.WriteLine("Desea Agregar algun ingrediente extra?");
            Extras extras = new Extras();
            Console.WriteLine(extras.nombre1);
            Console.WriteLine(extras.nombre2);
            Console.WriteLine(extras.nombre3);

            Console.WriteLine("Presiona S para si o N para No");

            ConsoleKeyInfo cki = Console.ReadKey();

            if (cki.Key.ToString() == "s")
            {
                Console.WriteLine("Se Utilizaran los exras");
            }
            else
            {
                Console.WriteLine("No se utilizaran extras");
            }
            Console.WriteLine("Cocinando...");
            Console.WriteLine("Su Orcen esta lista");
            Console.WriteLine("Gracias por usar el sistema");

            Console.ReadLine();
        }

    }
}
