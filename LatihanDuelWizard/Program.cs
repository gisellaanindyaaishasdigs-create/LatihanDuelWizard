public class Wizard
{
    //deklarasi fied
    public string Name;
    public int Energy;
    public int Damage;

    //constructor
    public Wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }

    //deklarasi method
    public void ShowStats()
    {
        Console.WriteLine(($"Name: {Name}"));
        Console.WriteLine($"Energy:{Energy}\n");
    }

    public void Attack(Wizard enemyObj)
    {
        enemyObj.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang {enemyObj.Name}");
        Console.WriteLine($"Sisa energi {enemyObj.Name} {enemyObj.Energy}\n");
    }

}