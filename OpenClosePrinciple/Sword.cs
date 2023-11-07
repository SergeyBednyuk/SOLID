using System;

public class Sword : Weapon
{
    public Sword(int damage, int range)
        :base(type: "sword", damage, range)
    {
            
    }

    public override void Attack()
    {
        Console.WriteLine($"attack of sword deal {Damage} damage at {Range} range");
    }
}
