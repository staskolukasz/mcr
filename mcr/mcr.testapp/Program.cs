using System;
using mcr.core;

namespace mcr.testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMcrClc mcrClc = new McrClc();

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
                .Position(150)
                .ApplicationLevel(15);

            mcrClc.Load
                .WithQ2
                .Value(-15)
                .Position(450)
                .ApplicationLevel(15);

            mcrClc.MomentDistribution
                .With
                .M0(2063)
                .M1(0)
                .M2(1688)
                .M3(1875)
                .M4(2063)
                .M5(0);

            double Ncrz = mcrClc.Ncrz;
            double D = mcrClc.D;

            double C1 = mcrClc.C1;
            double C2 = mcrClc.C2;

            double Mcr = mcrClc.Mcr;

            Console.ReadLine();
        }
    }
}
