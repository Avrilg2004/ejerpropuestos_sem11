using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1_sem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] PrecioProducto = new double[5];
            int[] Cantidad = new int[5];
            int contadorP, contadorC;
            Console.WriteLine("------------------ HOLI BIENVENIDO ------------------");

            Console.WriteLine("\nINGRESE LOS PRECIOS DE 5 PRODUCTOS.");

            for (contadorP = 0; contadorP < 5; contadorP++)
            {
                do
                {
                    Console.Write("\nIngrese el precio del producto " + (contadorP + 1) + ":  ");
                    PrecioProducto[contadorP] = Convert.ToDouble(Console.ReadLine());
                    if (PrecioProducto[contadorP] > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ERROR, ingrese cantidades positivas");
                    }
                } while (true);
            }

            Console.WriteLine("\nAHORA INGRESE SUS RESPECTIVAS CANTIDADES.");

            for (contadorC = 0; contadorC < 5; contadorC++)
            {
                do
                {

                    Console.Write("\nIngrese las cantidad " + (contadorC + 1) + ":  ");
                    Cantidad[contadorC] = Convert.ToInt32(Console.ReadLine());
                    if (Cantidad[contadorC] > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ERROR, ingrese cantidades positivas");
                    }
                } while (true);

            }

            Console.WriteLine("\nMULTIPLICACION DEL PRECIO Y SU RESPECTIVA CANTIDAD");

            for (contadorP = 0; contadorP < 5; contadorP++)
            {
                double multiplica = PrecioProducto[contadorP] * Cantidad[contadorP];
                Console.WriteLine("\nMultiplicación  " + (contadorP + 1) + ":  " + multiplica);
            }
        }
    }
}
