namespace mcr.core
{
    /// <summary>
    /// IMomentDistribution interface
    /// </summary>
    public interface IMomentDistribution
    {
        /// <summary>
        /// Get the bending moment M0 in [kNm]
        /// </summary>
        double GetM0
        {
            get;
        }

        /// <summary>
        /// Get the bending moment M1 in [kNm]
        /// </summary>
        double GetM1
        {
            get;
        }

        /// <summary>
        /// Get the bending moment M2 in [kNm]
        /// </summary>
        double GetM2
        {
            get;
        }

        /// <summary>
        /// Get the bending moment M3 in [kNm]
        /// </summary>
        double GetM3
        {
            get;
        }

        /// <summary>
        /// Get the bending moment M4 in [kNm]
        /// </summary>
        double GetM4
        {
            get;
        }

        /// <summary>
        /// Get the bending moment M5 in [kNm]
        /// </summary>
        double GetM5
        {
            get;
        }

        /// <summary>
        /// The Fluent Api getter
        /// </summary>
        IAddMomentDistributionCondition With
        {
            get;
        }
    }

    /// <summary>
    /// IAddMomentDistributionCondition interface
    /// </summary>
    public interface IAddMomentDistributionCondition
    {


        /// <summary>
        /// Set the bending moment M0 in [kNm]
        /// </summary>
        /// <param name="m0">Bending moment M0</param>
        /// <returns></returns>
        IAddMomentDistributionCondition M0(double m0);

        /// <summary>
        /// Set the bending moment M1 in [kNm]
        /// </summary>
        /// <param name="m1">Bending moment M1</param>
        /// <returns></returns>
        IAddMomentDistributionCondition M1(double m1);

        /// <summary>
        /// Set the bending moment M2 in [kNm]
        /// </summary>
        /// <param name="m2">Bending moment M2</param>
        /// <returns></returns>
        IAddMomentDistributionCondition M2(double m2);

        /// <summary>
        /// Set the bending moment M3 in [kNm]
        /// </summary>
        /// <param name="m3">Bending moment M3</param>
        /// <returns></returns>
        IAddMomentDistributionCondition M3(double m3);

        /// <summary>
        /// Set the bending moment M4 in [kNm]
        /// </summary>
        /// <param name="m4">Bending moment M4</param>
        /// <returns></returns>
        IAddMomentDistributionCondition M4(double m4);

        /// <summary>
        /// Set the bending moment M5 in [kNm]
        /// </summary>
        /// <param name="m5">Bending moment M5</param>
        /// <returns></returns>
        IAddMomentDistributionCondition M5(double m5);
    }
}
