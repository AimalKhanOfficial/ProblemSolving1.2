using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    //Accepted
    //Runtime: 112 ms, faster than 30.00% of C# online submissions for Goat Latin.
    //Memory Usage: 9.4 MB, less than 0.00% of C# online submissions for Goat Latin.

    class Program
    {
        static void Main(string[] args)
        {
            //var res = CalPoints(new string[] { "5", "2", "C", "D", "+" });
            var res = ToGoatLatin("I speak Goat Latin");
            Console.WriteLine(res == "Imaa peaksmaaa oatGmaaaa atinLmaaaaa" ? true : false);
            res = ToGoatLatin("The quick brown fox jumped over the lazy dog");
            Console.WriteLine(res == "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa" ? true : false);
            Console.ReadKey(); 
        }

        public static string ToGoatLatin(string S)
        {
            if (S.Length <= 0) return S;
            var finalString = "";
            string[] allWords = S.Split(' ');
            var vowelsSet = new HashSet<string>() { "a", "e", "i", "o", "u" };
            int globalCounter = 1;
            var loopCounter = 0;
            for (var i = 0; i < allWords.Length; i++)
            {
                loopCounter = 0;
                if (!vowelsSet.Contains(allWords[i][0].ToString().ToLower()))
                {
                    if (allWords[i].Length < 1) continue;
                    allWords[i] = allWords[i].Substring(1, allWords[i].Length - 1) + allWords[i].ElementAt(0);
                }
                allWords[i] = allWords[i] + "ma";
                while (loopCounter < globalCounter)
                {
                    allWords[i] = allWords[i] + "a";
                    loopCounter++;
                }
                globalCounter++;
                finalString += allWords[i] + " ";
            }
            return finalString.Trim();
        }
    }
}
