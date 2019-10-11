using System;

namespace Práctica_8
{
    class Program
    {
        public struct Estudiante
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private double CUM;

            public void setCum(double CUM)
            {
                if (CUM >= 0)
                {
                    if (CUM <= 10)
                    {
                        this.CUM = CUM;
                    }


                }
            }

            public double getCum()
            {
                return CUM;
            }
        }


        static void Main(string[] args)
        {
            Estudiante est1 = new Estudiante();
            Console.WriteLine("Ingrese su carnet: ");
            est1.carnet = Console.ReadLine();
            Console.WriteLine("======================");


            Console.WriteLine("Ingrese su nombre: ");
            est1.nombre = Console.ReadLine();
            Console.WriteLine("======================");

            Console.WriteLine("Ingrese su carrera: ");
            est1.carrera = Console.ReadLine();
            Console.WriteLine("======================");


            Console.WriteLine("Ingrese su cum: ");
            est1.setCum(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("======================");

            Console.WriteLine("Presione [ENTER] para mostrar los datos");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Carnet:  " + est1.carnet);
            Console.WriteLine("Nombre: " + est1.nombre);
            Console.WriteLine("Carrera: " + est1.carrera);
            Console.WriteLine("Cum: " + est1.getCum());
        }
    }
}
