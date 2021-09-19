using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    /// <summary>
    /// Represents the third problem in Project Euler
    /// </summary>
    public sealed class Problem3 : ISolution
    {
        #region Properties
        /// <summary>
        /// Represents the name of the third problem
        /// </summary>
        public string Name => "Largest prime factor";
        /// <summary>
        /// Represents the description of the third problem
        /// </summary>
        public string Description => $"The prime factors of 13195 are 5, 7, 13 and 29.{Environment.NewLine}" +
            $"What is the largest prime factor of the number 600851475143?";
        #endregion

        #region Constrcutors
        /// <summary>
        /// Initializes a new instance of <see cref="Problem3"/> class
        /// </summary>
        public Problem3()
        {
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Executes the algorithm of the third problem to get the solution
        /// </summary>
        /// <returns>A <see cref="string"/> object which represents the solution of the third problem</returns>
        public string Execute()
        {
            //TODO: Implement algorithm

            return "";
        }
        #endregion
    }
}
