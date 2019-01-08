using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Translation.V2;

namespace DictionaryCompiler
{
    public class Translation
    {
        public static string TranslateAsync(string word, string ApiKeyConst, string lang)
        {
            TranslationClient client = TranslationClient.CreateFromApiKey(ApiKeyConst);
            TranslationResult result;

            switch (lang)
            {
                case "Afrikaans":
                    result = client.TranslateText(word, LanguageCodes.Afrikaans);
                    break;
                case "Albanian":
                    result = client.TranslateText(word, LanguageCodes.Albanian);
                    break;
                case "Amharic":
                    result = client.TranslateText(word, LanguageCodes.Amharic);
                    break;
                case "Arabic":
                    result = client.TranslateText(word, LanguageCodes.Arabic);
                    break;
                case "Armenian":
                    result = client.TranslateText(word, LanguageCodes.Armenian);
                    break;
                case "Azerbaijani":
                    result = client.TranslateText(word, LanguageCodes.Azerbaijani);
                    break;
                case "Basque":
                    result = client.TranslateText(word, LanguageCodes.Basque);
                    break;
                case "Belarusian":
                    result = client.TranslateText(word, LanguageCodes.Belarusian);
                    break;
                case "Bengali":
                    result = client.TranslateText(word, LanguageCodes.Bengali);
                    break;
                case "Bosnian":
                    result = client.TranslateText(word, LanguageCodes.Bosnian);
                    break;
                case "Bulgarian":
                    result = client.TranslateText(word, LanguageCodes.Bulgarian);
                    break;
                case "Burmese":
                    result = client.TranslateText(word, LanguageCodes.MyanmarBurmese);
                    break;
                case "Catalan":
                    result = client.TranslateText(word, LanguageCodes.Catalan);
                    break;
                case "Cebuano":
                    result = client.TranslateText(word, LanguageCodes.Cebuano);
                    break;
                case "Chichewa":
                    result = client.TranslateText(word, LanguageCodes.Chichewa);
                    break;
                case "Chinese Simplified":
                    result = client.TranslateText(word, LanguageCodes.ChineseSimplified);
                    break;
                case "Chinese Traditional":
                    result = client.TranslateText(word, LanguageCodes.ChineseTraditional);
                    break;
                case "Corsican":
                    result = client.TranslateText(word, LanguageCodes.Corsican);
                    break;
                case "Croatian":
                    result = client.TranslateText(word, LanguageCodes.Croatian);
                    break;
                case "Czech":
                    result = client.TranslateText(word, LanguageCodes.Czech);
                    break;
                case "Danish":
                    result = client.TranslateText(word, LanguageCodes.Danish);
                    break;
                case "Dutch":
                    result = client.TranslateText(word, LanguageCodes.Dutch);
                    break;
                case "English":
                    result = client.TranslateText(word, LanguageCodes.English);
                    break;
                case "Esperanto":
                    result = client.TranslateText(word, LanguageCodes.Esperanto);
                    break;
                case "Estonian":
                    result = client.TranslateText(word, LanguageCodes.Estonian);
                    break;
                case "Filipino":
                    result = client.TranslateText(word, LanguageCodes.Filipino);
                    break;
                case "Finnish":
                    result = client.TranslateText(word, LanguageCodes.Finnish);
                    break;
                case "French":
                    result = client.TranslateText(word, LanguageCodes.French);
                    break;
                case "Frisian":
                    result = client.TranslateText(word, LanguageCodes.Frisian);
                    break;
                case "Galician":
                    result = client.TranslateText(word, LanguageCodes.Galician);
                    break;
                case "Georgian":
                    result = client.TranslateText(word, LanguageCodes.Georgian);
                    break;
                case "German":
                    result = client.TranslateText(word, LanguageCodes.German);
                    break;
                case "Greek":
                    result = client.TranslateText(word, LanguageCodes.Greek);
                    break;
                case "Gujarati":
                    result = client.TranslateText(word, LanguageCodes.Gujarati);
                    break;
                case "Haitian Creole":
                    result = client.TranslateText(word, LanguageCodes.HaitianCreole);
                    break;
                case "Hausa":
                    result = client.TranslateText(word, LanguageCodes.Hausa);
                    break;
                case "Hawaiian":
                    result = client.TranslateText(word, LanguageCodes.Hawaiian);
                    break;
                case "Hebrew":
                    result = client.TranslateText(word, LanguageCodes.Hebrew);
                    break;
                case "Hindi":
                    result = client.TranslateText(word, LanguageCodes.Hindi);
                    break;
                case "Hmong":
                    result = client.TranslateText(word, LanguageCodes.Hmong);
                    break;
                case "Hungarian":
                    result = client.TranslateText(word, LanguageCodes.Hungarian);
                    break;
                case "Icelandic":
                    result = client.TranslateText(word, LanguageCodes.Icelandic);
                    break;
                case "Igbo":
                    result = client.TranslateText(word, LanguageCodes.Igbo);
                    break;
                case "Indonesian":
                    result = client.TranslateText(word, LanguageCodes.Indonesian);
                    break;
                case "Irish":
                    result = client.TranslateText(word, LanguageCodes.Irish);
                    break;
                case "Italian":
                    result = client.TranslateText(word, LanguageCodes.Italian);
                    break;
                case "Japanese":
                    result = client.TranslateText(word, LanguageCodes.Japanese);
                    break;
                case "Javanese":
                    result = client.TranslateText(word, LanguageCodes.Javanese);
                    break;
                case "Kannada":
                    result = client.TranslateText(word, LanguageCodes.Kannada);
                    break;
                case "Kazakh":
                    result = client.TranslateText(word, LanguageCodes.Kazakh);
                    break;
                case "Khmer":
                    result = client.TranslateText(word, LanguageCodes.Khmer);
                    break;
                case "Korean":
                    result = client.TranslateText(word, LanguageCodes.Korean);
                    break;
                case "Kurdish (Kurmanji)":
                    result = client.TranslateText(word, LanguageCodes.KurdishKurmanji);
                    break;
                case "Kyrgyz":
                    result = client.TranslateText(word, LanguageCodes.Kyrgyz);
                    break;
                case "Lao":
                    result = client.TranslateText(word, LanguageCodes.Lao);
                    break;
                case "Latin":
                    result = client.TranslateText(word, LanguageCodes.Latin);
                    break;
                case "Latvian":
                    result = client.TranslateText(word, LanguageCodes.Latvian);
                    break;
                case "Lithuanian":
                    result = client.TranslateText(word, LanguageCodes.Lithuanian);
                    break;
                case "Luxembourgish":
                    result = client.TranslateText(word, LanguageCodes.Luxembourgish);
                    break;
                case "Macedonian":
                    result = client.TranslateText(word, LanguageCodes.Macedonian);
                    break;
                case "Malagasy":
                    result = client.TranslateText(word, LanguageCodes.Malagasy);
                    break;
                case "Malay":
                    result = client.TranslateText(word, LanguageCodes.Malay);
                    break;
                case "Malayalam":
                    result = client.TranslateText(word, LanguageCodes.Malayalam);
                    break;
                case "Maltese":
                    result = client.TranslateText(word, LanguageCodes.Maltese);
                    break;
                case "Maori":
                    result = client.TranslateText(word, LanguageCodes.Maori);
                    break;
                case "Marathi":
                    result = client.TranslateText(word, LanguageCodes.Marathi);
                    break;
                case "Mongolian":
                    result = client.TranslateText(word, LanguageCodes.Mongolian);
                    break;
                case "Nepali":
                    result = client.TranslateText(word, LanguageCodes.Nepali);
                    break;
                case "Norwegian (Bokmål)":
                    result = client.TranslateText(word, LanguageCodes.Norwegian);
                    break;
                case "Pashto":
                    result = client.TranslateText(word, LanguageCodes.Pashto);
                    break;
                case "Persian":
                    result = client.TranslateText(word, LanguageCodes.Persian);
                    break;
                case "Polish":
                    result = client.TranslateText(word, LanguageCodes.Polish);
                    break;
                case "Portuguese":
                    result = client.TranslateText(word, LanguageCodes.Portuguese);
                    break;
                case "Punjabi":
                    result = client.TranslateText(word, LanguageCodes.Punjabi);
                    break;
                case "Romanian":
                    result = client.TranslateText(word, LanguageCodes.Romanian);
                    break;
                case "Russian":
                    result = client.TranslateText(word, LanguageCodes.Russian);
                    break;
                case "Samoan":
                    result = client.TranslateText(word, LanguageCodes.Samoan);
                    break;
                case "Scots Gaelic":
                    result = client.TranslateText(word, LanguageCodes.ScotsGaelic);
                    break;
                case "Serbian":
                    result = client.TranslateText(word, LanguageCodes.Serbian);
                    break;
                case "Sesotho":
                    result = client.TranslateText(word, LanguageCodes.Sesotho);
                    break;
                case "Shona":
                    result = client.TranslateText(word, LanguageCodes.Shona);
                    break;
                case "Sindhi":
                    result = client.TranslateText(word, LanguageCodes.Sindhi);
                    break;
                case "Sinhala":
                    result = client.TranslateText(word, LanguageCodes.Sinhala);
                    break;
                case "Slovak":
                    result = client.TranslateText(word, LanguageCodes.Slovak);
                    break;
                case "Slovenian":
                    result = client.TranslateText(word, LanguageCodes.Slovenian);
                    break;
                case "Somali":
                    result = client.TranslateText(word, LanguageCodes.Somali);
                    break;
                case "Spanish":
                    result = client.TranslateText(word, LanguageCodes.Spanish);
                    break;
                case "Sundanese":
                    result = client.TranslateText(word, LanguageCodes.Sundanese);
                    break;
                case "Swahili":
                    result = client.TranslateText(word, LanguageCodes.Swahili);
                    break;
                case "Swedish":
                    result = client.TranslateText(word, LanguageCodes.Swedish);
                    break;
                case "Tajik":
                    result = client.TranslateText(word, LanguageCodes.Tajik);
                    break;
                case "Tamil":
                    result = client.TranslateText(word, LanguageCodes.Tamil);
                    break;
                case "Telugu":
                    result = client.TranslateText(word, LanguageCodes.Telugu);
                    break;
                case "Thai":
                    result = client.TranslateText(word, LanguageCodes.Thai);
                    break;
                case "Turkish":
                    result = client.TranslateText(word, LanguageCodes.Turkish);
                    break;
                case "Ukrainian":
                    result = client.TranslateText(word, LanguageCodes.Ukrainian);
                    break;
                case "Urdu":
                    result = client.TranslateText(word, LanguageCodes.Urdu);
                    break;
                case "Uzbek":
                    result = client.TranslateText(word, LanguageCodes.Uzbek);
                    break;
                case "Vietnamese":
                    result = client.TranslateText(word, LanguageCodes.Vietnamese);
                    break;
                case "Welsh":
                    result = client.TranslateText(word, LanguageCodes.Welsh);
                    break;
                case "Xhosa":
                    result = client.TranslateText(word, LanguageCodes.Xhosa);
                    break;
                case "Yiddish":
                    result = client.TranslateText(word, LanguageCodes.Yiddish);
                    break;
                case "Yoruba":
                    result = client.TranslateText(word, LanguageCodes.Yoruba);
                    break;
                case "Zulu":
                    result = client.TranslateText(word, LanguageCodes.Zulu);
                    break;
                default:
                    result = client.TranslateText(word, LanguageCodes.English);
                    break;
            }
            return $"{result.TranslatedText}";
        }

        /*
         * 
         * List<string> list = new List<string>();
            list = File.ReadAllLines(@"C:\Users\marti\OneDrive\Desktop\langs.txt").ToList();
            foreach (var item in list)
            {
                Console.Write("case \""+item+"\""+":\n" + "    result = client.TranslateText(word, LanguageCodes."+item+");\n" + "    break;\n");
            }
            Console.ReadKey();
         * 
         */
    }
}
