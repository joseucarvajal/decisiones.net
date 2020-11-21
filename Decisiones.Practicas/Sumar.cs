using System;
using System.Collections.Generic;
using System.Text;

namespace Decisiones.Practicas
{
    public class Sumar
    {
        public void SumarYMostrarResultado()
        {
            Console.WriteLine("Escriba el numero 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el numero 2: ");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = RealizarSuma(n1, n2);
            MostrarResultado(resultado);
        }

        private int RealizarSuma(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }

        private void MostrarResultado(int resultado)
        {
            if (resultado < 0)
            {
                Console.WriteLine("El resultado es negativo");
            }
            else if (resultado > 0)
            {
                Console.WriteLine("El resultado es positivo");
            }
            else
            {
                Console.WriteLine("El resultado es cero");
            }
        }

    }
}
