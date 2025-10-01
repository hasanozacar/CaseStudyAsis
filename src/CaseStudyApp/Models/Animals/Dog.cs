using System;

namespace CaseStudyApp.Models.Animals
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hav");
        }
    }
}