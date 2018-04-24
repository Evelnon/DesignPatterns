using DesignPatterns.Entities.Classes;
using DesignPatterns.Interfaces;
using System;

public class Warrior : Class
{
	public Warrior()
	{
       
    }
    public System.Type GetClass()
    {
        return typeof(Warrior);
    }

    public string GetHeroClassDescription()
    {
        return "Warrior";
    }
    public void SetClassDetails() { }
}
