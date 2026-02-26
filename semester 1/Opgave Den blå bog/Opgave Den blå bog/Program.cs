using System.Drawing;

namespace Opgave_Den_blå_bog
{

    public class Person
    {

        public string name { get; set; }
        public int age { get; set; }
        public bool gender { get; set; }

        public Person(string name, int age, bool gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public override string ToString()
        {
            string gender = this.gender ? "Mand" : "Kvinde";
            return $"{this.name} {this.age} {gender}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Tobias", 32, true);
            Console.WriteLine(p1.ToString());
        }
    }
}
