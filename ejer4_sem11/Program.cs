using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4_sem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] estudiantes = { "ELENA", "MARIO", "RICARDO", "JHON", "TINA", "GUILER" };
            double[] promedio = { 20, 13, 15, 10, 08, 16 };

            Console.WriteLine("             Ingrese el nombre del estudiante a eliminar ");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Elena(20), Mario(13), Ricardo(15), Jhon(10), Tina(08), Guille(16)");
            Console.WriteLine("---------------------------------------------------------------------");
            string nombre = Console.ReadLine().ToUpper();


            int pos = Array.IndexOf(estudiantes, nombre);

            if (pos == -1)
            {
                Console.WriteLine("El estudiante no fue encontrado.");
            }
            else
            {

                for (int i = pos; i < estudiantes.Length - 1; i++)
                {
                    estudiantes[i] = estudiantes[i + 1];
                    promedio[i] = promedio[i + 1];
                }


                estudiantes[estudiantes.Length - 1] = "";
                promedio[promedio.Length - 1] = 0;

                Console.WriteLine("\nEstudiante eliminado correctamente.");
            }


            Console.WriteLine("\nLista actualizada de estudiantes:");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                if (estudiantes[i] != "")
                {
                    Console.WriteLine($"{estudiantes[i]} - Promedio: {promedio[i]}");
                }
            }
        }
    }
}
