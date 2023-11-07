namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sword = new Weapon(type: "sword", damage: 15, range: 2);
            var character = new Character("Warrior", sword);
            character.Attack();

            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}