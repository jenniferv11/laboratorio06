using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero maximo de personas: ");
            int max = int.Parse(Console.ReadLine());

            Console.Clear();

            int asistentes = 0;
            int perIng = 0;
            int perSal = 0;
            int lleno = 0;
            int vacio = 0;

            while (true)
            {
                float aforo = (float)asistentes/max * 100;
                Console.WriteLine("========================================");
                Console.WriteLine($"| Asistentes actuales  | "+asistentes);
                Console.WriteLine($"| Aforo                | "+aforo.ToString ("0")+"%");
                Console.WriteLine($"| Maximo               | "+ max +" personas");
                Console.WriteLine("========================================");
                Console.WriteLine("Presione [i] si ingresa una persona");
                Console.WriteLine("Presione [s] si sale una persona");
                Console.WriteLine("Presione [x] para terminar");

                char opcion = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (opcion)
                {
                    case 'i': 
                        if (asistentes <  max)
                        {
                            asistentes++;
                            perIng++;
                        }
                        else
                        {
                            Console.WriteLine("El local esta lleno.");
                            lleno++;
                        }
                        break;

                    case 's':
                        if (asistentes > 0)
                        {
                            asistentes--;
                            perSal++;
                        }
                        else
                        {
                            Console.WriteLine("El local esta vacio.");
                            vacio++;
                        }
                        break;

                    case 'x':
                        Console.Clear();
                        Console.WriteLine("=================================");
                        Console.WriteLine("El programa ha terminado.");
                        Console.WriteLine("=================================");

                        Console.WriteLine("Estadisticas:");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine(perIng + " personas ingresaron al local");
                        Console.WriteLine(perSal + " personas salieron");
                        Console.WriteLine(lleno + " veces se lleno el local");
                        Console.WriteLine("Estuvo vacio " + vacio + " veces");
                        break;
                }
            }
        }
    }
}
