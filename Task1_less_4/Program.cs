using System;
using Task1_less_4.doc_type;

namespace Task1_less_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string docName;

            Console.Write("Введите росширение документа: ");
            docName = Console.ReadLine();
            docName = docName.ToLower();

            switch (docName)
            {
                case "txt":
                    TXTHandler txtDoc = new TXTHandler();
                    txtDoc.Open();
                    txtDoc.Change();
                    txtDoc.Create();
                    txtDoc.Save();
                    break;

                case "xml":
                    XMLHandler xmlDoc = new XMLHandler();
                    xmlDoc.Open();
                    xmlDoc.Change();
                    xmlDoc.Create();
                    xmlDoc.Save();

                    break;

                case "doc":
                    DOCHandler docDoc = new DOCHandler();
                    docDoc.Open();
                    docDoc.Change();
                    docDoc.Create();
                    docDoc.Save();
                    break;

                default:
                    Console.WriteLine("Вы ввели неверное расширение или оно пока не поддерживается :)");
                    break;

            }
        }
    }
}
