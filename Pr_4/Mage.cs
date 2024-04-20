using System;

public abstract class Mage
{
    protected string name;
    protected int magicLevel;
    protected int health;

    public Mage(string name, int magicLevel)
    {
        this.name = name;
        this.magicLevel = magicLevel;
        this.health = 100;
    }

    public string Name => name;

    public int MagicLevel => magicLevel;

    public int Health => health;

    public abstract void Attack(Mage target);

    public abstract void Defend();
}
