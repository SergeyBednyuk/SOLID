using System;

public class Weapon : Attacker
{
    public string type { get; set; }

    public int Damage { get; set; }

    public int Range { get; set; }

    public Weapon(string type, int damage, int range)
	{
        this.type = type;
        this.Damage = damage;
        this.Range = range;
	}

    public virtual void Attack()
    {
        //Bad practice
        //if (this.type == "sword")
        //{
        //    Console.WriteLine($"attack of sword deal {Damage} damage");
        //}
        //else if(this.type == "crossbow")
        //{
        //    Console.WriteLine($"attack of crossbow deal {Damage} damage");
        //}
    }
}
