using System;
using System.Threading.Tasks;

namespace OverviewCsharp.controllers
{
    public class Introduction
    {
        public static void MainIntro(string[] args)
        {
            route.Summary.Persona(args);
            // Summary.Program.Persona(args);
            route.Summary.Header("Introducing C# and .NET");

            route.Summary.GetSummmary(
                              "Introduction",
                              "Downloading .NET for Windo",
                              "Understanding .NET and .NET",
                              "Understanding the .NET Runti",
                              "Using the .NET Command Line",
                              "Creating the First Ci Project",
                              "Editing cs code with visual",
                              "Running and Building Your",
                              "Saying Hello with Csharp",
                              "Debugging a Cf Application"
                            );
            // Console.ReadLine();
        }

        //C# 8.0 com Async
        public static async Task MainIntroAsync(string[] args)
        {
            await route.Summary.PersonaAsync(args);

            await route.Summary.HeaderAsync("Introducing C# 8.0 (Async + Await com Task) and .NET");

            await route.Summary.GetSummmaryAsync(
                              "Introduction",
                              "Downloading .NET for Windo",
                              "Understanding .NET and .NET",
                              "Understanding the .NET Runti",
                              "Using the .NET Command Line",
                              "Creating the First Ci Project",
                              "Editing cs code with visual",
                              "Running and Building Your",
                              "Saying Hello with Csharp",
                              "Debugging a Cf Application"
                            );
            // Console.ReadLine();
        }
    }
}
