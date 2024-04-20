using System;

class Program
{
    static void Main(string[] args)
    {
        Mage mage1 = new FireMage("Pythagoras", 10);
        Mage mage2 = new WaterMage("Theophania", 8);

        mage1.Attacked += OnMageAttacked;
        mage2.Attacked += OnMageAttacked;

        mage1.Defended += OnMageDefended;
        mage2.Defended += OnMageDefended;

        while (mage1.Health > 0 && mage2.Health > 0)
        {
            mage1.Attack(mage2);
            mage2.Defend();

            mage2.Attack(mage1);
            mage1.Defend();
        }

        if (mage1.Health <= 0 && mage2.Health <= 0)
            Console.WriteLine("Draw!");
        else if (mage1.Health <= 0)
            Console.WriteLine($"{mage2.Name} wins!");
        else
            Console.WriteLine($"{mage1.Name} wins!");

        Console.ReadLine();
    }

    static void OnMageAttacked(Mage attacker, Mage target)
    {
        Console.WriteLine($"{target.Name} is attacked by {attacker.Name}!");
    }

    static void OnMageDefended(Mage mage)
    {
        Console.WriteLine($"{mage.Name} defended!");
    }
}
