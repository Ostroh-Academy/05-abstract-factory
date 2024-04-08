using Laboratory5.Training.Api;

namespace Laboratory5.Training.Factories.Api;

/// <summary>
/// Абстрактна фабрика для творення навчальних програм
/// </summary>
internal abstract class TrainingProgramFactory
{
    public abstract TrainingProgram CreateTrainingProgram();
}