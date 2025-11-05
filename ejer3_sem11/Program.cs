using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer3_sem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] estudiantes = { "ELENA", "MARIO", "RICARDO", "JHON", "TINA", "GUILLE" };
            double[] promedios = { 20, 13, 15, 10, 08, 16 };

            Console.WriteLine("       Ingrese el nombre del estudiante a modificar su nota ");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Elena(20), Mario(13), Ricardo(15), Jhon(10), Tina(08), Guille(16)");
            Console.WriteLine("---------------------------------------------------------------------");
            string nombre = Console.ReadLine().ToUpper();

            int pos = Array.IndexOf(estudiantes, nombre);

            if (pos != -1)
            {
                double nuevoPromedio = -1;

                while (nuevoPromedio < 0 || nuevoPromedio > 20)
                {
                    Console.Write("\nIngrese el nuevo promedio (0-20): ");
                    nuevoPromedio = Convert.ToDouble(Console.ReadLine());

                    if (nuevoPromedio < 0 || nuevoPromedio > 20)
                    {
                        Console.WriteLine("Promedio no válido. Debe estar entre 0 y 20.");
                    }
                }

                promedios[pos] = nuevoPromedio;
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado.");
            }

            Console.WriteLine("\nLista actualizada:");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"{estudiantes[i]}: {promedios[i]}");
            }
        }
    }
}
