using DesignPatterns.Interfaces;
using System;

public class Warrior : IClass
{
	public Warrior()
	{
       
    }
    public IClass GetClass()
    {
        return this;
    }

    public string GetHeroClassDescription()
    {
        return "Warrior";
    }
}
