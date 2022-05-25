using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilda.Muitine.Resources
{
    public enum Cases
    {
        /// <summary>
        /// Kilmininkas (ko?)
        /// </summary>
        Genitive,
        /// <summary>
        /// Naudininkas (kam?)
        /// </summary>
        Dative,
        /// <summary>
        /// Galininkas (ką?)
        /// </summary>
        Accusative,
        /// <summary>
        /// įnagininkas (kuo?)
        /// </summary>
        Ablative,
        /// <summary>
        /// Vietininkas (kur? kame?)
        /// </summary>
        Locative,
        /// <summary>
        /// Šauksmininkas
        /// </summary>
        Vocative
    }

    public static class CasesOfPrompts
    {
        public static string ConvertPromptByCase(Cases promptCase, string prompt)
        {
            string result = prompt;
            if (!string.IsNullOrEmpty(prompt))
            {
                switch (promptCase)
                {
                    case Cases.Genitive:
                        result = TransformToGenitive(prompt); break;
                    case Cases.Dative:
                        result = TransformToDative(prompt); break;
                    case Cases.Accusative:
                        result = TransformToAccusative(prompt); break;
                    case Cases.Ablative:
                        result = TransformToAblative(prompt); break;
                    case Cases.Locative:
                        result = TransformToLocative(prompt); break;
                    case Cases.Vocative:
                        result = TransformToVocative(prompt); break;
                    default:
                        result = prompt; break;
                }
            }
            return result;
        }

        private static string TransformToGenitive(string input)
        {
            if (input.EndsWith("a")) return ReplaceLastOccurrence(input, "a", "os");
            if (input.EndsWith("as")) return ReplaceLastOccurrence(input, "as", "o");
            if (input.EndsWith("ė")) return ReplaceLastOccurrence(input, "ė", "ės");
            if (input.EndsWith("tis")) return ReplaceLastOccurrence(input, "tis", "čio");
            if (input.EndsWith("dis")) return ReplaceLastOccurrence(input, "dis", "džio");
            if (input.EndsWith("is")) return ReplaceLastOccurrence(input, "is", "io");
            if (input.EndsWith("us")) return ReplaceLastOccurrence(input, "us", "aus");
            if (input.EndsWith("tys")) return ReplaceLastOccurrence(input, "tys", "čio");
            if (input.EndsWith("dys")) return ReplaceLastOccurrence(input, "dys", "džio");
            if (input.EndsWith("ys")) return ReplaceLastOccurrence(input, "ys", "io");
            return input;
        }

        private static string TransformToDative(string input)
        {
            if (input.EndsWith("a")) return ReplaceLastOccurrence(input, "a", "ai");
            if (input.EndsWith("as")) return ReplaceLastOccurrence(input, "as", "ui");
            if (input.EndsWith("ė")) return ReplaceLastOccurrence(input, "ė", "ei");
            if (input.EndsWith("tis")) return ReplaceLastOccurrence(input, "tis", "čiui");
            if (input.EndsWith("dis")) return ReplaceLastOccurrence(input, "dis", "džiui");
            if (input.EndsWith("is")) return ReplaceLastOccurrence(input, "is", "iui");
            if (input.EndsWith("us")) return ReplaceLastOccurrence(input, "us", "ui");
            if (input.EndsWith("tys")) return ReplaceLastOccurrence(input, "tys", "čiui");
            if (input.EndsWith("dys")) return ReplaceLastOccurrence(input, "dys", "džiui");
            if (input.EndsWith("ys")) return ReplaceLastOccurrence(input, "ys", "iui");
            return input;
        }

        private static string TransformToAccusative(string input)
        {
            if (input.EndsWith("a")) return ReplaceLastOccurrence(input, "a", "ą");
            if (input.EndsWith("as")) return ReplaceLastOccurrence(input, "as", "ą");
            if (input.EndsWith("ė")) return ReplaceLastOccurrence(input, "ė", "ę");
            if (input.EndsWith("is")) return ReplaceLastOccurrence(input, "is", "į");
            if (input.EndsWith("us")) return ReplaceLastOccurrence(input, "us", "ų");
            if (input.EndsWith("ys")) return ReplaceLastOccurrence(input, "ys", "į");
            return input;
        }

        private static string TransformToAblative(string input)
        {
            if (input.EndsWith("a")) return ReplaceLastOccurrence(input, "a", "a");
            if (input.EndsWith("as")) return ReplaceLastOccurrence(input, "as", "u");
            if (input.EndsWith("ė")) return ReplaceLastOccurrence(input, "ė", "e");
            if (input.EndsWith("tis")) return ReplaceLastOccurrence(input, "tis", "čiu");
            if (input.EndsWith("dis")) return ReplaceLastOccurrence(input, "dis", "džiu");
            if (input.EndsWith("is")) return ReplaceLastOccurrence(input, "is", "iu");
            if (input.EndsWith("us")) return ReplaceLastOccurrence(input, "us", "u");
            if (input.EndsWith("tys")) return ReplaceLastOccurrence(input, "tys", "čiu");
            if (input.EndsWith("dys")) return ReplaceLastOccurrence(input, "dys", "džiu");
            if (input.EndsWith("ys")) return ReplaceLastOccurrence(input, "ys", "iu");
            return input;
        }

        private static string TransformToLocative(string input)
        {
            if (input.EndsWith("a")) return ReplaceLastOccurrence(input, "a", "oje");
            if (input.EndsWith("as")) return ReplaceLastOccurrence(input, "as", "e");
            if (input.EndsWith("ė")) return ReplaceLastOccurrence(input, "ė", "ėje");
            if (input.EndsWith("is")) return ReplaceLastOccurrence(input, "is", "yje");
            if (input.EndsWith("us")) return ReplaceLastOccurrence(input, "us", "uje");
            if (input.EndsWith("ys")) return ReplaceLastOccurrence(input, "ys", "yje");
            return input;
        }

        private static string TransformToVocative(string input)
        {
            if (input.EndsWith("a")) return ReplaceLastOccurrence(input, "a", "a");
            if (input.EndsWith("as")) return ReplaceLastOccurrence(input, "as", "ai");
            if (input.EndsWith("ė")) return ReplaceLastOccurrence(input, "ė", "e");
            if (input.EndsWith("is")) return ReplaceLastOccurrence(input, "is", "i");
            if (input.EndsWith("us")) return ReplaceLastOccurrence(input, "us", "au");
            if (input.EndsWith("ys")) return ReplaceLastOccurrence(input, "ya", "y");
            return input;
        }

        private static string ReplaceLastOccurrence(string source, string find, string replace)
        {
            int place = source.LastIndexOf(find);

            if (place == -1)
                return source;

            string result = source.Remove(place, find.Length).Insert(place, replace);
            return result;
        }

    }
}
