using static Домашнее_задание_Класс_существа_.Wolfs;

namespace Домашнее_задание_Класс_существа_
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            int seed = rnd.Next(0,100);


            List<int>  = new List<Age>();
            List<Wolfs> Wolf = new List<Wolf>();
            Wolf c = new Wolfs() { Name = "Wolf1", X = 0, Y = 0 };
            Wolf c2 = new Wolfs() { Name = "Wolf2", X = 0, Y = 0 };
            Wolf c3 = new Wolfs() { Name = "Wolf3", X = 0, Y = 0 };
            Wolf.Add(c);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i}-й элемент списка: {Wolf{i}}");
                Wolfs.Add(new Wolfs() { Name = "Wolf_" + i.ToString(), X = i, Y = i });
            }

            foreach (Wolfs Wolfs in Wolf)
           
            int max = Wolf[100].X;

            foreach (Wolfs Wf in Wolf)
            {
                if (Wf.X > max)
                    max = Wf.X;
            } //    Wolfs.Move(0);

            //    Console.WriteLine( seed.ToString());
            //List<int> list = new List<int>();
            //List<int> bufferList = new List<int>();
            //foreach (int e in list)
            //{
            //    if (e > 50)
            //        bufferList.Add(e);
            //}
            //foreach (int dE in bufferList)
            //{
            //    list.Remove(dE);
            //}

            //List<Age> Ages = new List<Age>();
            //Age c = new Age() { Name = "CharTest", X = 0, Y = 0 };

            //Ages.Add(c);

            //for (int i = 0; i < 10; i++)
            //{
            //    Ages.Add(new Age() { Name = "Char_" + i.ToString(), X = i, Y = i });
            //}

            //foreach (Age Age in Ages)
            //    Age.Move(0);
            //int[] array = new int[] { 1, 2, 3, 5, 10, 12 };
            //Ages = new List<Age>() { c };
            //Ages.Insert(0, c);

            //int max = Ages[0].X;

            //foreach (Age ag in Ages)
            //{
            //    if (ag.X > max)
            //        max = ag.X;
            //}
            //Console.WriteLine(max);


            //Wolfs Wolf1 = new Wolfs();






            
        }
    }

    //class Wolfs


    /*public string  Health { get;  private set; }*/

    public class Wolfs
    {
        public int Health;
        public int Attak;
        public int Armor;
        public int maxAge;

        public Wolfs()
        {
            Health = 100;
            Attak = 70;
            Armor = 80;
            Age = 1;
            maxAge = 100;
        }

        //public Wolfs(int health, string name)
        //{
        //    Health = health;
        //    Name = name;
            


        //}
        public string Name { get; set; }
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
    class Age
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

