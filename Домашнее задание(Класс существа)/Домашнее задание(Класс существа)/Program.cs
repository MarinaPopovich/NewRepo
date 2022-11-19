namespace Домашнее_задание_Класс_существа_
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            double seed = rnd.NextDouble();
            List<Character> characters = new List<Character>();
            Character c = new Character() { Name = "CharTest", X = 0, Y = 0 };
            Character c2 = new Character() { Name = "CharTest", X = 0, Y = 0 };
            Character c3 = new Character() { Name = "CharTest", X = 0, Y = 0 };
            characters.Add(c);
            characters.Add(c2);
            characters.Add(c3);
            for (int i = 0; i < 10; i++)
            {
                characters.Add(new Character() { Name = "Char_" + i.ToString(), X = i, Y = i });
            }

            foreach (Character character in characters)
                character.Move(0);
            int[] array = new int[] { 1, 2, 3, 5, 10, 12 };
            characters = new List<Character>() { c };
            characters.Insert(0, c);

            //List<int> salaries = new List<int>() { 100, 200, 95, 100000, 5500 };

            //int max = salaries.First();

            //foreach (int s in salaries)
            //{
            //    if (max < s)
            //        max = s;
            //}
            //Console.WriteLine(max);
            //List<Character> characters = new List<Character>();
            //Character c = new Character() { Name = "CharTest", X = 0, Y = 0 };
            //Character c2 = new Character() { Name = "CharTest", X = 0, Y = 0 };
            //Character c3 = new Character() { Name = "CharTest", X = 0, Y = 0 };
            //characters.Add(c);
            //characters.Add(c2);
            //characters.Add(c3);
            int max = characters[0].X;

            foreach (Character ch in characters)
            {
                if (ch.X > max)
                    max = ch.X;
            }
            Console.WriteLine(max);


            Pokemon p = new Pokemon(100, "Pikachu");
            
         
            


            List<int> list = new List<int>();
            List<int> bufferList = new List<int>();
            foreach (int e in list)
            {
                if (e > 50)
                    bufferList.Add(e);
            }
            foreach (int dE in bufferList)
            {
                list.Remove(dE);
            }
        }
    }
    class Pokemon
    {
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

        public string Name { get; set; }
        public Pokemon(int health, string name)
        {
            Health = health;
            Name = name;
        }

        public void Move(int direction)
        {
            if (direction == 0)
            {
                X += 1;
            }
            else if (direction == 1)
            {
                Y += 1;
            }
            if (direction == 2)
            {
                X -= 1;
            }
            if (direction == 3)
            {
                Y -= 1;
            }
        }
    }

        class Character
        {
            public string Name;
            public int X;
            public int Y;


            public void Move(int dir)
            {
                if (dir == 0)
                {
                    X += 1;
                }
                else if (dir == 1)
                {
                    Y += 1;
                }
                if (dir == 2)
                {
                    X -= 1;
                }
                if (dir == 3)
                {
                    Y -= 1;
                }
                Console.WriteLine($"Текущее положение персонажа {Name}: {X};{Y}");
            }
        } 
}