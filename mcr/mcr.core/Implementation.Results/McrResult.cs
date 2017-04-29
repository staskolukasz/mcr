using System;

namespace mcr.core
{
    /// <summary>
    /// McrResult class
    /// </summary>
    internal class McrResult : IFactor
    {
        /// <summary>
        /// Get the value of lateral-torsional buckling moment
        /// </summary>
        /// <param name="_mcr">Instance of McrClc class</param>
        /// <returns>Mcr in [kNcm]</returns>
        public double GetFactor(IMcrClc _mcr)
        {
            try
            {
                double c1 = _mcr.C1 * _mcr.Ncrz;
                double c2 = Math.Sqrt(_mcr.D + Math.Pow(_mcr.C2, 2));
                double c3 = _mcr.C2;

                double result = c1 * (c2 + c3);

                return Math.Round(result, 3);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
