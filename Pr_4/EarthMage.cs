using System;

public class EarthMage : Mage, ISpell
{
    public EarthMage(string name, int magicLevel) : base(name, magicLevel) { }

    public void CastAttack()
    {
        Console.WriteLine($"{Name} uses earth storm!");
    }

    public void CastDefense()
    {
        Console.WriteLine($"{Name} summons an earth defensive barrier!");
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
