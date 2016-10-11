﻿namespace JoshuaKearney.Measurements.Parser {

    internal class MeasurementToken : Token {
        public object MeasurementValue { get; }

        public MeasurementToken(object measurement) : base(measurement.ToString()) {
            this.MeasurementValue = measurement;
        }
    }
}