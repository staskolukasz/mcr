namespace mcr.core
{
    /// <summary>
    /// Context class for strategy pattern
    /// </summary>
    internal class Context
    {
        private IMcrClc _mcr;

        public Context(IMcrClc mcr)
        {
            _mcr = mcr;
        }

        /// <summary>
        /// Calculate the specified factor
        /// </summary>
        /// <param name="_factor">Instance of IFactor interface</param>
        /// <returns>Value of specified factor</returns>
        public double Calculate(IFactor _factor)
        {
            return _factor.GetFactor(_mcr);
        }
    }
}
