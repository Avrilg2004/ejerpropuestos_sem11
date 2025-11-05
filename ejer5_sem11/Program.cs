using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer5_sem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] registrar_d = new int[10];
            string[] registrar_n = new string[10];
            int[] registrar_t = new int[10];
            int contador = 0;
            int repetido;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("         AGENDA DE NEGOCIO - CLIENTE");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("[1] - Registrar Nuevo Cliente");
                Console.WriteLine("[2] - Modificar Cliente");
                Console.WriteLine("[3] - Listar Clientes");
                Console.WriteLine("[4] - Salir");
                Console.WriteLine("-----------------------------------------------------");
                Console.Write("Ingrese una opción: ");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        if (contador >= 10)
                        {
                            Console.WriteLine("Ya no se pueden registrar más clientes (límite 10).");
                            Console.ReadKey();
                            break;
                        }

                        do
                        {
                            repetido = 0;

                            Console.Write("\nIngrese su DNI: ");
                            int dni = int.Parse(Console.ReadLine());

                            Console.Write("Ingrese su nombre: ");
                            string nombre = Console.ReadLine();

                            Console.Write("Ingrese su teléfono: ");
                            int telefono = int.Parse(Console.ReadLine());

                            for (int j = 0; j < contador; j++)
                            {
                                if (registrar_d[j] == dni)
                                {
                                    Console.WriteLine("ERROR: DNI ya registrado.");
                                    repetido = 1;
                                }
                                if (registrar_t[j] == telefono)
                                {
                                    Console.WriteLine("ERROR: Teléfono ya registrado.");
                                    repetido = 1;
                                }
                            }

                            if (repetido == 0)
                            {
                                registrar_d[contador] = dni;
                                registrar_n[contador] = nombre;
                                registrar_t[contador] = telefono;
                                contador++;
                                Console.WriteLine("Registro correcto.");
                            }

                        } while (repetido != 0);

                        Console.WriteLine("\nPresione una tecla para volver al menú");
                        Console.ReadKey();

                        break;


                    case 2:
                        Console.Clear();
                        Console.Write("Ingrese el DNI del cliente a modificar: ");
                        int dni_buscar = int.Parse(Console.ReadLine());

                        int pos = Array.IndexOf(registrar_d, dni_buscar, 0, contador);

                        if (pos == -1)
                        {
                            Console.WriteLine("Cliente no encontrado.");
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("         ¿Qué desea modificar?");
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("[1] - DNI del cliente");
                            Console.WriteLine("[2] - Nombre del cliente");
                            Console.WriteLine("[3] - Teléfono del cliente");
                            Console.WriteLine("--------------------------------------------");
                            Console.Write("Ingrese una opción: ");
                            int opc2 = int.Parse(Console.ReadLine());

                            switch (opc2)
                            {
                                case 1:
                                    Console.Write("Ingrese el nuevo DNI: ");
                                    registrar_d[pos] = int.Parse(Console.ReadLine());
                                    Console.WriteLine("DNI modificado correctamente.");
                                    break;

                                case 2:
                                    Console.Write("Ingrese el nuevo nombre: ");
                                    registrar_n[pos] = Console.ReadLine();
                                    Console.WriteLine("Nombre modificado correctamente.");
                                    break;

                                case 3:
                                    Console.Write("Ingrese el nuevo teléfono: ");
                                    registrar_t[pos] = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Teléfono modificado correctamente.");
                                    break;

                                default:
                                    Console.WriteLine("Opción no válida.");
                                    break;
                            }
                        }
                        Console.WriteLine("\nPresione una tecla para volver al menú");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        if (contador == 0)
                        {
                            Console.WriteLine("No hay clientes registrados");
                        }
                        else
                        {
                            Console.WriteLine("\nLista de clientes registrados: ");
                            for (int i = 0; i < contador; i++)
                            {
                                Console.WriteLine($"{registrar_d[i]} - {registrar_n[i]} - {registrar_t[i]}");
                            }
                        }

                        Console.WriteLine("\nPresione una tecla para volver al menú");
                        Console.ReadKey();

                        break;


                    case 4:
                        Console.Clear();
                        Console.WriteLine("Saliendo del sistema");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
    
}
