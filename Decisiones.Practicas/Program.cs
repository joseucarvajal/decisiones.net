using System;

namespace Decisiones.Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sumar dos números");
            Console.WriteLine("2. Ciclo con while");
            Console.WriteLine("3. Ciclo con for");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    SumarDosNums();
                    break;

                case 2:
                    MostrarNumeros1ANWhile();
                    break;

                default:
                    MostrarNumeros1ANFor();
                    break;
            }
            
            Console.ReadLine();
        }

        public static void MostrarNumeros1ANWhile()
        {
            MostrarNums1AN m1 = new MostrarNums1AN();
            m1.MostrarConWhile();
        }

        public static void MostrarNumeros1ANFor()
        {
            MostrarNums1AN m1 = new MostrarNums1AN();
            m1.MostrarConFor();
        }

        public static void SumarDosNums()
        {
            Sumar s1 = new Sumar();
            s1.SumarYMostrarResultado();
            s1.SumarYMostrarResultado();
            s1.SumarYMostrarResultado();
        }

       
    }
}
