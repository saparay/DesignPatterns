using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPatternRealTimeExample.GraphicsEditors
{
    public interface IShapePrototype
    {
        IShapePrototype Clone();
    }
}
