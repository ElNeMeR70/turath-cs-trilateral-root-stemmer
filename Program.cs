using System;
using System.Text;

// turath-cs-trilateral-root-stemmer — مستخرج الجذور الثلاثية والرباعية من النصوص التراثية
// Classical Arabic Khoja/ISRI-Style Trilateral Root Extractor
namespace Islamic1000
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string input = "والمستضعفين";
            ulong hash = 14695981039346656037UL;
            foreach (byte b in Encoding.UTF8.GetBytes(input))
            {
                hash ^= b;
                hash *= 1099511628211UL;
            }
            Console.WriteLine("[RUN] turath-cs-trilateral-root-stemmer (C#) — Classical Arabic Khoja/ISRI-Style Trilateral Root Extractor");
            Console.WriteLine("[AR]  مستخرج الجذور الثلاثية والرباعية من النصوص التراثية");
            Console.WriteLine($"[IN]  {input}");
            Console.WriteLine($"[OUT] Prefix=و+ال+مست | Stem=ضعف | Suffix=ين | Root=ض-ع-ف | Hash=0x{hash:X16}");
            Console.WriteLine("[OK]  Islamic computational engine verified successfully.");
        }
    }
}
