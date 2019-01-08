using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCompiler
{
    public class IncludeStatus
    {
        public bool CountCheck { get; set; }
        public bool OrderCheck { get; set; }
        public bool EngWordsCheck { get; set; }
        public bool SloWordsCheck { get; set; }
        public bool MeaningCheck { get; set; }
        public bool PronCheck { get; set; }
        public bool UrlCheck { get; set; }
        public bool UrlShortenCheck { get; set; }
    }
}
