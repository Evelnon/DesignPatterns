using DesignPatterns.Interfaces;

namespace DesignPatterns.Entities.Races
{
    public class Race : IRace
    {
        private int strength;
        private int constitution;
        private int agility;
        private int inteligence;
        private int hp;
        private int mp;
        private string raceDescription;
        internal IRace race;
       

        public Race()
        {

        }
        public Race(IRace raceType)
        {           
            race = raceType;
        }

        public string GetEntityRaceDescription() { return raceDescription; }
        internal void SetEntityRaceDescription(string value) { raceDescription = value; }
        public int GetRaceHP() { return hp; }
        internal void SetRaceHP(int value) { hp = value; }
        public int GetRaceMP() { return mp; }
        internal void SetRaceMP(int value) { mp = value; }
        public int GetRaceStrength() { return strength; }
        internal void SetRaceStrength(int value) { strength = value; }
        public int GetRaceConstitution() { return constitution; }
        internal void SetRaceConstitution(int value) { constitution = value; }
        public int GetRaceAgility() { return agility; }
        internal void SetRaceAgility(int value) { agility = value; }
        public int GetRaceInteligence() { return inteligence; }
        internal void SetRaceInteligence(int value) { inteligence = value; }
        //public IRace GetEntityRaceStats() { return race; }
        //public System.Type GetRace()
        //{
            
        //    return typeof();
        //}
    }
}
