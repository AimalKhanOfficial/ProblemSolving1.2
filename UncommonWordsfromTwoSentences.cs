using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProblemSolvingTemplateProject
{
    //Accepted.
    //Runtime: 296 ms, faster than 61.29% of C# online submissions for Uncommon Words from Two Sentences.
    class Program
    {
        static void Main(string[] args)
        {
            var x = UncommonFromSentences("s z z z s", "s z ejt");
            var y = UncommonFromSentences("this apple is sweet", "this apple is sour");
            var z = UncommonFromSentences("apple apple", "banana");
            Console.Read();
        }

        public static string[] UncommonFromSentences(string A, string B)
        {
            var initASplit = A.Split(' ');
            var initBSplit = B.Split(' ');
            var finalWords = new string[initASplit.Length + initBSplit.Length];

            for (var i = 0; i < initASplit.Length; i++)
            {
                finalWords[i] = initASplit[i];
            }

            for (var i = initASplit.Length; i < (initASplit.Length + initBSplit.Length); i++)
            {
                finalWords[i] = initBSplit[i - initASplit.Length];
            }

            var doesExist = false;
            var unCommonWords = new List<string>();

            for (var i = 0; i < finalWords.Length; i++)
            {
                doesExist = false;
                var word = finalWords[i];

                for (var j = 0; j < finalWords.Length; j++)
                {
                    var wordJ = finalWords[j];
                    if (finalWords[i] == finalWords[j] && i != j)
                    {
                        doesExist = true;
                        break;
                    }
                }

                if (!doesExist)
                {
                    unCommonWords.Add(finalWords[i]);
                }
            }
            
            return unCommonWords.ToArray();
        }
    }
}
