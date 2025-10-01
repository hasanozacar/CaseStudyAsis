using System;
using System.IO;
using CaseStudyApp.Models.Animals;
using Xunit;

namespace CaseStudyApp.Tests
{
    public class AnimalTests
    {
        [Fact]
        public void Dog_CallsMakeSound_PrintsHav()
        {
            var sw = new StringWriter();
            var originalOut = Console.Out;
            Console.SetOut(sw);
            try
            {
                Animal dog = new Dog();
                dog.MakeSound();
                var output = sw.ToString().Trim();
                Assert.Equal("Hav", output);
            }
            finally
            {
                Console.SetOut(originalOut);
            }
        }
        [Fact]
        public void Cat_CallsMakeSound_PrintsMiyav()
        {
            var sw = new StringWriter();
            var originalOut = Console.Out;
            Console.SetOut(sw);
            try
            {
                Animal cat = new Cat();
                cat.MakeSound();
                var output = sw.ToString().Trim();
                Assert.Equal("Miyav", output);
            }
            finally
            {
                Console.SetOut(originalOut);
            }
        }
    }
}