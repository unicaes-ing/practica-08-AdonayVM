using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_8
{
    class Ejercicio4
    {
        public enum TipoDePago
        {
            cash = 1,
            debito = 2,
            credito = 3
        }

        public static double pagar;
        static int tipo;

        static void Main(string[] args)
        {
            Console.Write("Ingrese el total a pagar: ");
            pagar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngrese el tipo de pago: ");
            Console.WriteLine(" [1].Efectivo");
            Console.WriteLine(" [2].Tarjeta de Debito");
            Console.WriteLine(" [3].Tarjeta de Credito");
            Console.WriteLine("-------------------------");
            tipo = Convert.ToInt32(Console.ReadLine());
            func1();

            Console.ReadKey();
        }

        static void func1()
        {
            switch ((TipoDePago)tipo)
            {
                case TipoDePago.cash:
                    Console.Clear();
                    Console.WriteLine("Monto:${0}", pagar);
                    Console.WriteLine("Efectivo: Descuento del 15%");

                    double total1, sub1;
                    sub1 = pagar * 0.15;
                    total1 = pagar - sub1;
                    Console.WriteLine("El total a pagar es de:${0}", total1);

                    break;

                case TipoDePago.debito:
                    Console.Clear();
                    Console.WriteLine("Monto:${0}", pagar);
                    Console.WriteLine("Tarjeta de Debito: Descuento del 10%");

                    double total2, sub2;
                    sub2 = pagar * 0.10;
                    total2 = pagar - sub2;
                    Console.WriteLine("El total a pagar es de:${0}", total2);
                    break;

                case TipoDePago.credito:
                    Console.Clear();
                    Console.WriteLine("Monto:${0}", pagar);
                    Console.WriteLine(" Tarjeta de Credito: Descuento del 5%");

                    double total3, sub3;
                    sub3 = pagar * 0.05;
                    total3 = pagar - sub3;
                    Console.WriteLine("El total a pagar es de:${0}", total3);
                    break;
            }
        }
    }
}
