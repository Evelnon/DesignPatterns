using DesignPatterns.Entities.Races;
using DesignPatterns.Interfaces;


public class Orc : IRaceType
{

    IRace orc;
    public Orc()
	{
        orc = new Race(this);
        orc.LoadRaceStats(this);
    }
    public IRaceType GetRace()
    {
        return this;
    }

    public IRace GetRaceStats()
    {
        return orc;
    }

    public IRace LoadStats(Race orc)
    {

        /* database call for stats*/


        orc.SetRaceHP(20);
        orc.SetRaceMP(20);
        orc.SetRaceStrength(45);
        return orc;
    }

}
