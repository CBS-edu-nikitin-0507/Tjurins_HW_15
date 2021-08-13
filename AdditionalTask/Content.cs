using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    abstract class Content
    {
        string title;
        public string Title
        {
            private get
            {
                if (title != null)
                    return title;
                else
                    return "Заголовок отсутствует.";
            }
            set
            {
                title = value;
            }
        }

        string body;
        public string Body 
        {
            private get
            {
                if (body != null)
                    return body;
                else
                    return "Тело документа отсутствует.";
            }
            set
            {
                body = value;
            }
        }

        string footer;
        public string Footer
        {
            private get
            {
                if (footer != null)
                    return footer;
                else
                    return "Нижний колонтитул отсутствует.";
            }
            set
            {
                footer = value;
            }
        }
        public Content(string tit, string bod,string foot)
        {
            Title = tit;
            Body = bod;
            Footer = foot;

        }
        public  void PrintTitle()
        {
            Console.WriteLine(title);
        }
        public  void PrintBody()
        {
            Console.WriteLine(body);
        }
        public  void PrintFooter()
        {
            Console.WriteLine(footer);
        }

        public abstract void PrintDocument();
    }
}
