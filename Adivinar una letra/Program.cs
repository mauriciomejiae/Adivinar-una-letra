using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinar_una_letra
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch, respuesta = 'k';
            int i = 0;
            Console.WriteLine("Estoy pensando en una letra entre A y Z...");
            Console.WriteLine();

            do
            {
                Console.WriteLine();
                Console.Write("¿Puedes adivinarla?:");
                ch = (char)Console.Read();

                if (ch < respuesta)
                    Console.WriteLine("Muy Bajo....");

                else
                    if (ch > respuesta)
                    Console.WriteLine("Muy Alto...");

                else
                    Console.WriteLine("Adivinaste!!!!");
                Console.ReadLine();

            } while (ch != respuesta);
            Console.WriteLine();
            Console.WriteLine("Presiona una tecla para  cerrar...");
            Console.ReadKey();

        }
    }
}
