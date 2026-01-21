using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BuilderDesignPatternReatTimeExample.StringBuilderRTE.Product
{
    public class CustomString
    {
        private StringBuilder _stringBuilder = new StringBuilder();

        public void Append(string str)
        {
            _stringBuilder.Append(str);
        }

        public override string ToString()
        {
            return _stringBuilder.ToString();
        }
    }
}
