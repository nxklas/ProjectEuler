using System;

namespace ProjectEuler.Solutions
{
    /// <summary>
    /// Represents the first problem in Project Euler
    /// </summary>
    public sealed class Problem1 : ISolution
    {
        #region Properties
        /// <summary>
        /// Represents the name of the first problem
        /// </summary>
        public string Name => "Multiples of 3 or 5";
        /// <summary>
        /// Represents the description of the first problem
        /// </summary>
        public string Description => $"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.{Environment.NewLine}" +
            $"The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.";
        #endregion

        #region Constrcutors
        /// <summary>
        /// Initializes a new instance of <see cref="Problem1"/> class
        /// </summary>
        public Problem1()
        {
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Executes the algorithm of the first problem to get the solution
        /// </summary>
        /// <returns>A <see cref="string"/> object which represents the solution of the first problem</returns>
        public string Execute()
        {
            int result = 0;

            for (int i = 1; i < 1000; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            return result.ToString();
        }
        #endregion
    }
}
