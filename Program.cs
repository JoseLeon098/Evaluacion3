using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }
        private static void Ejecutar()
        {

            Pelicula dato = new Pelicula();
            char opcion = ' ';
            do
            {
                Class1 modelo = new Class1();
                Console.WriteLine("Digite el nombre de la pelicula");
                modelo.nombre = Console.ReadLine();
                Console.WriteLine("Digite el genero de la pelicula");
                modelo.genero = Console.ReadLine();
                Console.WriteLine("Digite el año de estreno de la pelicula");
                modelo.estreno = int.Parse(Console.ReadLine());
                dato.Guardar(modelo);
                Console.WriteLine("Desea agregar otra pelicula");
                opcion = char.Parse(Console.ReadLine());
            } while (opcion.Equals('s') || opcion.Equals('S'));

            foreach (Class1 item in dato.Consultar())
            {
                Console.WriteLine("Pelicula : " + item.nombre);
                Console.WriteLine("Genero : " + item.genero);
                Console.WriteLine("Año de estreno : " + item.estreno);

                if (item.estreno > 2020)
                {
                    Console.WriteLine("La pelicula no se ha estrenado aun");
                }
                else
                {
                    Console.WriteLine("La pelicula ya se ha estrenado");
                }
                Console.WriteLine("*----------------------------*");
                Console.ReadLine();
            }
        }
    }
}
