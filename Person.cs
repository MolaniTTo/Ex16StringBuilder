using System;
using System.Text;


namespace Ex16StringBuilder
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("NOM: " + Name);

            sb.Append('\n');

            sb.Append("EDAT: " + Age);

            return sb.ToString();

        }
    }
}
