using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewProblems
{
    public class RandomArray
    {
        public static List<int> CreateRandomArray(int numberofelements)
        {
            Random rand = new Random();
            
            List<int> result = new List<int>();
            for (int i = 0; i < numberofelements; i++)
            {
                result.Add(rand.Next());
            }
            return result;
        }

        public static List<int> CreateRandomArrayWithUpperLimit(int numberofelements, int maxnumber)
        {
            Random rand = new Random();

            List<int> result = new List<int>();
            for (int i = 0; i < numberofelements; i++)
            {
                result.Add(rand.Next(maxnumber));
            }
            return result;
        }
    }
}
