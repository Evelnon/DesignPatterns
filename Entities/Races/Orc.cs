using DesignPatterns.Entities.Races;
using DesignPatterns.Interfaces;


public class Orc : Race
{

    
    public Orc()
	{
        SetRaceHP(20);
        SetRaceMP(20);
        SetRaceStrength(45);
        SetEntityRaceDescription("Orc");

    }
    public System.Type GetRace()
    {
        return typeof(Orc);
    }   
   


}
