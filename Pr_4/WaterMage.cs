using System;

public class WaterMage : Mage, ISpell
{
    public WaterMage(string name, int magicLevel) : base(name, magicLevel) { }

    public void CastAttack()
    {
        Console.WriteLine($"{Name} summons a water stream!");
    }

    public void CastDefense()
    {
        Console.WriteLine($"{Name} creates a watery shield for defense!");
    }

    public override void Attack(Mage target)
    {
        CastAttack();
    }

    public override void Defend()
    {
        CastDefense();
    }
}
