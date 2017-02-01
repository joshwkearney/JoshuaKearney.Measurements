﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoshuaKearney.Measurements.Parser;

namespace JoshuaKearney.Measurements {
    public class MolarMass : Ratio<MolarMass, Mass, Amount> {
        public static MeasurementProvider<MolarMass> Provider { get; } = new MolarMassProvider();

        public override MeasurementProvider<MolarMass> MeasurementProvider => Provider;

        public override MeasurementProvider<Mass> NumeratorProvider => Mass.Provider;

        public override MeasurementProvider<Amount> DenominatorProvider => Amount.Provider;

        public MolarMass() { }

        public MolarMass(double value, Unit<MolarMass> unit) : base(value, unit) { }

        public MolarMass(IMeasurement<Mass> mass, IMeasurement<Amount> amount) : base(mass, amount, Provider) { }

        public static class Units {
            private static readonly Lazy<Unit<MolarMass>> gramPerMole = new Lazy<Unit<MolarMass>>(() => new Unit<MolarMass>("g/mol", Provider));

            public static Unit<MolarMass> GramPerMole => gramPerMole.Value;
        }

        private class MolarMassProvider : MeasurementProvider<MolarMass> {
            public override MolarMass CreateMeasurement(double value, Unit<MolarMass> unit) => new MolarMass(value, unit);

            protected override IEnumerable<Operator> GetOperators() => new Operator[] { };

            protected override IEnumerable<Unit<MolarMass>> GetParsableUnits() => new[] { Units.GramPerMole };
        }
    }
}
