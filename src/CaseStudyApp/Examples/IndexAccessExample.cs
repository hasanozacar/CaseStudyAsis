using System;

namespace CaseStudyApp.Examples
{
    public static class IndexAccessExample
    {
        public static void Run()
        {
            int[] numbers = {1, 2, 3};
            try
            {
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Index hatası yakalandı: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmeyen hata: {ex.Message}");
            }
        }
    }
}
