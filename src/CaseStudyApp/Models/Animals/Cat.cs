using System;

namespace CaseStudyApp.Models.Animals
{
    public class Cat: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Miyav");
        }
    }
}