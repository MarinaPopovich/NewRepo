namespace Домашнее_задание_Класс_существа_
{
    internal class Program
    {

        static Random rnd = new Random();
        static void Main()
        {
            List<Wolfs> Wolf1 = new List<Wolfs>();
            for (int j = 0; j < 1; j++)
            {
                Wolfs w = new Wolfs();
                int[] wolfHealth = new int[100];
                int[] wolfAttak = new int[100];
                int[] wolfArmor = new int[100];
                int[] wolfAge = new int[100];
                for (int i = 1; i < 51; i++)
                {
                    wolfHealth[i] = rnd.Next(i, 100);
                    wolfAttak[i] = rnd.Next(2, 100);
                    wolfArmor[i] = rnd.Next(2, 100);
                    wolfAge[i] = rnd.Next(i, 100);
                    Console.WriteLine($"{i}-й волк, Здоровье: {wolfHealth[i]}, Сила: {wolfAttak[i]}, Броня: {wolfArmor[i]}, Возраст: {wolfAge[i]}");
                    Wolf1.Add(w);
                }
            }
            Console.WriteLine("-----------");

            List<Wolfs> Wolf2 = new List<Wolfs>();
            for (int j = 0; j < 1; j++)
            {
                Wolfs w1 = new Wolfs();
                int[] wolfHealth = new int[100];
                int[] wolfAttak = new int[100];
                int[] wolfArmor = new int[100];
                int[] wolfAge = new int[100];
                for (int i = 1; i < 51; i++)
                {
                    wolfHealth[i] = rnd.Next(i, 100);
                    wolfAttak[i] = rnd.Next(2, 100);
                    wolfArmor[i] = rnd.Next(2, 100);
                    wolfAge[i] = rnd.Next(i, 100);
                    Console.WriteLine($" {i}-й волк, Здоровье: {wolfHealth[i]}, Сила: {wolfAttak[i]}, Броня: {wolfArmor[i]}, Возраст: {wolfAge[i]}");
                    Wolf2.Add(w1);
                }

            }
            //Wolf2.Attack(Wolf1);

        }
    }
    public class Wolfs
    {
        public string Name;
        public int Attak;
        public int Armor;

        public int Age;
        public int maxAge;

        public int[] wolfAttak;

        public void Attack(Wolfs otherWolf)
        {
            otherWolf.Health -= 20;
        }

        public Wolfs()
        {
            maxAge = 100;
        }


        private int _health;
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Health
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _health = value;
                }
            }
            get
            {
                return _health;
            }
        }

    }
}