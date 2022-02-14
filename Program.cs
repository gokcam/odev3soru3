using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz: ");
            var text = Console.ReadLine();
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            List<char> sesliList = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                foreach (var item in sesliHarfler)
                {
                    if(text[i] == item)
                    {
                        sesliList.Add(text[i]);
                    }
                }
            }

            sesliList.Sort();
            sesliList.ForEach(x => Console.WriteLine(x));
        }
    }
}
