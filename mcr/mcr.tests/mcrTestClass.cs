using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mcr.core;
using NUnit.Framework;

namespace mcr.tests
{
    /// <summary>
    /// Sample test class
    /// </summary>
    [TestFixture]
    public class mcrTestClass
    {
        private IMcrClc mcrClc;

        public mcrTestClass()
        {
            mcrClc = new McrClc();

            mcrClc.Material
                .With
                .E(21000)
                .G(8100);

            mcrClc.CrossSection
                .With
                .Iz(604)
                .It(20.1)
                .Iw(126000);

            mcrClc.Beam
                .With
                .L(600);

            mcrClc.Load
                .WithQ1
                .Value(-10)
                .Position(300)
                .ApplicationLevel(15);

            mcrClc.MomentDistribution
                .With
                .M0(2249)
                .M1(0)
                .M2(1125)
                .M3(2249)
                .M4(1125)
                .M5(0);

            double test = mcrClc.Mcr;
        }

        [TestCase(1233.034, 21000, 2141.7, 600)]
        [TestCase(347.739, 21000, 604, 600)]
        public void FactorNcrz(double expectedResult, double E, double Iz, double L)
        {
            mcrClc.Material.With.E(E);
            mcrClc.CrossSection.With.Iz(Iz);
            mcrClc.Beam.With.L(L);

            Assert.AreEqual(expectedResult, mcrClc.Ncrz, 0.001);
        }


        [TestCase(1.092, 2063, 0, 1688, 1875, 2063, 0)]
        [TestCase(1.323, 2249, 0, 1125, 2249, 1125, 0)]
        public void FactorC1(double expectedResult, params double[] momentVal)
        {
            mcrClc.MomentDistribution.With
                .M0(momentVal[0])
                .M1(momentVal[1])
                .M2(momentVal[2])
                .M3(momentVal[3])
                .M4(momentVal[4])
                .M5(momentVal[5]);

            Assert.AreEqual(expectedResult, mcrClc.C1, 0.001);
        }
    }
}
