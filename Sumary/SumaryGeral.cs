using System;

namespace Sumary
{
    public class SumaryGeral
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
        public static void Persona(string[] args)
        {
            // Obs: Você precisa informar seu nome no args do appsetting(launch).
             if (args.Length > 0)
                Header($"Responsável pela Aplicação Console: {args[0]}");
                Console.WriteLine("-----------------------------------");
                Console.Write("\n");
        }

        public static void GetSumary(params object[] sumary)
        {
            for (int i = 0; i < sumary.Length; i++)
            {
                Console.WriteLine(sumary[i] + "");
            }
        }

        public static void Header(string title)
        {
            Console.WriteLine("********** " + title + " **********");
        }
    }
}
