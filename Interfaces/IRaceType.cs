using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Entities.Races;

namespace DesignPatterns.Interfaces
{
    public interface IRaceType
    {
         IRaceType GetRace();
        IRace GetRaceStats();
         IRace LoadStats(Race race);
    }
}
