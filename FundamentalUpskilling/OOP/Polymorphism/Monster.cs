using System.ComponentModel.Design.Serialization;

namespace FundamentalUpskilling.OOP.Polymorphism;

public class Monster
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int BaseDamage { get; set; }

    public void Attack(Monster monster)
    {
        Console.WriteLine($"Monster {Name} menyerang {monster.Name}");
        monster.GetHit(BaseDamage);
    }

    public void Attack(Hero hero)
    {
        Console.WriteLine($"Monster {Name} menyerang Hero {hero.Name}");
        hero.GetHit(BaseDamage);
    }

    public void GetHit(int damage)
    {
        Console.WriteLine($"{Name} menerima damage : {damage}");
        HP -= damage;
    }
}