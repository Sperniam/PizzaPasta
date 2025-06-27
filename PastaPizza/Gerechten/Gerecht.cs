using PastaPizza.Bestellingen;

namespace PastaPizza.Gerechten;

public abstract class Gerecht : IBedrag
{
  

    public string Naam { get; set; }

    public double Prijs { get; set; }
    

    public override string ToString()
    {
        return $"{Naam} ({Prijs.ToString("#.00")} euro)";
    }

    public abstract double BerekenBedrag();

}