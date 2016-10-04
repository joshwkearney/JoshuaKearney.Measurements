﻿namespace JoshuaKearney.Measurements.MeasurementSystems {

    public static class Metric {
        //private static Lazy<IEnumerable<IUnit>> allUnits = new Lazy<IEnumerable<IUnit>>(() => new List<IUnit>() { Meter, Gram, Tonne, Liter, Are });
        //public static IEnumerable<IUnit> AllUnits => allUnits.Value;

        public static PrefixableUnit<Area> Are { get; } = new PrefixableUnit<Area>(
            name: "are",
            symbol: "a",
            unitsPerDefault: .01
        );

        public static PrefixableUnit<Mass> Gram { get; } = new PrefixableUnit<Mass>(
            name: "gram",
            symbol: "g",
            unitsPerDefault: 1000d
        );

        public static PrefixableUnit<Volume> Liter { get; } = new PrefixableUnit<Volume>(
            name: "liter",
            symbol: "L",
            unitsPerDefault: 1000
        );

        public static PrefixableUnit<Distance> Meter { get; } = new PrefixableUnit<Distance>(
                                                            name: "meter",
            symbol: "m",
            unitsPerDefault: 1d
        );

        public static Unit<Mass> Tonne { get; } = new Unit<Mass>(
            name: "tonne",
            symbol: "t",
            unitsPerDefault: 1d / 1000d
        );
    }
}