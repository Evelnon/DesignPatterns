using DesignPatterns.Entities.Skills;
using DesignPatterns.Entities.Spells;
using DesignPatterns.Interfaces;
using System.Collections.Generic;

namespace DesignPatterns.Entities.Classes
{
    public class Class : IClass
    {
        private IClass entityClass;
        public Class()
        {
        
        }
        public Class(IClass classType)
        {
            entityClass = classType;
        }
        public List<Skill> GetClassSkills() {
            return new List<Skill>();
        }
        public void GetClassStatsModifiers() { }
        public List<Spell> GetClassSpells(){
            return new List<Spell>();
        }
    }
}
