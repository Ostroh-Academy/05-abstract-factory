using Laboratory5.Training.Api;
using Laboratory5.Training.Factories.Api;

namespace Laboratory5.Training.Factories;

/// <summary>
/// Фабрика для створення навчальних програм для НАТО
/// </summary>
internal class NatoTrainingProgramFactory : TrainingProgramFactory
{
    public override TrainingProgram CreateTrainingProgram() =>
        new NatoTrainingProgram();
}