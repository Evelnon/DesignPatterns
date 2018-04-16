using DesignPatterns.Entities.Races;
using DesignPatterns.Interfaces;
using System;

public class Human : IRaceType
{


    IRace human;
    public Human()
    {
        human = new Race(this);
        human.LoadRaceStats(this);
    }
    public IRaceType GetRace()
    {
        return this;
    }
    public IRace GetRaceStats()
    {
        return human;
    }
    public IRace LoadStats(Race human)
    {
        /* database call for stats*/


        human.SetRaceHP(20);
        human.SetRaceMP(20);
        human.SetRaceStrength(25);  
        return human;
    }
}
