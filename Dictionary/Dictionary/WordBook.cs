using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class WordBook
    {
        Dictionary<string, string> defs = new Dictionary<string, string>();
        public WordBook() { }
        public void Add(string word, string definition)
        {
            defs.Add(word, definition);
        }
        public string GetDef(string word) 
        {
            return defs[word];
        }
    }
}
