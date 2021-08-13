using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("Title","Body is here","Footer");
            doc.PrintDocument();
        }
    }
}
