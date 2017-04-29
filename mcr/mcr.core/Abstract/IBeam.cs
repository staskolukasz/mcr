namespace mcr.core
{
    /// <summary>
    /// IBeam interface
    /// </summary>
    public interface IBeam
    {
        /// <summary>
        /// Get the beam length in [cm]
        /// </summary>
        double GetL { get; }

        /// <summary>
        /// The Fluent Api getter
        /// </summary>
        IAddBeamCondition With
        {
            get;
        }
    }

    /// <summary>
    /// IAddBeamCondition interface for fluent api mechanism
    /// </summary>
    public interface IAddBeamCondition
    {
        /// <summary>
        /// Set the beam length in [cm]
        /// </summary>
        /// <param name="l">Beam length in [cm]</param>
        /// <returns></returns>
        void L(double l);
    }
}
