using System;
using System.Collections.Generic;
using System.Text;

namespace Decisiones.Practicas
{
    public class MostrarNums1AN
    {
        public void MostrarConWhile()
        {
            int n = PedirNumero();
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("i="+i);
                i++;
            }
        }

        public void MostrarConFor()
        {
            int n = PedirNumero();
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("i="+i);
            }
        }

        public int PedirNumero()
        {
            Console.WriteLine("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            return numero;
        }
    }
}
