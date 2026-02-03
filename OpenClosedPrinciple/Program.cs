using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  1  2  3
             *  4  5  6
             *  7  8  9
             *   1 2 3 4 5 6 7 8 9
             *   No more than 2 loops
             * */

            int[][] matrix = new int[4][];

            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 4, 5, 6 };
            matrix[2] = new int[] { 7, 8, 9 };
            matrix[3] = new int[] { 17, 18, 19 };

            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int totEle = rows * cols;

            for (int i = 0; i < totEle; i++)
            {
                int rowEle = i / cols;
                int colEle = i % cols;
                Console.Write("{0}\t", matrix[rowEle][colEle]);
            }
        }
    }
}
