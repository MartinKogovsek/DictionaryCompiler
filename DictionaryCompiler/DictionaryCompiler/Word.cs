using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCompiler
{
    public class Word
    {
        public string WordCount { get; set; }
        public string SloWord { get; set; }
        public string EngWord { get; set; }
        public string Meaning { get; set; }
        public string Pron { get; set; }
        public string UrlText { get; set; }

        public string ConcatenateProperties()
        {
            string ret = WordCount + EngWord + SloWord + Meaning + Pron + UrlText;
            ret = ret.Substring(0, ret.Length - 1);
            return ret;
        }
    }
}
