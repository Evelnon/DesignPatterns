using DesignPatterns.Entities;
using DesignPatterns.Entities.Races;
using DesignPatterns.Interfaces;
using System.Collections.Generic;


namespace DesignPatterns
{
   public class EntityGenerator 
    {
        
        Entities.Entity entity;

        public Entities.Entity GenerateEntity(IRace entityRace, IClass entityClass, IEntityType entityType) {
            entity = new Entities.Entity(entityRace, entityClass, entityType);
            return entity;
        }
        
    }
}
