using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interfaces
{
    public abstract class IRace
    {
        public abstract int GetRaceHP();
        public abstract int GetRaceMP();
        public abstract int GetRaceStrength();
        public abstract int GetRaceConstitution();
        public abstract int GetRaceAgility();
        public abstract int GetRaceInteligence();
        public abstract IRaceType GetRace();
        internal abstract void LoadRaceStats(IRaceType race);
        public abstract string GetEntityRaceDescription();
    }
}
