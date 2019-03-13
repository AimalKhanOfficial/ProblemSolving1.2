using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTemplateProject
{
    /// <summary>
    /// Runtime: 252 ms, faster than 99.37% of C# online submissions for Keyboard Row.
    /// Memory Usage: 28.3 MB, less than 16.67% of C# online submissions for Keyboard Row.
    /// </summary>
    
    class Program
    {
        public static void Main(string[] args)
        {
            var count = FindWords(new string[] { "Hello", "Alaska", "Dad", "Peace" }); 
            Console.ReadKey();
        }

        public static string[] FindWords(string[] words)
        {
            if (words.Length == 0) return new string[0];
            var finalListOfWords = new List<string>();
            char[] charactersUnderExperiment = null;
            var indexForFirst = 0;
            var indexForOthers = 0;
            var shouldIAddTheWord = true;
            var keyboardText = new char[3][] { new char[] { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P' }, new char[] { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L' }, new char[] { 'Z', 'X', 'C', 'V', 'B', 'N', 'M' } };
            for (var i = 0; i < words.Length; i++)
            {
                charactersUnderExperiment = words[i].ToUpper().ToCharArray();

                shouldIAddTheWord = true;

                if (keyboardText[0].Contains(charactersUnderExperiment[0]))
                    indexForFirst = 0;
                else if (keyboardText[1].Contains(charactersUnderExperiment[0]))
                    indexForFirst = 1;
                else if (keyboardText[2].Contains(charactersUnderExperiment[0]))
                    indexForFirst = 2;

                for (var j = 1; j < charactersUnderExperiment.Length; j++)
                {
                    if (keyboardText[0].Contains(charactersUnderExperiment[j]))
                        indexForOthers = 0;
                    else if (keyboardText[1].Contains(charactersUnderExperiment[j]))
                        indexForOthers = 1;
                    else if (keyboardText[2].Contains(charactersUnderExperiment[j]))
                        indexForOthers = 2;

                    if (indexForOthers != indexForFirst)
                    {
                        shouldIAddTheWord = false;
                        break;
                    }
                }

                if (shouldIAddTheWord) finalListOfWords.Add(words[i]);
            }
            return finalListOfWords.ToList().ToArray();
        }
    }
}
