namespace mcr.core
{
    /// <summary>
    /// Material class
    /// </summary>
    internal class Material : IMaterial, IAddMaterialCondition
    {
        private double _E;

        private double _G;

        /// <summary>
        /// Get the Young Modulus in [kN/cm2]
        /// </summary>
        public double GetE
        {
            get
            {
                return _E;
            }
        }

        /// <summary>
        /// Get the Shear Modulus in [kN/cm2]
        /// </summary>
        public double GetG
        {
            get
            {
                return _G;
            }
        }

        /// <summary>
        /// The Fluent Api getter
        /// </summary>
        public IAddMaterialCondition With
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        /// Set the E in [kN/cm2]
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public IAddMaterialCondition E(double e)
        {
            _E = e;
            return this;
        }

        /// <summary>
        /// Set the G in [kN/cm2]
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public IAddMaterialCondition G(double g)
        {
            _G = g;
            return this;
        }
    }
}
