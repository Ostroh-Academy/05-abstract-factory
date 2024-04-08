using Laboratory5.Units.Api;

namespace Laboratory5.Units;

internal sealed class ArtilleryManNato : ArtilleryMan
{
    public override void Shoot() =>
        Console.WriteLine("Shooting in the Nato style.");
}