using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern.ObjectAdapterDesignPattern
{
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }
}
