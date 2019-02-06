using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    class Program
    {
        //Runtime: 116 ms, faster than 41.08% of C# online submissions for Unique Morse Code Words.
        //Memory Usage: 10.1 MB, less than 11.94% of C# online submissions for Unique Morse Code Words.
        static void Main(string[] args)
        {
            var res = UniqueMorseRepresentations(new string[] { "gin", "zen", "gig", "msg" });
            Console.ReadKey();
        }

        public static int UniqueMorseRepresentations(string[] words)
        {
            var hashSet = new HashSet<String>();
            var dict = new Dictionary<string, string>() {
                { "a", ".-" },
                { "b", "-..." },
                { "c", "-.-." },
                { "d", "-.." },
                { "e", "." },
                { "f", "..-." },
                { "g", "--." },
                { "h", "...." },
                { "i", ".." },
                { "j", ".---" },
                { "k", "-.-" },
                { "l", ".-.." },
                { "m", "--" },
                { "n", "-." },
                { "o", "---" },
                { "p", ".--." },
                { "q", "--.-" },
                { "r", ".-." },
                { "s", "..." },
                { "t", "-" },
                { "u", "..-" },
                { "v", "...-" },
                { "w", ".--" },
                { "x", "-..-" },
                { "y", "-.--" },
                { "z", "--.." }
            };
            var tmp = "";
            for (var i = 0; i < words.Length; i++)
            {
                tmp = "";
                for (var j = 0; j < words[i].Length; j++)
                {
                    tmp += dict[words[i][j].ToString()];
                }
                if (!hashSet.Contains(tmp)) hashSet.Add(tmp);
            }
            return hashSet.Count;
        }
    }
}
