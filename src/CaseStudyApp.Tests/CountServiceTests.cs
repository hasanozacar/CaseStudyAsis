using System;
using System.IO;
using System.Threading.Tasks;
using CaseStudyApp.Services;
using Xunit;

namespace CaseStudyApp.Tests
{
    public class CountServiceTests
    {
        [Fact]
        public async Task PrintAllCountsAsync_PrintsAllCounts()
        {
            var service = new CountService();
            var sw = new StringWriter();
            var originalOut = Console.Out;
            Console.SetOut(sw);
            try
            {
                await service.PrintAllCountsAsync();
                var output = sw.ToString();
                Assert.Contains("Kullanıcı Sayısı: 42", output);
                Assert.Contains("Sipariş Sayısı: 10", output);
                Assert.Contains("Ürün Sayısı: 128", output);
            }
            finally
            {
                Console.SetOut(originalOut);
            }
        }
    }
}