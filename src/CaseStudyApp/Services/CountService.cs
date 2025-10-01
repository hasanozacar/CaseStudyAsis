using System;
using System.Threading.Tasks;

namespace CaseStudyApp.Services
{
    public class CountService
    {
        public virtual async Task<int> GetUserCountAsync()
        {
            await Task.Delay(10);
            return 42; // Simulated count
        }

        public virtual async Task<int> GetOrderCountAsync()
        {
            await Task.Delay(10);
            return 10;
        }

        public virtual async Task<int> GetProductCountAsync()
        {
            await Task.Delay(10);
            return 128;
        }

        public async Task PrintAllCountsAsync()
        {
            var userTask = GetUserCountAsync();
            var orderTask = GetOrderCountAsync();
            var productTask = GetProductCountAsync();

            var results = await Task.WhenAll(userTask, orderTask, productTask);
            Console.WriteLine($"Kullanıcı Sayısı: {results[0]}, Sipariş Sayısı: {results[1]}, Ürün Sayısı: {results[2]}");
        }
    }
}