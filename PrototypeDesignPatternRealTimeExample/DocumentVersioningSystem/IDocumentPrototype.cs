using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPatternRealTimeExample.DocumentVersioningSystem
{
    public interface IDocumentPrototype
    {
        IDocumentPrototype Clone();
    }
}
