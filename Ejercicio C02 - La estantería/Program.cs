﻿using Biblioteca;

namespace Ejercicio_C02___La_estantería
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo un estante
            Estante estante = new Estante(1, 5);

            // Creo 4 productos
            Producto p1 = new Producto("Pepsi", "PESDS97413", 18.5f);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);
            Producto p5 = new Producto("Pepsi", "PESDS97413", (float)18.5);

            // Agrego los productos al estante
            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }

            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }

            if (estante + p2)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }

            if (estante + p3)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }

            if (estante + p4)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            if (estante + p5)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p5.GetMarca(), (string)p5, p5.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p5.GetMarca(), (string)p5, p5.GetPrecio());
            }
            if (estante == p1)
            {
                Console.WriteLine("{0} está en el estante.", p1.GetMarca());
            }

            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstante(estante));

            estante = estante - p3;
            if(estante != p3)
            {
                Console.WriteLine($"{p3.GetMarca()} se quitó del estante");
            }
            if (estante == p3)
            {
                Console.WriteLine($"{p3.GetMarca()} está en el estante");
            }

            if(p1 == p4)
            {
                Console.WriteLine("Ambos productos son iguales");
            }
            else
            {
                Console.WriteLine("Los productos son distintos");
            }

            if (p1 == "Pepsi")
            {
                Console.WriteLine($"Ambos productos son {p1.GetMarca()}");
            }
            else
            {
                Console.WriteLine("Los productos son distintos");
            }
        }
    }
}
