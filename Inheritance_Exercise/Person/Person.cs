using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    AgeException();
                }
                age = value;
            }
        }

        public virtual string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                {
                    NameException();
                }
                name = value;
            }
        }

        private void NameException()
        {
            throw new ArgumentException("Name's length should not be less than 3 symbols!");
        }

        private static void AgeException()
        {
            throw new ArgumentException("Age must be positive!");
        }

        public override string ToString()
        {
            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.Append(string.Format("Name: {0}, Age: {1}",
                                this.Name,
                                this.Age));

            return stringbuilder.ToString();
        }
    }
}
