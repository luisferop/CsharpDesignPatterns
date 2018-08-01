using System;
using System.Diagnostics;

namespace prjSingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today.");
            j.AddEntry("I ate a bug.");
            Console.WriteLine(j);

            var p = new JournalPersistence();
            var filename = @"c:\temp\journal.txt";
            p.SaveToFile(j, filename);
            Process.Start(filename);
        }
    }
}
