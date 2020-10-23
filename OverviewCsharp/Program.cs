using System;
using System.Threading.Tasks;

namespace OverviewCsharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Mostrar o sumário da aplicação abordada.
            controllers.Introduction.MainIntro(args);

            var mainsync = MainAsync(args);
            Task.FromResult(mainsync);
        }

        //C# 8.0 com Async
        public static async Task MainAsync(string[] args)
        {
            // await Console.Out.WriteAsync($"Hello Word em C# 8.0: {args[0]}");
            await controllers.Introduction.MainIntroAsync(args);
            // await Task.FromResult($"Hello Word com C# 8 {args[0]}");
        }
    }
}
