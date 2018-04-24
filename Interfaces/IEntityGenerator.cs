using DesignPatterns.Entities.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interfaces
{
   public interface IEntityGenerator
    {
        Entities.Entity GenerateEntity(IRace entityRace, IClass entityClass, IEntityType entityType);
        
    }
}
