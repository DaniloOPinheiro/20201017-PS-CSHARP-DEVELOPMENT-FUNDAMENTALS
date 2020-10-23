using System;
using System.Threading.Tasks;

namespace OverviewCsharp.route
{
    public class Summary
    {
        public static void Persona(string[] args)
        {
            // Obs: Você precisa informar seu nome no args do appsetting(launch).
            if (args.Length > 0)
               Header($"Responsável pela Aplicação Console: {args[0]}");
               Console.WriteLine("-----------------------------------");
               Console.Write("\n");
        }

        public static void GetSummmary(params object[] summary)
        {
            for (int i = 0; i < summary.Length; i++)
            {
                Console.WriteLine(summary[i] + "");
            }
        }

        public static void Header(string title)
        {
            Console.WriteLine("********** " + title + " **********");
        }

        //C# 8.0 com Async
        public static async Task PersonaAsync(string[] args)
        {
            // Obs: Você precisa informar seu nome no args do appsetting(launch).
            if (args.Length > 0)
            {
               await HeaderAsync($"Responsável pela Aplicação Console: {args[0]}");
            }
            await Console.Out.WriteLineAsync("-----------------------------------");
            await Console.Out.WriteAsync("\n");
        }

        public static async Task GetSummmaryAsync(params object[] summary)
        {
            for (int i = 0; i < summary.Length; i++)
            {
                await Console.Out.WriteLineAsync(summary[i] + "");
            }
        }

        public static async Task HeaderAsync(string title)
        {
            await Console.Out.WriteLineAsync("********** " + title + " **********");
        }

    }
}