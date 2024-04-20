using System;

public delegate void AttackEventHandler(Mage attacker, Mage target);
public delegate void DefendEventHandler(Mage mage);

public abstract class Mage
{
    public event AttackEventHandler Attacked;
    public event DefendEventHandler Defended;

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

    protected virtual void OnAttacked(Mage target)
    {
        Attacked?.Invoke(this, target);
    }

    protected virtual void OnDefended()
    {
        Defended?.Invoke(this);
    }
}
