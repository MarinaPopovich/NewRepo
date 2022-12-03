namespace Домашняя_работа_Character_
{
    internal class Program
    {
        static void Main()
        {

        }
    }
    public abstract class Character
    {
        public virtual int Health { get; set; }
        public int Attakc;
        public int Armor;
        public Character(int health)
        {
            Health = health;
            Attakc = 70;
            Armor = 80;
        }
        public abstract void Attak();
    }
    public class Soldier : Character
    {
        public int Attack { get; set; }
        public Soldier(int health) : base(health)
        {
            Health = 100;
        }
        public override void Attak()
        {
            Health -= 2;
            Console.WriteLine($" Боец актаковал." +
                $"  здоровье: {Health}");
        }
        public class Archer : Character
        {
            public Archer(int health) : base(health)
            {
                Health = health;
            }
            private int _health;
            public override int Health
            {
                get
                {
                    return _health;
                }
                set
                {
                    _health = value;
                }
            }
            public override void Attak()
            {
                Health -= 2;
                Console.WriteLine($" Лучник актаковал." +
                    $"  здоровье: {Health}");
            }
            public void Dodge()
            {
                Armor += 10;
                Console.WriteLine($" Волк увернулся." +
                    $" защита: {Armor}");
            }
        }

        public class Shield_Bearer : Archer
        {
            public Shield_Bearer(int health) : base(health)
            {
                Health = health;
            }
            public override void Attak()
            {
                Health -= 2;
                Console.WriteLine($" Щитоносец актаковал." +
                    $"  здоровье: {Health}");
            }
            public void Block()
            {
                Health -= 5;
                this.Health += 20;
                Console.WriteLine($"Щитоносец блокировал удар." +
                    $"защита: {Armor}, здоровье: {Health}");
            }
        }
    }
}


//}private int _health;
//        public override int Health;
//       {get 
//            {return _health;
//}
//    set
//        {_health = Value;}}