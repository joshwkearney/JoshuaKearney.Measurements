﻿using JoshuaKearney.Measurements;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using static JoshuaKearney.Measurements.Area.CommonUnits;
using static JoshuaKearney.Measurements.DigitalSize.CommonUnits;
using static JoshuaKearney.Measurements.Length.CommonUnits;
using static JoshuaKearney.Measurements.Mass.CommonUnits;
using static JoshuaKearney.Measurements.Volume.CommonUnits;

namespace Testing {

    public class Program {

        public static void Main(string[] args) {
            // Measurement.Factory.
            // Console.WriteLine(Term.From((Length)null, DigitalSize.From(7, Bit)));
            //Stopwatch w = new Stopwatch();
            // w.Start();

            Console.WriteLine(Length.Parse("45 km"));

            //w.Stop();
            // Console.WriteLine($"{ret} in {w.ElapsedMilliseconds} ms");

            // w.Restart();

            // ret = Length.Parse("45 km");

            // w.Stop();
            //Console.WriteLine($"{ret} in {w.ElapsedMilliseconds} ms");
            ////var x = Volume.Parse("4 m*mi*yd");
            //Console.WriteLine(Volume.Parse("4 m*mi*yd"));

            ////var x = Ratio.Parse<Mass, Area>("45 g/km^2");
            Console.WriteLine(Ratio.Parse<Mass, Area>("45 Mg/km^2"));
            //Console.WriteLine(Term.Parse<Term<Length, DigitalSize>, Mass>("99 (Mm*KiB)*mg"));
            ////var y = 4;

            //Console.WriteLine(Ratio.From(Term.From(Length.From(4, Meter), Mass.From(89, Gram)), DigitalSize.From(78, Bit)));
            //Console.WriteLine(x);
            //w.Stop();
            //Console.WriteLine(w.ElapsedMilliseconds + " ms");

            //w.Restart();
            //Console.WriteLine(Volume.Parse("4 m*mi*yd"));

            //w.Stop();
            //Console.WriteLine(w.ElapsedMilliseconds + " ms");
            //Stopwatch w = new Stopwatch();
            //w.Start();

            //var res = Volume.Parse("45 km*Km*fur");

            //w.Stop();
            //Console.WriteLine(res + "\n" + w.ElapsedMilliseconds + " ms");
            //w.Reset();

            //w.Start();
            //var res2 = Volume.Parse("45 km*Km*fur");
            //w.Stop();

            //Console.WriteLine(res2 + "\n" + w.ElapsedMilliseconds + " ms");

            Console.Read();
        }
    }
}