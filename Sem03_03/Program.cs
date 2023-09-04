using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem03_03
{
    internal class Program
    {
        static void Main(string[] args)
        {        // Solicitar al usuario la edad y la cantidad de adivinanzas acertadas
            Console.WriteLine("Ingrese la edad del ganador:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de adivinanzas acertadas:");
            int adivinanzasAcertadas = int.Parse(Console.ReadLine());

            // Definir el monto inicial según la edad y la cantidad de adivinanzas acertadas
            double montoInicial = 0;

            if (edad >= 18) // Mayor de edad
            {
                if (adivinanzasAcertadas < 3)
                {
                    montoInicial = 30;
                }
                else
                {
                    montoInicial = 50;
                }
            }
            else // Menor de edad
            {
                if (adivinanzasAcertadas < 3)
                {
                    montoInicial = 30;
                }
                else
                {
                    montoInicial = 50;
                }
            }

            // Calcular el monto extra
            double montoExtra = (5 * edad) + (2 * adivinanzasAcertadas);

            // Calcular el monto total final
            double montoTotal = montoInicial + montoExtra;

            // Mostrar el resultado
            Console.WriteLine("El monto final que el ganador recibe como premio es: S/ " + montoTotal);
        }
    }

}
    

