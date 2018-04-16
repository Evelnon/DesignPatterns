using DesignPatterns.Entities;
using DesignPatterns.Interfaces;
using System.Collections.Generic;


namespace DesignPatterns
{
   public class EntityGenerator : IEntityGenerator
    {
        
        Entities.Entity entity;

        public void GenerateEntity(IRaceType entityRace, IClass entityClass, IEntityType entityType) {
            entity = new Entities.Entity(entityRace, entityClass, entityType);
        }
        public Entities.Entity GetGeneratedEntity() {
            return entity;
        }
    }
}
