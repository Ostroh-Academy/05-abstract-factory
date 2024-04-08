using Laboratory5.Units.Api;

namespace Laboratory5.Units;

internal sealed class ArtilleryManUkrainian : ArtilleryMan
{
    public override void Shoot() =>
        Console.WriteLine("Shooting in the Ukrainian style.");
}