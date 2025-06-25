using PastaPizza.Bestellingen;

namespace PastaPizza;

public abstract class Gerecht : IBedrag
{
  

    public string Naam { get; set; }

    public double Prijs { get; set; }


    public override string ToString()
    {
        return "";
    }

    public abstract double BerekenBedrag();

}