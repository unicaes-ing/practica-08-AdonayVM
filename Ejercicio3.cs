using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_8
{
    class Ejercicio3
    {
        public struct Materia
        {
            public string nombreMateria;
            private double nota;

            public void setNota(double nota)
            {

                if (nota <= 6.0)
                {
                    this.nota = nota;
                }
                else
                {
                    this.nota = nota;
                }


            }

            public double getNota()
            {
                if (nota <= 6.0)
                {
                    Console.WriteLine("REPROBADO");

                }
                else
                {
                    Console.WriteLine("APROBADO");

                }
                return nota;
            }
        }
        public struct Alumno
        {
            public string carnet;
            public string nombreAlumno;
            public string carrera;
            public Materia materia1;
            public Materia materia2;
            public Materia materia3;
            public Materia materia4;
        }

        static void Main(string[] args)
        {
            int cant;
            Console.Write("Cantidad de alumnos a ingresar: ");
            cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Alumno[] alum = new Alumno[cant];
            for (int c = 0; c < alum.Length; c++)
            {
                Console.WriteLine("Alumno #{0}", c + 1);
                Console.WriteLine("Carnet del Alumno: ");
                alum[c].carnet = Console.ReadLine();

                Console.WriteLine("Nombre del Alumno: ");
                alum[c].nombreAlumno = Console.ReadLine();

                Console.WriteLine("Carrera del Alumno: ");
                alum[c].carrera = Console.ReadLine();


                Console.WriteLine("Nota de la materia 1: ");
                alum[c].materia1.setNota(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Nota de la materia 2: ");
                alum[c].materia2.setNota(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Nota de la materia 3: ");
                alum[c].materia3.setNota(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Nota de la materia 4: ");
                alum[c].materia4.setNota(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine();
            }

            Console.WriteLine("Presione <Enter> para ver los datos de los Alumnos. ");
            Console.ReadKey();
            Console.Clear();
            int n = 0;
            foreach (Alumno a in alum)
            {
                n++;
                Console.WriteLine("Datos del Alumno #{0}", n);
                Console.WriteLine("Carnet: {0}", a.carnet);
                Console.WriteLine("Nombre: {0}", a.nombreAlumno);
                Console.WriteLine("Carrera: {0}", a.carrera);

                Console.WriteLine("Materias APROBADAS O REPROBADAS");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Nota materia 1: {0}", a.materia1.getNota());
                Console.WriteLine("Materia 2: {0}", a.materia2.getNota());
                Console.WriteLine("Materia 3: {0}", a.materia3.getNota());
                Console.WriteLine("Materia 4: {0}", a.materia4.getNota());
            }
        }
    }
}
