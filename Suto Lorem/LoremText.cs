/*                  ___           ___           ___           ___
 *      ___        /__/\         /  /\         /__/\         /  /\    
 *     /  /\       \  \:\       /  /::\        \  \:\       /  /:/_   
 *    /  /:/        \__\:\     /  /:/\:\        \  \:\     /  /:/ /\  
 *   /  /:/     ___ /  /::\   /  /:/~/::\   _____\__\:\   /  /:/_/::\ 
 *  /  /::\    /__/\  /:/\:\ /__/:/ /:/\:\ /__/::::::::\ /__/:/__\/\:\
 * /__/:/\:\   \  \:\/:/__\/ \  \:\/:/__\/ \  \:\~~\~~\/ \  \:\ /~~/:/
 * \__\/  \:\   \  \::/       \  \::/       \  \:\  ~~~   \  \:\  /:/ 
 *      \  \:\   \  \:\        \  \:\        \  \:\        \  \:\/:/  
 *       \__\/    \  \:\        \  \:\        \  \:\        \  \::/   
 *                 \__\/         \__\/         \__\/         \__\/    
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutoLorem
{
    public class LoremText
    {
        const int NumberOfLastYears = 4;
        const int MinNumberOfWordsInSentence = 10;
        const int MaxNumberOfWordsInSentence = 16;
        const int MinNumberOfSentencesInParagraph = 3;
        const int MaxNumberOfSentencesInParagraph = 9;
        const int MinNumberOfWordsInTitle = 2;
        const int MaxNumberOfWordsInTitle = 7;

        public void SetWords(string words)
        {
            WordData.Words = words.Split(' ').ToList();
        }

        public void SetFirstnames(string names)
        {
            WordData.FirstNames = names.Split(' ').ToList();
        }

        public void SetLastnames(string names)
        {
            WordData.LastNames = names.Split(' ').ToList();
        }

        Random rand = new Random();
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

        public string GetEmail()
        {
            return GetFirstname() + "." + GetLastname() + WordData.EmailDomains.GetRandom();
        }

        public string GetDomain()
        {
            return WordData.Domains.GetRandom();
        }

        /// <summary>
        /// get random date within 4 years, but not later then 1/2 year ago
        /// </summary>
        /// <returns></returns>
        public DateTime GetDate()
        {
            return DateTime.Now - TimeSpan.FromDays(rand.Next(365 / 2, NumberOfLastYears * 365));
        }

        public string GetTitle()
        {
            return GetWords(rand.Next(MinNumberOfWordsInTitle, MaxNumberOfWordsInTitle));
        }

        public string GetSentence(int count = 1)
        {
            Contract.Requires(count > 0);

            List<string> sentence = new List<string>();

            for (int i = 0; i < count; i++)
            {
                sentence.Add(GetWords(rand.Next(MinNumberOfWordsInSentence, MaxNumberOfWordsInSentence)));
            }

            return string.Join(". ", sentence);
        }

        public string GetParagraph(int count = 1)
        {
            Contract.Requires(count > 0);

            List<string> para = new List<string>();

            for (int i = 0; i < count; i++)
            {
                para.Add(GetSentence(rand.Next(MinNumberOfSentencesInParagraph, MaxNumberOfSentencesInParagraph)));
            }

            return string.Join("\r\n\r\n", para);
        }
    }
}
