using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Document : Content
    {
        public Document(string title, string content, string footer) :base(title,content,footer)
        { 
        }
        public override void PrintDocument()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintTitle();
            Console.ForegroundColor = ConsoleColor.Blue;
            PrintBody();
            Console.ForegroundColor = ConsoleColor.Green;
            PrintFooter();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
