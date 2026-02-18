using System;
using System.Collections.Generic;
using System.Text;

namespace SmartReferenceProxyDesignPattern
{
    //IDatabaseConnection (Subject)
    public interface IDatabaseConnection
    {
        void ExecuteQuery(string query);
    }
}
