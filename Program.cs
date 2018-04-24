using DesignPatterns.Entities.Classes;
using DesignPatterns.Entities.Races;
using DesignPatterns.Entity.Type;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            EntityGenerator generator = new EntityGenerator();
            generator.GenerateEntity(new Orc(), new Warrior(), new Monster()); 
            //generator.GenerateEntity()
            //entityList.Add(EntityGenerator.)
           
            //Console.WriteLine(heroList[0].PrintHeroDetails());
            
        }
    }
}
