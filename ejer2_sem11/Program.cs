using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2_sem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a_producto = new string[10];
            string nom_producto;
            int producto_r;

            Console.Write("BIENVNIDO ACA PODRA INGRESAR EL NOMBRE DE 10 PRODUCTOS\n");

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    producto_r = 0;
                    Console.Write("\nIngrese nombre del producto {0}: ", i + 1);
                    nom_producto = Console.ReadLine().ToUpper();

                    if (i == 0)
                    {
                        a_producto[i] = nom_producto;
                    }

                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (a_producto[j] == nom_producto)
                            {
                                Console.WriteLine("El nombre del producto se a repetido");
                                producto_r = 1;
                            }
                        }

                        if (producto_r == 0)
                        {
                            a_producto[i] = nom_producto;
                        }
                    }

                } while (producto_r != 0);
            }
        }
    }
}
