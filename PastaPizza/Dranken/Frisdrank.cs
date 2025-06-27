namespace PastaPizza.Dranken;

public class Frisdrank : Drank
{
    
    public Frisdrank(DrankEnum.Drank drank)
    {
        NaamDrank = drank;
        Prijs = 2
            ;
    }



    public double BerekenBedrag()
    {
      return base.BerekenBedrag();
    }
}