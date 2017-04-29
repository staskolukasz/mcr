namespace mcr.core
{
    /// <summary>
    /// IMcrClc main interface
    /// </summary>
    public interface IMcrClc
    {
        /// <summary>
        /// Beam material properties
        /// </summary>
        IMaterial Material { get; }

        /// <summary>
        /// Beam cross seciton properties
        /// </summary>
        ICrossSection CrossSection { get; }

        /// <summary>
        /// Beam properties
        /// </summary>
        IBeam Beam { get; }

        /// <summary>
        /// Load properties
        /// </summary>
        ILoad Load { get; }

        /// <summary>
        /// Moment distribution properties
        /// </summary>
        IMomentDistribution MomentDistribution { get; }

        /// <summary>
        /// Ncrz class (critical load with respect to weak axis) in [kN]
        /// </summary>
        double Ncrz { get; }

        /// <summary>
        /// D factor in [cm2]
        /// </summary>
        double D { get; }

        /// <summary>
        /// C1 factor
        /// </summary>
        double C1 { get; }

        /// <summary>
        /// d2 factor (helper for C2 factor)
        /// </summary>
        double d2 { get; }

        /// <summary>
        /// d3 factor (helper for C2 factor)
        /// </summary>
        double d3 { get; }

        /// <summary>
        /// a2 factor (helper for C2 factor)
        /// </summary>
        double a2 { get; }

        /// <summary>
        /// C2 factor
        /// </summary>
        double C2 { get; }

        /// <summary>
        /// Lateral-torsional buckling moment in [kNcm]
        /// </summary>
        double Mcr { get; }
    }
}
