using System;

public class FireMage : Mage, ISpell
{
    public FireMage(string name, int magicLevel) : base(name, magicLevel) { }

    public void CastAttack()
    {
        Console.WriteLine($"{Name} casts fireball!");
    }

    public void CastDefense()
    {
        Console.WriteLine($"{Name} creates a wall of fire for defense!");
    }

    public override void Attack(Mage target)
    {
        CastAttack();
        OnAttacked(target);
    }

    public override void Defend()
    {
        CastDefense();
        OnDefended();
    }
}
