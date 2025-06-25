using PastaPizza.Bestellingen;
using PastaPizza.Dranken.DrankEnum;

namespace PastaPizza.Dranken;

public abstract class Drank : IBedrag
{

    public DrankEnum.Drank NaamDrank { get; set; }

    public double Prijs { get; set; }

    public abstract double BerekenBedrag();

    public override string ToString()
    {
        return $"Drank: {NaamDrank} ({Prijs} euro)";
    }
}