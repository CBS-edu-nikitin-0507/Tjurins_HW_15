using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Derived
{
    class DOCHandler : AbstractHandler
    {
        public void PrintDocExt()
        {
            Console.Write(".DOC document.\n");
        }
        
        public override void Open()
        {
            Console.WriteLine("Opening .DOC document.");
        }
        public override void Create()
        {
            Console.WriteLine("Creating .DOC document.");
        }
        public override void Chenge()
        {
            Console.WriteLine("Changing .DOC document.");
        }
        public override void Save()
        {
            Console.WriteLine("Saving .DOC document.");
        }
    }
}
