using System;
using CaseStudyApp.Examples;
using CaseStudyApp.Models;
using CaseStudyApp.Services;
using CaseStudyApp.Models.Animals;
using CaseStudyApp.Utils;

namespace CaseStudyApp
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("== Task1 ==");
            IndexAccessExample.Run();

            Console.WriteLine("\n== Task2 ==");
            var p = new Person("Ayşe", 28);
            Console.WriteLine(p.Introduce());

            Console.WriteLine("\n== Task3 ==");
            var service = new CountService();
            await service.PrintAllCountsAsync();

            Console.WriteLine("\n== Task4 ==");
            var list = new System.Collections.Generic.List<int> {3, 7, 2};
            Console.WriteLine($"Max: {ListUtils.GetMax(list)}");

            Console.WriteLine("\n== Task5 ==");
            Animal[] animals = { new Dog(), new Cat() };
            foreach (var a in animals) a.MakeSound();

            Console.WriteLine("\nDemo tamamlandı.");
        }
    }
}
