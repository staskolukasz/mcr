using System;

namespace mcr.core
{
    /// <summary>
    /// Ncrz class (critical load with respect to the weak axis) in [kN]
    /// </summary>
    internal class Ncrz : IFactor
    {
        /// <summary>
        /// Get the Ncrz in [kN]
        /// </summary>
        /// <param name="_mcr">Instance of McrClc class</param>
        /// <returns>Nrz in [kN]</returns>
        public double GetFactor(IMcrClc _mcr)
        {
            try
            {
                double result = Math.Pow(Math.PI, 2) * _mcr.Material.GetE * _mcr.CrossSection.GetIz / Math.Pow(_mcr.Beam.GetL, 2);

                return Math.Round(result, 3);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }

    /// <summary>
    /// DFactor class
    /// </summary>
    internal class DFactor : IFactor
    {
        /// <summary>
        /// Get the D factor in [cm2]
        /// </summary>
        /// <param name="_mcr">Instance of McrClc class</param>
        /// <returns>D factor in [cm2]</returns>
        public double GetFactor(IMcrClc _mcr)
        {
            try
            {
                double c1 = _mcr.CrossSection.GetIw / _mcr.CrossSection.GetIz;
                double c2 = _mcr.Material.GetG / (_mcr.Material.GetE * Math.Pow(Math.PI, 2));
                double c3 = _mcr.CrossSection.GetIt * Math.Pow(_mcr.Beam.GetL, 2) / _mcr.CrossSection.GetIz;

                double result = c1 + (c2 * c3);

                return Math.Round(result, 3);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }

    /// <summary>
    /// C1Factor class
    /// </summary>
    internal class C1Factor : IFactor
    {
        /// <summary>
        /// Get the C1 factor
        /// </summary>
        /// <param name="_mcr">Instance of McrClc class</param>
        /// <returns>C1 factor</returns>
        public double GetFactor(IMcrClc _mcr)
        {
            try
            {
                double component = Math.Pow(_mcr.MomentDistribution.GetM0, 2)
                    + 6 * Math.Pow(_mcr.MomentDistribution.GetM2, 2)
                    + 8 * Math.Pow(_mcr.MomentDistribution.GetM3, 2)
                    + 6 * Math.Pow(_mcr.MomentDistribution.GetM4, 2);

                double result = Math.Sqrt((21 * Math.Pow(_mcr.MomentDistribution.GetM0, 2)) / component);

                return Math.Round(result, 3);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }

    /// <summary>
    /// d2Factor class
    /// </summary>
    internal class d2Factor : IFactor
    {
        /// <summary>
        /// Get the d2 factor
        /// </summary>
        /// <param name="_mcr">Instance of McrClc class</param>
        /// <returns>d2 factor</returns>
        public double GetFactor(IMcrClc _mcr)
        {
            try
            {
                double result = _mcr.Load.GetQ1.GetValue
                    * _mcr.Load.GetQ1.GetApplicationLevel
                    * Math.Pow(Math.Sin(Math.PI * _mcr.Load.GetQ1.GetPosition / _mcr.Beam.GetL), 2);

                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }

    /// <summary>
    /// d3Factor class
    /// </summary>
    internal class d3Factor : IFactor
    {
        /// <summary>
        /// Get the d3 factor
        /// </summary>
        /// <param name="_mcr">Instance of McrClc class</param>
        /// <returns>d3 factor</returns>
        public double GetFactor(IMcrClc _mcr)
        {
            try
            {
                double result = _mcr.Load.GetQ2.GetValue
                    * _mcr.Load.GetQ2.GetApplicationLevel
                    * Math.Pow(Math.Sin(Math.PI * _mcr.Load.GetQ2.GetPosition / _mcr.Beam.GetL), 2);

                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }

    /// <summary>
    /// a2Factor class
    /// </summary>
    internal class a2Factor : IFactor
    {
        /// <summary>
        /// Get the a2 factor
        /// </summary>
        /// <param name="_mcr">Instance of McrClc class</param>
        /// <returns>a2 factor</returns>
        public double GetFactor(IMcrClc _mcr)
        {
            try
            {
                double result = 2 * _mcr.Beam.GetL
                    / (_mcr.MomentDistribution.GetM0 * Math.Pow(Math.PI, 2))
                    * (_mcr.d2 + _mcr.d3);

                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }

    /// <summary>
    /// C2Factor class
    /// </summary>
    internal class C2Factor : IFactor
    {
        /// <summary>
        /// Get the C2 factor
        /// </summary>
        /// <param name="_mcr">Instance of McrClc class</param>
        /// <returns>C2 factor</returns>
        public double GetFactor(IMcrClc _mcr)
        {
            try
            {
                double result = _mcr.C1 * _mcr.a2 / 2;

                return Math.Round(result, 3);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
