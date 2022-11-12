using System.Runtime.CompilerServices;
using static Program;

internal class Program
{
    static void Main()
    {
        Console.WriteLine(" Введите 'Закончить', чтобы закончить");
        string orde = Console.ReadLine();
        while (orde != "Закончить")
        {
            Console.WriteLine("Выберите победителя. Волк1: введите 'Волк1', волк2: введите 'Волк2'.");
            string order = Console.ReadLine();
            if (order == "Волк1")
            {
                Wolfs Wolfs1 = new Wolfs();
                Wolfs1.Health = 100;
                Wolfs Wolfs2 = new Wolfs();
                Wolfs2.Health = 90;
                Console.WriteLine($" Волк1." +
                    $"Здоровье:{Wolfs1.Health}," +
                    $" Волк2." +
                    $"Здоровье: {Wolfs2.Health}");
               Wolfs1.Attak1(Wolfs2);
                Console.WriteLine($" Волк2." +
                    $"Здоровье:{Wolfs2.Health} ");
                Wolfs1.Attak1(Wolfs2);
                Wolfs2.Block(Wolfs1); 
                Console.WriteLine($"  Волк1." +
                    $"Здоровье:{Wolfs1.Health}");
                Wolfs2.Attak1(Wolfs1);
                Wolfs1.Dodge(Wolfs2);
                Console.WriteLine($"  Волк2. " +
                    $"Выносливость:{Wolfs2.Agility}, защита: {Wolfs2.Armor}, здоровье: {Wolfs2.Health} ");
                Wolfs1.Attak1(Wolfs2);
                Wolfs1.Attak1(Wolfs2);
                Console.WriteLine($" Волк2." +
                    $"Здоровье:{Wolfs2.Health} ");
                Wolfs1.Attak1(Wolfs2);
                Wolfs2.Block(Wolfs1);
                Console.WriteLine($"  Волк1." +
                    $"Здоровье:{Wolfs1.Health}");
                Wolfs1.Attak1(Wolfs2);
                Console.WriteLine($" Волк2." +
                   $"Здоровье:{Wolfs2.Health}, Волк2 Умер. ");
            }
            else if (order == "Волк2")
            {
                Wolfs Wolfs1 = new Wolfs();
                Wolfs1.Health = 100;
                Wolfs Wolfs2 = new Wolfs();
                Wolfs2.Health = 90;
                Console.WriteLine($" Волк2." +
                     $"Здоровье:{Wolfs2.Health}," +
                     $" Волк1." +
                     $"Здоровье: {Wolfs1.Health}");
                Wolfs2.Attak1(Wolfs1);
                Console.WriteLine($" Волк1." +
                    $"Здоровье:{Wolfs1.Health} ");
                Wolfs2.Attak1(Wolfs1);
                Wolfs1.Block(Wolfs2);
                Console.WriteLine($"  Волк2." +
                    $"Здоровье:{Wolfs2.Health}");
                Wolfs1.Attak1(Wolfs2);
                Wolfs2.Dodge(Wolfs1);
                Console.WriteLine($"  Волк1. " +
                    $"Выносливость:{Wolfs1.Agility}, защита: {Wolfs1.Armor}, здоровье: {Wolfs1.Health} ");
                Wolfs2.Attak1(Wolfs1);
                Wolfs2.Attak1(Wolfs1);
                Console.WriteLine($" Волк1." +
                    $"Здоровье:{Wolfs1.Health} ");
                Wolfs2.Attak1(Wolfs1);
                Wolfs1.Block(Wolfs2);
                Console.WriteLine($"  Волк2." +
                    $"Здоровье:{Wolfs2.Health}");
                Wolfs2.Attak1(Wolfs1);
                Console.WriteLine($" Волк1." +
                   $"Здоровье:{Wolfs1.Health} ");
                Wolfs2.Attak1(Wolfs1);
                Console.WriteLine($" Волк1." +
                    $"Здоровье:{Wolfs1.Health}, волк умер.");

            }
            Console.WriteLine(" Введите 'Закончить', чтобы закончить");
            orde = Console.ReadLine();
        }
    }
    
    public class Wolfs
    {
        public int Health;
        public int Attak;
        public int Armor;
        public int Agility;
        public Wolfs ()
        {
            
            Attak = 70;
            Armor = 80;
            Agility = 100;
        }
        public void Attak1( Wolfs otherWolfs)
        {
            otherWolfs.Health -= 20;
           this.Armor -= 10;
           this.Agility -= 10;
            Console.WriteLine($" Волк актаковал." +
                $" Выносливость:{Agility}, защита: {Armor}, здоровье: {Health}");
        }
        
        public void Dodge(Wolfs otherWolfs)
        {
            otherWolfs.Armor -= 10;
            otherWolfs.Agility -= 10;
            this.Agility -= 10;
            this.Armor += 20;
            Console.WriteLine($" Волк увернулся." +
                $" Выносливость:{Agility}, защита: {Armor}");
        }
        public void Block(Wolfs otherWolfs)
        {
            otherWolfs.Health -= 5;
            this.Health += 20;
            this.Agility += 10;
            this.Health -= 5;
            Console.WriteLine($" Волк блокировал удар." +
                $" Выносливость:{Agility}, защита: {Armor}, здоровье: {Health}");
        }
      
    }
}   