namespace mcr.core
{
    /// <summary>
    /// Load class
    /// </summary>
    internal class Load : ILoad
    {
        private Force _Q1;

        private Force _Q2;

        /// <summary>
        /// Get the Q1 force object
        /// </summary>
        public IForce GetQ1
        {
            get
            {
                return (IForce)_Q1;
            }
        }

        /// <summary>
        /// Get the Q2 force object
        /// </summary>
        public IForce GetQ2
        {
            get
            {
                return (IForce)_Q2;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Load()
        {
            _Q1 = new Force();
            _Q2 = new Force();
        }

        /// <summary>
        /// The Fluent Api getter for Q1
        /// </summary>
        public IAddQ1Condition WithQ1
        {
            get
            {
                return new AddQ1(_Q1);
            }
        }

        /// <summary>
        /// AddQ1 class
        /// </summary>
        internal class AddQ1 : IAddQ1Condition
        {
            private Force _q1;

            public AddQ1(Force q1)
            {
                _q1 = q1;
            }

            /// <summary>
            /// Set the Q1 value in [kN]
            /// </summary>
            /// <param name="value">Q1 value in [kN]</param>
            /// <returns></returns>
            public IAddQ1Condition Value(double value)
            {
                _q1.Value = value;
                return this;
            }

            /// <summary>
            /// Set the Q1 position in [cm]
            /// </summary>
            /// <param name="value">Q1 position in [cm]</param>
            /// <returns></returns>
            public IAddQ1Condition Position(double position)
            {
                _q1.Position = position;
                return this;
            }

            /// <summary>
            /// Set the Q1 application level in [cm]
            /// </summary>
            /// <param name="value">Q1 application level in [cm]</param>
            /// <returns></returns>
            public IAddQ1Condition ApplicationLevel(double applicationLevel)
            {
                _q1.ApplicationLevel = applicationLevel;
                return this;
            }
        }

        /// <summary>
        /// The Fluent Api getter for Q2
        /// </summary>
        public IAddQ2Condition WithQ2
        {
            get
            {
                return new AddQ2(_Q2);
            }
        }

        /// <summary>
        /// AddQ2 class
        /// </summary>
        internal class AddQ2 : IAddQ2Condition
        {
            private Force _q2;

            public AddQ2(Force q2)
            {
                _q2 = q2;
            }

            /// <summary>
            /// Set the Q1 value in [kN]
            /// </summary>
            /// <param name="value">Q1 value in [kN]</param>
            /// <returns></returns>
            public IAddQ2Condition Value(double value)
            {
                _q2.Value = value;
                return this;
            }

            /// <summary>
            /// Set the Q2 position in [cm]
            /// </summary>
            /// <param name="value">Q2 position in [cm]</param>
            /// <returns></returns>
            public IAddQ2Condition Position(double position)
            {
                _q2.Position = position;
                return this;
            }

            /// <summary>
            /// Set the Q2 application level in [cm]
            /// </summary>
            /// <param name="value">Q2 application level in [cm]</param>
            /// <returns></returns>
            public IAddQ2Condition ApplicationLevel(double applicationLevel)
            {
                _q2.ApplicationLevel = applicationLevel;
                return this;
            }
        }

    }

    /// <summary>
    /// Force class
    /// </summary>
    internal class Force : IForce
    {
        private double _Value;
        private double _Position;
        private double _ApplicationLevel;

        /// <summary>
        /// Set the value (for internal purposes)
        /// </summary>
        internal double Value
        {
            set
            {
                _Value = value;
            }
        }

        /// <summary>
        /// Set the position (for internal purposes)
        /// </summary>
        internal double Position
        {
            set
            {
                _Position = value;
            }
        }

        /// <summary>
        /// Set the application level (for internal purposes)
        /// </summary>
        internal double ApplicationLevel
        {
            set
            {
                _ApplicationLevel = value;
            }
        }

        /// <summary>
        /// Get the value in [kN]
        /// </summary>
        public double GetValue
        {
            get
            {
                return _Value;
            }
        }

        /// <summary>
        /// Get the position in [cm]
        /// </summary>
        public double GetPosition
        {
            get
            {
                return _Position;
            }
        }

        /// <summary>
        /// Get the application level in [cm]
        /// </summary>
        public double GetApplicationLevel
        {
            get
            {
                return _ApplicationLevel;
            }
        }
    }
}
