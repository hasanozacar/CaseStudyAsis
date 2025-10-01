using System;
using System.Collections.Generic;
using System.Linq;

namespace CaseStudyApp.Utils
{
    public class MaxListEmptyException : Exception
    {
        public MaxListEmptyException() : base("Liste boş olduğu için maksimum değer alınamıyor.") { }
    }

    public static class ListUtils
    {
        public static int? GetMax(List<int> list)
        {
            if (list == null || list.Count == 0) return null;
            return list.Max();
        }

        public static int GetMaxOrThrow(List<int> list)
        {
            if (list == null || list.Count == 0) throw new MaxListEmptyException();
            return list.Max();
        }
    }
}
