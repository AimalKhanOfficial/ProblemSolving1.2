using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    class Program
    {
        //Runtime: 96 ms, faster than 70.94% of C# online submissions for Robot Return to Origin.
        //Memory Usage: 11.4 MB, less than 31.31% of C# online submissions for Robot Return to Origin.
        static void Main(string[] args)
        {
            Console.WriteLine(JudgeCircle("RDLU"));
            Console.ReadKey();
        }

        public static bool JudgeCircle(string moves)
        {
            var x = 0;
            var y = 0;
            for (var i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'D')
                {
                    y++;
                }
                else if (moves[i] == 'U')
                {
                    y -= 1;
                }
                else if (moves[i] == 'L')
                {
                    x -= 1;
                }
                else if (moves[i] == 'R')
                {
                    x++;
                }
            }
            return (x == 0 && y == 0) ? true : false;
        }
    }
}
