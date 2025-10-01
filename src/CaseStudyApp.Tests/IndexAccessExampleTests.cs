using System;
using System.IO;
using CaseStudyApp.Examples;
using Xunit;

namespace CaseStudyApp.Tests
{
    public class IndexAccessExampleTests
    {
        [Fact]
        public void Run_PrintsIndexErrorMessage()
        {
            var sw = new StringWriter();
            var originalOut = Console.Out;
            Console.SetOut(sw);
            try
            {
                IndexAccessExample.Run();
                var output = sw.ToString();
                Assert.Contains("Index hatası yakalandı", output);
            }
            finally
            {
                Console.SetOut(originalOut);
            }
        }
    }
}
