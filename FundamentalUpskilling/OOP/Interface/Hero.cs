namespace FundamentalUpskilling.OOP.Interface;

public class Hero : IHitAble
{
    // object interaction

    public string Name { get; set; }
    public int HP { get; set; }
    public int BaseDamage { get; set; }
    
    // create method to Attack hero
    // public void Attack(Hero hero)
    // {
    //     Console.WriteLine($"Hero {Name} attack {hero.Name}");
    //     hero.GetHit(BaseDamage);
    // }
    
    /*
     * polymorphism = poly, morphism -> banyak bentuk
     * overload = membuat 2 buah method dengan nama yang sama, tetapi parameter/tipe datanya berbeda
     * override = menulis ulang sebuah method pada child yang sudah dibuat di parent class
     */

    // public void Attack(Monster monster)
    // {
    //     monster.GetHit(BaseDamage);
    // }
    
    // implement method Attack
    
    

    // implement method from parent
    // Interface bisa dijadikan tipe data
    public void Attack(IHitAble hitAble)
    {
        hitAble.GetHit(BaseDamage);
    }
    

    public void GetHit(int damage)
    {
        HP -= damage;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        /*
         * Hero Attack hero
         *         // var midoriya = new Hero
           // {
           //     Name = "Midoriya Izuku",
           //     HP = 2000,
           //     BaseDamage = 450
           // };
           //
           // var todoroki = new Hero
           // {
           //     Name = "Todoroki Shoto",
           //     HP = 1800,
           //     BaseDamage = 370
           // };
           //
           // midoriya.Attack(todoroki);
           // Console.WriteLine(todoroki.HP);
         */
        
        /*
         * Hero Attack Monster
         */
        var midoriya = new Hero
        {
            Name = "Midoriya Izuku",
            HP = 2000,
            BaseDamage = 450
        };

        var shigaraki = new Monster
        {
            Name = "Shigaraki Tomura",
            HP = 3000,
            BaseDamage = 600
        };
        
        midoriya.Attack(shigaraki);
        shigaraki.Attack(midoriya);
        Console.WriteLine(shigaraki.HP);
        Console.WriteLine(midoriya.HP);
    }
}