using System;

namespace CaseStudyApp.Models
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            if (age < 0 || age > 150) throw new ArgumentOutOfRangeException(nameof(age), "Yaşınız 0 ile 150 arasında olmalıdır.");
            Age = age;
        }

        public string Introduce()
        {
            return $"Merhaba, benim adım {Name} ve {Age} yaşındayım.";
        }
    }
}