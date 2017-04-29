namespace mcr.core
{
    /// <summary>
    /// The ILoad interface
    /// </summary>
    public interface ILoad
    {
        /// <summary>
        /// Get the Q1 force object
        /// </summary>
        IForce GetQ1
        {
            get;
        }

        /// <summary>
        /// Get the Q2 force object
        /// </summary>
        IForce GetQ2
        {
            get;
        }

        /// <summary>
        /// The Fluent Api getter for Q1
        /// </summary>
        IAddQ1Condition WithQ1 { get; }

        /// <summary>
        /// The Fluent Api getter for Q1
        /// </summary>
        IAddQ2Condition WithQ2 { get; }
    }

    /// <summary>
    /// IForce interface
    /// </summary>
    public interface IForce
    {
        /// <summary>
        /// Get the value in [kN]
        /// </summary>
        double GetValue
        {
            get;
        }

        /// <summary>
        /// Get the position in [cm]
        /// </summary>
        double GetPosition
        {
            get;
        }

        /// <summary>
        /// Get the application level in [cm]
        /// </summary>
        double GetApplicationLevel
        {
            get;
        }
    }

    /// <summary>
    /// IAddQCondition base interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAddQCondition<T>
    {
        /// <summary>
        /// Set the value in [kN]
        /// </summary>
        /// <param name="value">Force value</param>
        /// <returns></returns>
        T Value(double value);

        /// <summary>
        /// Set the position in [cm]
        /// </summary>
        /// <param name="position">Position along the beam</param>
        /// <returns></returns>
        T Position(double position);

        /// <summary>
        /// Set the load application level in [cm]
        /// </summary>
        /// <param name="applicationLevel">Application level with respect to the shear centre</param>
        /// <returns></returns>
        T ApplicationLevel(double applicationLevel);
    }

    /// <summary>
    /// IAddQ1Condition interface for fluent api mechanism
    /// </summary>
    public interface IAddQ1Condition : IAddQCondition<IAddQ1Condition> { }

    /// <summary>
    /// IAddQ2Condition interface for fluent api mechanism
    /// </summary>
    public interface IAddQ2Condition : IAddQCondition<IAddQ2Condition> { }
}

