
using System.Xml.Linq;

Wizard wizardA = new Wizard("Mak Lampir", 5);
Wizard wizardB = new Wizard("Nirmala", 10);


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

