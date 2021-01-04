using System;
using System.Collections.Generic;

namespace HashSet2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> gradovi = new HashSet<string>(new IgnoreCaseComparer()) 
                { "Beograd", "Nis", "Kragujevac"};
            
            Console.WriteLine(gradovi.Add("NOVI SAD"));
            Console.WriteLine(gradovi.Add("BEOGRAD"));
            Console.WriteLine("=======================================");
            
            foreach (var grad in gradovi)
                Console.WriteLine(grad);
        }
    }
}
