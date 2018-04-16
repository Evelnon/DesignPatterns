using DesignPatterns;
using DesignPatterns.Entities;
using DesignPatterns.Interfaces;
using NUnit.Framework;

namespace DesignPatternNUnit
{
    [TestFixture]
    class EntityGeneratorTests
    {
        

        [Test]
        public void WhenOrcGenerated_Str45()
        {
            
            EntityGenerator entityGenerator = new EntityGenerator();
            entityGenerator.GenerateEntity(new Orc(), new Warrior(), new Hero());
            Entity entity = entityGenerator.GetGeneratedEntity();            
            Assert.AreEqual(45, entity.GetEntityRace().GetRaceStats().GetRaceStrength());
        }
    }
}
