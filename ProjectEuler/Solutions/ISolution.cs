namespace ProjectEuler.Solutions
{
    /// <summary>
    /// The interface for Project Euler solutions
    /// </summary>
    public interface ISolution
    {
        #region Properties
        /// <summary>
        /// Represents the name of the specific solution
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Represents the description of the specific solution
        /// </summary>
        public string Description { get; }
        #endregion

        #region Public methods
        /// <summary>
        /// Executes a specific algorithm to get the solution to the problem
        /// </summary>
        /// <returns>A <see cref="string"/> object which represents the solution of the problem</returns>
        public string Execute();
        #endregion
    }
}
