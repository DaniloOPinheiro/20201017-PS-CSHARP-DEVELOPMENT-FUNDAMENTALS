﻿using System;

namespace Introduction
{
    class Program
    {
        public static void Main(string[] args)
        {
            Sumary.SumaryGeral.Persona(args);

            Sumary.SumaryGeral.Header("Introducing C# and .NET");

            Sumary.SumaryGeral.GetSummary(
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

            Console.ReadLine();
        }
    }
}
