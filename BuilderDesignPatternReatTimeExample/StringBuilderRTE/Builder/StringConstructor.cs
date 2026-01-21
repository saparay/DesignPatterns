using BuilderDesignPatternReatTimeExample.StringBuilderRTE.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternReatTimeExample.StringBuilderRTE.Builder
{
    public class StringConstructor
    {
        private CustomString _customString = new CustomString();

        public StringConstructor AppendLine(string line) {
            _customString.Append(line + Environment.NewLine);
            return this;
        }
        public StringConstructor AppendSpace(string word)
        {
            _customString.Append(word + " ");
            return this;
        }
        public StringConstructor AppendWords(params string[] words)
        {
            foreach (var word in words)
            {
                AppendSpace(word);
            }
            return this; 
        }

        public CustomString Build()
        {
            return _customString;
        }
    }
}
