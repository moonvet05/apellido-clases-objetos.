
using System;
using System.Collections.Generic;

namespace RegistroInfo;

public class registroDeFacturacion
{
    static void Main(string[] Args)
    {
        Console.WriteLine("SISTEMA DE REGISTRO DE PRODUCTOS");
        Console.WriteLine();

        List<Producto> productos = new List<Producto>();

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("REGISTRO DEL PRODUCTO #" + i);
            Console.WriteLine();

            try
            {
                Console.Write("Introduzca el Código del Producto: ");
                int Codigo = int.Parse(Console.ReadLine());

                Console.Write("Nombre del Producto: ");
                string Nombre = Console.ReadLine();

                Console.Write("Cantidad de Productos: ");
                int Cantidad = int.Parse(Console.ReadLine());

                Console.Write("Introduzca el precio del Producto: ");
                double Precio = double.Parse(Console.ReadLine());

                Producto producto = new Producto(Codigo, Nombre, Precio, Cantidad);

                productos.Add(producto);

                Console.WriteLine("PRODUCTO REGISTRADO CORRECTAMENTE");
            }
            catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("No se pudo registrar este producto.");
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Introduzca un formato de dato válido.");
            }

            Console.WriteLine();
        }

        Console.WriteLine("===== LISTA DE PRODUCTOS REGISTRADOS =====");

        foreach (Producto producto in productos)
        {
            producto.MostrarInfo();
            Console.WriteLine("------------------------------");
        }

        Console.WriteLine("TOTAL DE PRODUCTOS REGISTRADOS: " + productos.Count);
    }
}