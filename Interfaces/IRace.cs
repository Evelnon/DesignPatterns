using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interfaces
{
    public interface IRace
    {
        int GetRaceHP();
        int GetRaceMP();
        int GetRaceStrength();
        int GetRaceConstitution();
        int GetRaceAgility();
        int GetRaceInteligence();
        //System.Type GetRace();
        string GetEntityRaceDescription();
    }
}
