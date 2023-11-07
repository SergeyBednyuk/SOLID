using System;

public class Character
{
    public string Name { get; set; }

    public Weapon Weapon { get; set; }

    public Character(string name, Weapon weapon)
	{
        this.Name = name;
        this.Weapon = weapon;
	}

    public void ChangeWeapon(Weapon weapon)
    {
        this.Weapon = weapon;
    }

    public void Attack()
    {
        this.Weapon.Attack();
    }
}
