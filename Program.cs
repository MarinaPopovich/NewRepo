namespace Lesson6
{
    internal class Program
    {
        static void Main()
        {
           
        }
    }
    namespace Lesson6
    {
        internal class Program
        {
            static void Main()
            {

            }
        }
        public class Person
        {


            private string Name { get; set; }
            public string name { get; set; }
            private string Surname { get; set; }
            private int Age { get; set; }
            public int Salary { get; set; }
            public Person(string name)
            {
                this.name = name;
            }

        }
        public class Scientist : Person
        {
            public int Academ { get; set; }

            public override string name
            {
                get { return name; }
                set { name = value; }
            }
            public void WriteCharacteristics()
            {
                Console.WriteLine(" $ Имя: {name} , Фамилия: {Surname}, Возраст: {Age} , Ученая степень: {Academ}, Зарплата: {Salary}");
            }
        }



    }
}