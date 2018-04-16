using DesignPatterns.Interfaces;
using System;

public class Mage : IClass
{
	public Mage()
	{  
        
    }
    public IClass GetClass()
    {
        return this;
    }
    public string GetHeroClassDescription()
    {
        return "Mage";
    }
}
