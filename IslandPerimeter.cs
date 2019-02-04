using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    //Accepted 
    //Runtime: 488 ms, faster than 27.27% of C# online submissions for Island Perimeter.
    class Program
    {
        static void Main(string[] args)
        {
            var twoDArray = new int[,] { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 0 }, { 1, 1, 0, 0 } };
            Console.WriteLine(IslandPerimeter(twoDArray));
            Console.ReadKey(); 
        }

        public static int IslandPerimeter(int[,] grid)
        {
            if (grid == null) return 0;
            if (grid.Length < 1) return 0;
            var count = 0;
            for (var i = 0; i < grid.GetLength(0); i++)
            {
                for (var j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 1)
                    {
                        //check right side
                        if (j == grid.GetLength(1) - 1) count++;
                        else if (j + 1 != grid.GetLength(1) && grid[i, j + 1] == 0) count++;

                        //check top side
                        if (i == 0) count++;
                        else if (i != 0 && grid[i - 1, j] == 0) count++;

                        //check left side
                        if (j == 0) count++;
                        else if (j != 0 && grid[i, j - 1] == 0) count++;

                        //check bottom side
                        if (i == grid.GetLength(0) - 1) count++;
                        else if (i != grid.GetLength(0) - 1 && grid[i + 1, j] == 0) count++;
                    }
                }
            }
            return count;
        }
    }
}
