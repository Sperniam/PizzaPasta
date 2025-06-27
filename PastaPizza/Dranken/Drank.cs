using PastaPizza.Bestellingen;
using PastaPizza.Dranken.DrankEnum;

namespace PastaPizza.Dranken;

public abstract class Drank : IBedrag
{

    public DrankEnum.Drank NaamDrank { get; set; }

    public double Prijs { get; init; }

    public double BerekenBedrag()
    {
        return Prijs;
    }

    public override string ToString()
    {
        return $"Drank: {NaamDrank} ({Prijs} euro)";
    }
}