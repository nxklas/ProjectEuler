using static ProjectEuler.Helpers.ReflectiveEnumerator;
using ProjectEuler.Solutions;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Provides functionalities to execute and print Project Euler solutions
    /// </summary>
    public static class SolutionExecutor
    {
        /// <summary>
        /// Executes the specific solution and prints it
        /// </summary>
        /// <param name="writer">The writer which indicates where to write the solution (<see cref="Console.Out"/>)</param>
        /// <param name="solution">The solution to execute</param>
        public static void Execute(this TextWriter writer, ISolution solution)
        {
            writer.WriteLine($"Problem: {solution.Name}{Environment.NewLine}");
            writer.WriteLine($"The problem:{Environment.NewLine}{solution.Description}{Environment.NewLine}");
            writer.WriteLine($"Output: {solution.Execute()}");
        }

        /// <summary>
        /// Executes all solutions and prints them
        /// </summary>
        /// <param name="writer">The writer which indicates where to write the solutions (<see cref="Console.Out"/>)</param>
        public static void ExecuteAllSolutions(this TextWriter writer)
        {
            IEnumerable<ISolution> solutions = GetImplementationsOfType<ISolution>();
            ISolution lastSolution = solutions.LastOrDefault();

            foreach (ISolution currentSolution in solutions)
            {
                writer.Execute(currentSolution);

                if (currentSolution != lastSolution)
                {
                    writer.WriteLine();
                    writer.WriteLine();
                }
            }
        }
    }
}
