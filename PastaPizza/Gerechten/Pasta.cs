namespace PastaPizza;

public class Pasta : Gerecht
{

    public string Omschrijving { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }

    public override double BerekenBedrag()
    {
        return Prijs;
    }
}