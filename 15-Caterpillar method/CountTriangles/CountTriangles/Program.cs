// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;

namespace CountTriangles
{
    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            var x = GetNumberOfPossibleTriangles(new List<int> {10, 2, 5, 1, 8, 12});

            Console.WriteLine(x);
        }

        /// <summary>
        /// The get number of possible triangles.
        /// </summary>
        /// <param name="nums">
        /// The nums.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int GetNumberOfPossibleTriangles(List<int> nums)
        {
            var possibleTriangle = 0;
            for (var i = 0; i < nums.Count - 2; i++)
            {
                for (var j = i + 1; j < nums.Count - 1; j++)
                {
                    var k = j + 1;
                    if (nums[i] + nums[j] > nums[k] && nums[i] + nums[k] > nums[j] && nums[j] + nums[k] > nums[i])
                    {
                        possibleTriangle++;
                    }
                }
            }

            return possibleTriangle;
        }
    }
}