using Laboratory5.Training.Api;

namespace Laboratory5.Training;

/// <summary>
/// Конкретна реалізація навчальної програми для НАТО
/// </summary>
internal sealed class NatoTrainingProgram : TrainingProgram
{
    public override ArtilleryMan CreateArtilleryMan()
    {
        Console.WriteLine("Starting NATO training program...");
        StudyTheory();
        HandleEquipment();
        TakeExams();
        Console.WriteLine("NATO training program completed.");
        return new ArtilleryManNato();
    }

    private void StudyTheory() =>
        Console.WriteLine("Studying theoretical materials according to NATO standards...");

    private void HandleEquipment() =>
        Console.WriteLine("Practicing handling NATO equipment...");

    private void TakeExams() =>
        Console.WriteLine("Taking exams to demonstrate proficiency in NATO standards...");
}