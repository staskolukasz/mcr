namespace mcr.core
{
    /// <summary>
    /// MomentDistribution class
    /// </summary>
    internal class MomentDistribution : IMomentDistribution, IAddMomentDistributionCondition
    {
        private double _M0;

        private double _M1;

        private double _M2;

        private double _M3;

        private double _M4;

        private double _M5;

        /// <summary>
        /// Get the bending moment M0 in [kNm]
        /// </summary>
        public double GetM0
        {
            get
            {
                return _M0;
            }
        }

        /// <summary>
        /// Get the bending moment M1 in [kNm]
        /// </summary>
        public double GetM1
        {
            get
            {
                return _M1;
            }
        }

        /// <summary>
        /// Get the bending moment M2 in [kNm]
        /// </summary>
        public double GetM2
        {
            get
            {
                return _M2;
            }
        }

        /// <summary>
        /// Get the bending moment M3 in [kNm]
        /// </summary>
        public double GetM3
        {
            get
            {
                return _M3;
            }
        }

        /// <summary>
        /// Get the bending moment M4 in [kNm]
        /// </summary>
        public double GetM4
        {
            get
            {
                return _M4;
            }
        }

        /// <summary>
        /// Get the bending moment M5 in [kNm]
        /// </summary>
        public double GetM5
        {
            get
            {
                return _M5;
            }
        }

        /// <summary>
        /// The Fluent Api getter
        /// </summary>
        public IAddMomentDistributionCondition With
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        /// Set the bending moment M0 in [kNm]
        /// </summary>
        /// <param name="m0">Bending moment M0</param>
        /// <returns></returns>
        public IAddMomentDistributionCondition M0(double m0)
        {
            _M0 = m0;
            return this;
        }

        /// <summary>
        /// Set the bending moment M1 in [kNm]
        /// </summary>
        /// <param name="m1">Bending moment M1</param>
        /// <returns></returns>
        public IAddMomentDistributionCondition M1(double m1)
        {
            _M1 = m1;
            return this;
        }

        /// <summary>
        /// Set the bending moment M2 in [kNm]
        /// </summary>
        /// <param name="m2">Bending moment M2</param>
        /// <returns></returns>
        public IAddMomentDistributionCondition M2(double m2)
        {
            _M2 = m2;
            return this;
        }

        /// <summary>
        /// Set the bending moment M3 in [kNm]
        /// </summary>
        /// <param name="m3">Bending moment M3</param>
        /// <returns></returns>
        public IAddMomentDistributionCondition M3(double m3)
        {
            _M3 = m3;
            return this;
        }

        /// <summary>
        /// Set the bending moment M4 in [kNm]
        /// </summary>
        /// <param name="m4">Bending moment M4</param>
        /// <returns></returns>
        public IAddMomentDistributionCondition M4(double m4)
        {
            _M4 = m4;
            return this;
        }

        /// <summary>
        /// Set the bending moment M5 in [kNm]
        /// </summary>
        /// <param name="m5">Bending moment M5</param>
        /// <returns></returns>
        public IAddMomentDistributionCondition M5(double m5)
        {
            _M5 = m5;
            return this;
        }
    }
}
