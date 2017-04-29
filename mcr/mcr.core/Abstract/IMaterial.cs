namespace mcr.core
{
    /// <summary>
    /// IMaterial interface
    /// </summary>
    public interface IMaterial
    {
        /// <summary>
        /// Get the Young Modulus in [kN/cm2]
        /// </summary>
        double GetE { get; }

        /// <summary>
        /// Get the Shear Modulus in [kN/cm2]
        /// </summary>
        double GetG { get; }

        /// <summary>
        /// The Fluent Api getter
        /// </summary>
        IAddMaterialCondition With
        {
            get;
        }
    }

    /// <summary>
    /// IAddMaterialCondition interface for fluent api mechanism
    /// </summary>
    public interface IAddMaterialCondition
    {
        /// <summary>
        /// Set the E in [kN/cm2]
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        IAddMaterialCondition E(double e);

        /// <summary>
        /// Set the G in [kN/cm2]
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        IAddMaterialCondition G(double g);
    }
}
