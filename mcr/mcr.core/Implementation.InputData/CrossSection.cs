namespace mcr.core
{
    /// <summary>
    /// CrossSection class
    /// </summary>
    internal class CrossSection : ICrossSection, IAddCrossSectionCondition
    {
        private double _Iz;

        private double _It;

        private double _Iw;

        /// <summary>
        /// Get the moment of inertia (weak axis) in [cm4]
        /// </summary>
        public double GetIz
        {
            get
            {
                return _Iz;
            }
        }

        /// <summary>
        /// Get the St Venant torsional constant in [cm4]
        /// </summary>
        public double GetIt
        {
            get
            {
                return _It;
            }
        }

        /// <summary>
        /// Get the torsional constant in [cm6]
        /// </summary>
        public double GetIw
        {
            get
            {
                return _Iw;
            }
        }

        /// <summary>
        /// The Fluent Api getter
        /// </summary>
        public IAddCrossSectionCondition With
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        /// Set the moment of inertia (weak axis) in [cm4]
        /// </summary>
        /// <param name="iz"></param>
        /// <returns></returns>
        public IAddCrossSectionCondition Iz(double iz)
        {
            _Iz = iz;
            return this;
        }

        /// <summary>
        /// Set the St Venant torsional constant in [cm4]
        /// </summary>
        /// <param name="it"></param>
        /// <returns></returns>
        public IAddCrossSectionCondition It(double it)
        {
            _It = it;
            return this;
        }

        /// <summary>
        /// Set the torsional constant in [cm6]
        /// </summary>
        /// <param name="iw"></param>
        /// <returns></returns>
        public IAddCrossSectionCondition Iw(double iw)
        {
            _Iw = iw;
            return this;
        }
    }
}
