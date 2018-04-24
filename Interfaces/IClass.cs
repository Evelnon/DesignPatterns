using DesignPatterns.Entities.Skills;
using DesignPatterns.Entities.Spells;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interfaces
{
    public interface IClass
    {
        List<Skill> GetClassSkills();
        void GetClassStatsModifiers();
        List<Spell> GetClassSpells();
    }
}
