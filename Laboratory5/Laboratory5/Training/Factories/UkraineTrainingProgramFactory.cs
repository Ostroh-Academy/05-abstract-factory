using Laboratory5.Training.Api;
using Laboratory5.Training.Factories.Api;

namespace Laboratory5.Training.Factories;

/// <summary>
/// Фабрика для створення навчальних програм для України
/// </summary>
internal sealed class UkraineTrainingProgramFactory : TrainingProgramFactory
{
    public override TrainingProgram CreateTrainingProgram() =>
        new UkraineTrainingProgram();
}