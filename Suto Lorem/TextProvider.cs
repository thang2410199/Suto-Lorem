using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutoLorem
{
    public class TextProvider
    {
        const int NumberOfLastYears = 4;
        const int MinNumberOfWordsInSentence = 4;
        const int MaxNumberOfWordsInSentence = 16;
        const int MinNumberOfSentencesInParagraph = 3;
        const int MaxNumberOfSentencesInParagraph = 9;
        const int MinNumberOfWordsInTitle = 2;
        const int MaxNumberOfWordsInTitle = 7;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameof(count)"></param>
        /// <returns></returns>
        public string GetWords(int count = 1)
        {
            Contract.Requires(count > 0);

            List<string> words = new List<string>();

            for (int i = 0; i < count; i++)
            {
                words.Add(WordData.Words.GetRandom());
            }

            return string.Join(" ", words);
        }

        public string GetFullname()
        {
            return WordData.FirstNames.GetRandom() + " " + WordData.LastNames.GetRandom();
        }

        public string GetFirstname()
        {
            return WordData.FirstNames.GetRandom();
        }

        public string GetLastname()
        {
            return WordData.LastNames.GetRandom();
        }
    }
}
