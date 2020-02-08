using System;

namespace _01.AbstractHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            string formatDoc;
            while (true)
            {
                Console.WriteLine("Enter document format(TXT/XML/DOC/QUIT): ");
                formatDoc = Console.ReadLine();

                if (formatDoc == "DOC")
                {
                    AbstractHandler doc = new DOCHandler();
                    doc.open();
                    doc.create();
                    doc.change();
                    doc.save();
                }
                else if (formatDoc == "XML")
                {
                    AbstractHandler xml = new XMLHandler();
                    xml.open();
                    xml.create();
                    xml.change();
                    xml.save();
                }
                else if (formatDoc == "TXT")
                {
                    AbstractHandler txt = new TXTHandler();
                    txt.open();
                    txt.create();
                    txt.change();
                    txt.save();
                }
                else if (formatDoc == "QUIT")
                {
                    break;
                }
                else
                    Console.WriteLine("Failed format! Enter again!");
            }

        }
    }
    public abstract class AbstractHandler
    {
        public abstract void open();
        public abstract void create();
        public abstract void change();
        public abstract void save();
    }
    public class XMLHandler : AbstractHandler
    {
        override public void open()
        {
            Console.WriteLine("Open XML");
        }

        override public void create()
        {
            Console.WriteLine("Create XML");
        }

        override public void change()
        {
            Console.WriteLine("Change XML");
        }

        override public void save()
        {
            Console.WriteLine("Save XML");
        }
    }
    public class TXTHandler : AbstractHandler
    {
        override public void open()
        {
            Console.WriteLine("Open TXT");
        }

        override public void create()
        {
            Console.WriteLine("Create TXT");
        }

        override public void change()
        {
            Console.WriteLine("Change TXT");
        }

        override public void save()
        {
            Console.WriteLine("Save TXT");
        }
    }
    public class DOCHandler : AbstractHandler
    {
        override public void open()
        {
            Console.WriteLine("Open DOC");
        }

        override public void create()
        {
            Console.WriteLine("Create DOC");
        }

        override public void change()
        {
            Console.WriteLine("Change DOC");
        }

        override public void save()
        {
            Console.WriteLine("Save DOC");
        }
    }
}
