using System;
using Task2.Derived;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler doc = new DOCHandler();
            AbstractHandler txt = new TXTHandler();
            AbstractHandler xml = new XMLHandler();

            doc.PrintHeader();
            ((DOCHandler)doc).PrintDocExt();
            doc.Create();
            doc.Open();
            doc.Chenge();
            doc.Save();
            Console.WriteLine(new string ('-',50));

            txt.PrintHeader();
            ((TXTHandler)txt).PrintDocExt();
            txt.Create();
            txt.Open();
            txt.Chenge();
            txt.Save();
            Console.WriteLine(new string('-', 50));

            xml.PrintHeader();
            ((XMLHandler)xml).PrintDocExt();
            xml.Create();
            xml.Open();
            xml.Chenge();
            xml.Save();
            Console.WriteLine(new string('-', 50));

        }
    }
}
