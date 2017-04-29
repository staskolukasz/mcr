namespace mcr.core
{
    /// <summary>
    /// ICrossSection interface
    /// </summary>
    public interface ICrossSection
    {
        /// <summary>
        /// Get the moment of inertia (weak axis) in [cm4]
        /// </summary>
        double GetIz { get; }

        /// <summary>
        /// Get the St Venant torsional constant in [cm4]
        /// </summary>
        double GetIt { get; }

        /// <summary>
        /// Get the torsional constant in [cm6]
        /// </summary>
        double GetIw { get; }

        /// <summary>
        /// The Fluent Api getter
        /// </summary>
        IAddCrossSectionCondition With
        {
            get;
        }
    }

    /// <summary>
    /// IAddCrossSectionCondition interface for fluent api mechanism
    /// </summary>
    public interface IAddCrossSectionCondition
    {
        /// <summary>
        /// Set the moment of inertia (weak axis) in [cm4]
        /// </summary>
        /// <param name="iz"></param>
        /// <returns></returns>
        IAddCrossSectionCondition Iz(double iz);

        /// <summary>
        /// Set the St Venant torsional constant in [cm4]
        /// </summary>
        /// <param name="it"></param>
        /// <returns></returns>
        IAddCrossSectionCondition It(double it);

        /// <summary>
        /// Set the torsional constant in [cm6]
        /// </summary>
        /// <param name="iw"></param>
        /// <returns></returns>
        IAddCrossSectionCondition Iw(double iw);
    }
}
