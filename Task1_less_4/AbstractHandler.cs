using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_less_4
{
    abstract class AbstractHandler
    {
        public virtual void Open() { }
        public virtual void Create() { }
        public virtual void Change() { }
        public virtual void Save() { }

    }
}
