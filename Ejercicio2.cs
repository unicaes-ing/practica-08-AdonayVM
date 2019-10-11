using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_8
{
    class Ejercicio2
    {
        public struct Producto
        {
            public string nombre;
            private int cantidad;
            private double precio;
            private const double iva = 0.13;


            public void setCantidad(int cantidad)
            {
                if (cantidad > 0)
                {
                    this.cantidad = cantidad;
                }
            }

            public int getCantidad()
            {
                return cantidad;
            }

            public void setPrecio(double precio)
            {
                if (precio > 0.00)
                {
                    this.precio = precio;
                }
            }

            public double getPrecio()
            {
                double pagar;
                pagar = precio * iva;
                return precio + pagar;
            }
        }

        static void Main(string[] args)
        {
            int cantidad;
            Console.Write("Cantidad de productos a ingresar: ");

            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Producto[] producto = new Producto[cantidad];

            for (int i = 0; i < producto.Length; i++)
            {
                Console.WriteLine("Producto #{0}", i + 1);
                Console.Write("Ingrese el nombre del producto: ");
                producto[i].nombre = Console.ReadLine();
                Console.Write("Ingrese la cantidad del producto: ");
                producto[i].setCantidad(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Ingrese el precio del producto: ");
                producto[i].setPrecio(Convert.ToDouble(Console.ReadLine()));

            }

            for (int i = 0; i < producto.Length; i++)
            {

                Console.Clear();
                Console.WriteLine("Precio <Enter>  para mostrar el total a pagar por el cliente");
                Console.ReadKey();
                Console.Clear();
                double total;
                total = producto[i].getCantidad() * producto[i].getPrecio();
                Console.WriteLine("{0,5}   {1,-10}   {2,7}   {3,9} ", "Producto", "Cantidad", "Precio", "Total");
                Console.WriteLine("-------------------------------------------------------------");
                foreach (Producto p in producto)
                {
                    Console.WriteLine("{0,5}  {1,8}  {2, 13}   {3,10} ",
                        producto[i].nombre,
                        producto[i].getCantidad(),
                        producto[i].getPrecio(),
                        total);
                }
            }
            Console.ReadKey();
        }

    }
}
