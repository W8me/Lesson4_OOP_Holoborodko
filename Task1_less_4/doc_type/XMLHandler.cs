using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_less_4.doc_type
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open XML file");
        }
        public override void Change()
        {
            Console.WriteLine("Change XML file");
        }
        public override void Create()
        {
            Console.WriteLine("Create XML file");
        }
        public override void Save()
        {
            Console.WriteLine("Save XML file");
        }
    }
}
