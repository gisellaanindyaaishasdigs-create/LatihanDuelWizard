
using System.Xml.Linq;

Wizard wizardA = new Wizard("Mak Lampir", 5);
Wizard wizardB = new Wizard("Nirmala", 10);

while (true)
{
    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} melakukan Heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan Heal");

    Console.Write("\nPilihan (1,2,3,4): ");
    pilihan = Console.ReadLine();

    if (pilihan == "1") wizardA.Attack(wizardB);
    else if (pilihan == "2") wizardB.Attack(wizardA);
    else if (pilihan == "3") wizardA.Heal();
    else if (pilihan == "4") wizardB.Heal();
    else Console.WriteLine("Pilihan tidak valid");

    if (wizardA.Energy <= 0)
    {
        Console.WriteLine($"{wizardA.Name} kalah!");
        Console.WriteLine($"{wizardB.Name} menang!");
        break;
    }
    else if (wizardB.Energy <= 0)
    {
        Console.WriteLine($"{wizardB.Name} kalah!");
        Console.WriteLine($"{wizardA.Name} menang!");
        break;
    }
}
    }
}

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

    string pilihan;

}

    public void Heal()
    {
        if (Energy > 100)
        {

            Console.WriteLine("Gagal melakukan Heal, Energy sudah mecapai maksimal");
        }
        else
        {
            if (Energy > 95)
            {
                Energy = 100;
            }
            else
            {
                Energy = +5;
            }
            Console.WriteLine($"{Name} berhasil melakukan heal. energi meningkat menjadi (Energy)");


        }

    }

    

