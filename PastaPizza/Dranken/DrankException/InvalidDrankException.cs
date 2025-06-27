using System.Runtime.Serialization;

namespace PastaPizza.Dranken;
using DrankEnum;

public class InvalidDrankException : Exception
{

    public Drank Drank { get; set; }

    public InvalidDrankException()
    {
    }

    protected InvalidDrankException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public InvalidDrankException(string? message) : base(message)
    {
    }

    public InvalidDrankException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

   
    
    public string SoortDrank(DrankEnum.Drank drank)
    {
       
            if (drank != DrankEnum.Drank.Cocacola && drank != DrankEnum.Drank.Limonade &&
                drank != DrankEnum.Drank.Water)
            {
                throw new InvalidDrankException($"De drank '{drank}' is ongeldig. Want het is geen frisdrank");
            }
            else throw new InvalidDrankException($"De drank '{drank}' is ongeldig. Want het is geen WarmeDrank");

        }
    
}