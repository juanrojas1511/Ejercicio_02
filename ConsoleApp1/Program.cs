using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string categoria_hotel;

            int dias, adicional, precio;

            adicional = 7;
            Console.WriteLine("¿Qué categoría del hotel desearán: ");

            categoria_hotel = (Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de días que estará en el hotel: ");

            dias = int.Parse(Console.ReadLine());
            switch (categoria_hotel)

            {
                case "Tres estrellas":
                    if (dias >= 11)

                    {

                        precio = 70;

                        precio = precio * dias;

                        precio = precio + adicional * dias;

                    }

                    if (dias > 5 && dias < 11)

                    {

                        precio = 85;

                        precio = precio * dias;

                        precio = precio + adicional * dias;

                    }

                    else

                    {

                        precio = 100;

                        precio = precio * dias;

                        precio = precio + adicional * dias;

                    }

                    Console.WriteLine("Cantidad de días:" + dias);

                    Console.WriteLine("Precio Total:S/." + precio);

                    break;
                case "Cinco estrellas":

                    if (dias >= 11)
                    {

                        precio = 250;

                        precio = precio * dias;

                        precio = precio + adicional * dias;

                    }

                    if (dias > 5 && dias < 11)
                    {

                        precio = 270;

                        precio = precio * dias;

                        precio = precio + adicional * dias;

                    }
                    else
                    {

                        precio = 300;

                        precio = precio * dias;

                        precio = precio + adicional * dias;

                    }
                    Console.WriteLine("Cantidad de días:" + dias);

                    Console.WriteLine("Precio Total:S/." + precio);

                    break;
                   
            }
            Console.ReadKey();
        }
    }
}
