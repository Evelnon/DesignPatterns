using DesignPatterns.Entities.Races;
using DesignPatterns.Interfaces;
using System;

public class Human : Race
{


    
    public Human()
    {
        SetRaceHP(20);
        SetRaceMP(20);
        SetRaceStrength(25);
        SetEntityRaceDescription("Human");
    }
    public System.Type GetRace()
    {
        return typeof(Human);
    }
   
 
}
