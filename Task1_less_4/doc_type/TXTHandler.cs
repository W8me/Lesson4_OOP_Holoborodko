using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_less_4.doc_type
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open TXT file");
        }
        public override void Change()
        {
            Console.WriteLine("Change TXT file");
        }
        public override void Create()
        {
            Console.WriteLine("Create TXT file");
        }
        public override void Save()
        {
            Console.WriteLine("Save TXT file");
        }
    }
}
