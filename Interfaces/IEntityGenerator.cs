using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interfaces
{
   public interface IEntityGenerator
    {
        void GenerateEntity(IRaceType entityRace, IClass entityClass, IEntityType entityType);
        Entities.Entity GetGeneratedEntity();
    }
}
