using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Derived
{
    class XMLHandler : AbstractHandler
    {
        public void PrintDocExt()
        {
            Console.Write(".XML document.\n");
        }

        public override void Open()
        {
            Console.WriteLine("Opening .XML document.");
        }
        public override void Create()
        {
            Console.WriteLine("Creating .XML document.");
        }
        public override void Chenge()
        {
            Console.WriteLine("Changing .XML document.");
        }
        public override void Save()
        {
            Console.WriteLine("Saving .XML document.");
        }
    }
}
