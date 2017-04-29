namespace mcr.core
{
    /// <summary>
    /// McrClc main facade class
    /// </summary>
    public class McrClc : IMcrClc
    {
        private Context _context;

        /// <summary>
        /// Beam material properties
        /// </summary>
        public IMaterial Material { get; }

        /// <summary>
        /// Beam cross seciton properties
        /// </summary>
        public ICrossSection CrossSection { get; }

        /// <summary>
        /// Beam properties
        /// </summary>
        public IBeam Beam { get; }

        /// <summary>
        /// Load properties
        /// </summary>
        public ILoad Load { get; }

        /// <summary>
        /// Moment distribution properties
        /// </summary>
        public IMomentDistribution MomentDistribution { get; }

        /// <summary>
        /// Ncrz class (critical load with respect to weak axis) in [kN]
        /// </summary>
        public double Ncrz
        {
            get
            {
                Ncrz Ncrz = new Ncrz();
                return _context.Calculate(Ncrz);
            }
        }

        /// <summary>
        /// D factor in [cm2]
        /// </summary>
        public double D
        {
            get
            {
                DFactor D = new DFactor();
                return _context.Calculate(D);
            }
        }

        /// <summary>
        /// C1 factor
        /// </summary>
        public double C1
        {
            get
            {
                C1Factor C1Factor = new C1Factor();
                return _context.Calculate(C1Factor);
            }
        }

        /// <summary>
        /// d2 factor (helper for C2 factor)
        /// </summary>
        public double d2
        {
            get
            {
                d2Factor d2Factor = new d2Factor();
                return _context.Calculate(d2Factor);
            }
        }

        /// <summary>
        /// d3 factor (helper for C2 factor)
        /// </summary>
        public double d3
        {
            get
            {
                d3Factor d3Factor = new d3Factor();
                return _context.Calculate(d3Factor);
            }
        }

        /// <summary>
        /// a2 factor (helper for C2 factor)
        /// </summary>
        public double a2
        {
            get
            {
                a2Factor a2Factor = new a2Factor();
                return _context.Calculate(a2Factor);
            }
        }

        /// <summary>
        /// C2 factor
        /// </summary>
        public double C2
        {
            get
            {
                C2Factor C2Factor = new C2Factor();
                return _context.Calculate(C2Factor);
            }
        }

        /// <summary>
        /// Lateral-torsional buckling moment in [kNcm]
        /// </summary>
        public double Mcr
        {
            get
            {
                McrResult McrResult = new McrResult();
                return _context.Calculate(McrResult);
            }
        }

        public McrClc()
        {
            Material = new Material();
            CrossSection = new CrossSection();
            Beam = new Beam();
            Load = new Load();
            MomentDistribution = new MomentDistribution();

            _context = new Context(this);
        }
    }
}
