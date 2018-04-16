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
        private IRaceType raceType;

        public Race()
        {
           
        }
        public Race(IRaceType raceType)
        {
            this.raceType = raceType;
            LoadRaceStats(raceType);
        }
        public override IRaceType GetRace()
        {
            return this.raceType;
        }
        public override string GetEntityRaceDescription() { return raceDescription; }
        public override int GetRaceHP() { return hp; }
        internal void SetRaceHP(int value) { hp = value ; }
        public override int GetRaceMP() { return mp; }
        internal void SetRaceMP(int value) { mp = value; }
        public override int GetRaceStrength() { return strength; }
        internal void SetRaceStrength(int value) { strength = value; }
        public override int GetRaceConstitution() { return constitution; }
        public override int GetRaceAgility() { return agility; }
        public override int GetRaceInteligence() { return inteligence; }
        internal override void LoadRaceStats(IRaceType race)
        {
           race.LoadStats(this);
                  
        }
    }
}
