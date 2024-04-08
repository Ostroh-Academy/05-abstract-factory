using Laboratory5.Training.Api;

namespace Laboratory5.Training;

/// <summary>
/// Конкретна реалізація навчальної програми для України
/// </summary>
internal sealed class UkraineTrainingProgram : TrainingProgram
{
    public override ArtilleryMan CreateArtilleryMan()
    {
        Console.WriteLine("Starting Ukrainian training program...");
        StudyTheory();
        HandleEquipment();
        TakeExams();
        Console.WriteLine("Ukrainian training program completed.");
        return new ArtilleryManUkrainian();
    }

    private void StudyTheory() =>
        Console.WriteLine("Studying theoretical materials according to Ukrainian standards...");

    private void HandleEquipment() =>
        Console.WriteLine("Practicing handling Ukrainian equipment...");

    private void TakeExams() =>
        Console.WriteLine("Taking exams to demonstrate proficiency in Ukrainian standards...");
}