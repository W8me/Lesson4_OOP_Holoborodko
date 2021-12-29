using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_less_4.doc_type
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open DOC file");
        }
        public override void Change()
        {
            Console.WriteLine("Change DOX file");
        }
        public override void Create()
        {
            Console.WriteLine("Create DOC file");
        }
        public override void Save()
        {
            Console.WriteLine("Save DOC file");
        }
    }
}
