using System;
namespace udemyCourse
{
    public class Person
    {
        public string name;
        public int age;
        public string work;
        public int[] numbers;

        public Person(string name, int age, string work)
        {
            this.name = name;
            this.age = age;
            this.work = work;
            numbers = new int[6];
            for (int i = 0; i < 6; i++)
            {
                this.numbers[i] = i + 2;
            }
        }

        public void sayHi()
        {
            Console.WriteLine("hello my friend {0} of the age of {1} and who works as {2}," +
                "and the numbers are: {3} ",
                this.name, this.age, this.work, string.Join(',', this.numbers));
        }
    }
}
