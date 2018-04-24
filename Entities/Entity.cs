using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Entities.Races;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Entities
{
    public class Entity
    {
        private IRace entityRace;
        private IClass entityClass;
        private IEntityType entityType;
        

        public Entity(IRace entityRace, IClass entityClass, IEntityType entityType)
        {
            this.entityRace = entityRace;
            this.entityClass = entityClass;
            this.entityType = entityType;
        }

        public IRace GetEntityRace()
        {
            return entityRace; 
        }
        public IClass GetEntityClass()
        {
            return entityClass;
        }
        public IEntityType GetEntityType()
        {
            return entityType;
        }
    }
}
