using ConsoleTools;
using Laboratory5.Training.Api;
using Laboratory5.Training.Factories;
using Laboratory5.Training.Factories.Api;
using Laboratory5.Units.Api;

namespace Laboratory5;

using System;

internal static class Program
{
    private static void Main() =>
        new ConsoleMenu()
            .Add("Create Ukrainian soldier", () => InitializeSoldier(new UkraineTrainingProgramFactory()))
            .Add("Create NATO soldier", () => InitializeSoldier(new NatoTrainingProgramFactory()))
            .Add("Exit", () => Environment.Exit(0))
            .Configure(config =>
            {
                config.Title = "Choose a soldier to train";
                config.SelectedItemBackgroundColor = ConsoleColor.Green;
            })
            .Show();

    private static void InitializeSoldier(TrainingProgramFactory factory)
    {
        TrainingProgram program = factory.CreateTrainingProgram();
        ArtilleryMan artilleryMan = program.CreateArtilleryMan();
        artilleryMan.Shoot();
        Console.ReadLine();
    }
}