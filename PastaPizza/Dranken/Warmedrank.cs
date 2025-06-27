namespace PastaPizza.Dranken;

public class Warmedrank: Drank
{
    public Warmedrank(DrankEnum.Drank drank)
    {
        NaamDrank = drank;
        Prijs = 2.5;
    }


    public double BerekenBedrag()
    {
        return base.BerekenBedrag();

    }
}