using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Derived
{
    class TXTHandler : AbstractHandler
    {
        public void PrintDocExt()
        {
            Console.Write(".TXT document.\n");
        }

        public override void Open()
        {
            Console.WriteLine("Opening .TXT document.");
        }
        public override void Create()
        {
            Console.WriteLine("Creating .TXT document.");
        }
        public override void Chenge()
        {
            Console.WriteLine("Changing .TXT document.");
        }
        public override void Save()
        {
            Console.WriteLine("Saving .TXT document.");
        }
    }
}
