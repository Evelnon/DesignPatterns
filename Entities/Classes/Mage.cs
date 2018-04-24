using DesignPatterns.Entities.Classes;
using DesignPatterns.Interfaces;
using System;

public class Mage : Class
{
	public Mage()
	{  
        
    }
    public System.Type GetClass()
    {
        return typeof(Mage);
    }
    public string GetHeroClassDescription()
    {
        return "Mage";
    }
    public void SetClassDetails() { }
}
