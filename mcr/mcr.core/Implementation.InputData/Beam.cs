namespace mcr.core
{
    /// <summary>
    /// Beam class
    /// </summary>
    internal class Beam : IBeam, IAddBeamCondition
    {
        private double _L;

        /// <summary>
        /// Get the beam length in [cm]
        /// </summary>
        public double GetL
        {
            get
            {
                return _L;
            }
        }

        /// <summary>
        /// The Fluent Api getter
        /// </summary>
        public IAddBeamCondition With
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        /// Set the beam length in [cm]
        /// </summary>
        /// <param name="l">Beam length in [cm]</param>
        /// <returns></returns>
        public void L(double l)
        {
            _L = l;
        } 
    }
}
