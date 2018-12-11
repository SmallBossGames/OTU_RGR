using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTU_RGR
{
    struct XTuple
    {
        public readonly double x1;
        public readonly double x2;
        public readonly double x3;
        public readonly double x_cb;

        public XTuple(double x1, double x2, double x3, double x_cb)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x_cb = x_cb;
        }
    }

    static class RungeCutt
    {
        static readonly double k1 = 50.0;
        static readonly double T1 = 0.44;
        static readonly double k2 = 0.4;
        static readonly double k3 = 2.5;
        static readonly double k4 = 1.0;
        static readonly double T = 0.074;
        static readonly double k_fb = 1.0;
        static readonly double k_cb = 1.0;
        static readonly double T0 = 1.0;
        static readonly double T3 = 1.0;
        static readonly double Z_0 = 21.0;

        static double Px1(double x2, double k4, double Z) 
            => k4 * (x2 - Z);

        static double Px2(double x1, double x3, double k2, double k3, double T, double x2) 
            => (k2 / T) * (x3 - k3 * x1) - (1.0 / T) * x2;

        static double Px3(double x_cb, double k1, double T1, double x3)
            => (k1 / T1) * x_cb - (1.0 / T1) * x3;

        static double Px_cb(double k_cb, double T0, double T3, double e, double x_cb)
            => (k_cb / T0) * e - (1.0 / T3) * x_cb;

        static double E(double x1, double k_fb, double t)
            => VFunc(t) - k_fb * x1;

        static double VFunc(double t) 
            => 0.3 * t / (t * t + 0.8);

        static double ZFunc(double t) 
            => 0.2 * Math.Sin(50 * t);

        static double Calc(double y, double k1, double k2, double k3, double k4, double h)
            => y + (h / 6.0) * (k1 + 2.0 * k2 + 2.0 * k3 + k4);

        public static XTuple[] MainFunc (XTuple input, double from, double to, int divCount)
        {
            var tempArr = new XTuple[divCount];

            var h = (to - from) / divCount; 

            double d1, d2, d3, d4;

            tempArr[0] = input;

            for (int i = 1; i < divCount; i++)
            {
                input = tempArr[i - 1];
                var time = from + (i - 1) * h;

                //x1
                d1 = Px1(input.x2, k4, ZFunc(time));
                d2 = Px1(input.x2, k4, ZFunc(time + h / 2));
                d3 = Px1(input.x2, k4, ZFunc(time + h / 2));
                d4 = Px1(input.x2, k4, ZFunc(time + h));
                var x1 = Calc(input.x1, d1, d2, d3, d4, h);
                //x2
                d1 = Px2(input.x1, input.x3, k2, k3, T, input.x2);
                d2 = Px2(input.x1, input.x3, k2, k3, T, input.x2 + d1 * h / 2);
                d3 = Px2(input.x1, input.x3, k2, k3, T, input.x2 + d2 * h / 2);
                d4 = Px2(input.x1, input.x3, k2, k3, T, input.x2 + d3 * h);
                var x2 = Calc(input.x2, d1, d2, d3, d4, h);
                //x3
                d1 = Px3(input.x_cb, k1, T1, input.x3);
                d2 = Px3(input.x_cb, k1, T1, input.x3 + d1 * h / 2);
                d3 = Px3(input.x_cb, k1, T1, input.x3 + d2 * h / 2);
                d4 = Px3(input.x_cb, k1, T1, input.x3 + d3 * h);
                var x3 = Calc(input.x3, d1, d2, d3, d4, h);
                //x_cb
                d1 = Px_cb(k_cb, T0, T3, E(input.x1, k_fb, time), input.x_cb);
                d2 = Px_cb(k_cb, T0, T3, E(input.x1, k_fb, time + h / 2), input.x_cb + d1 * h / 2);
                d3 = Px_cb(k_cb, T0, T3, E(input.x1, k_fb, time + h / 2), input.x_cb + d2 * h / 2);
                d4 = Px_cb(k_cb, T0, T3, E(input.x1, k_fb, time + h), input.x_cb + d3 * h);
                var x_cb = Calc(input.x_cb, d1, d2, d3, d4, h);

                tempArr[i] = new XTuple(x1, x2, x3, x_cb);
            }

            return tempArr;
        }

        /*public static XTuple[] Auler(XTuple input, double from, double to, int divCount)
        {
            var tempArray = new XTuple[divCount];
            var h = (to - from) / divCount;

            tempArray[0] = input;

            for (int i = 1; i < divCount; i++)
            {
                input = tempArray[i - 1];
                var time = from + h * (i - 1);

                var x1 = input.x1 + h*Px1(input.x2, k4, ZFunc(time));
                var x2 = input.x2 + h*Px2(input.x1, input.x3, k2, k3, T, input.x2);
                var x3 = input.x3 + h * Px3(input.x_cb, k1, T1, input.x3);
                var x_cb = input.x_cb + h * Px_cb(k_cb, T0, T3, E(input.x1, k_fb, time), input.x_cb);

                tempArray[i] = new XTuple(x1, x2, x3, x_cb);
            }

            return tempArray;
        }*/

        /*public static double RungeCuttFunc(double x, double y, double h, Func<double, double, double> func)
        {
            var k1 = func(x, y);
            var k2 = func(x + h / 2, y + k1 * h / 2);
            var k3 = func(x + h / 2, y + k2 * h / 2);
            var k4 = func(x + h, y + h * k3);

            return y + (h / 6) * (k1 + k2 + k3 + k4);
        }

        public static XTuple[] RungeCuttMain(XTuple input, double from, double to, int divCount)
        {
            var tempArray = new XTuple[divCount];
            var h = (to - from) / divCount;

            double funcX1(double x, double y) => Px1(input.x2, k4, ZFunc(x));
            double funcX2(double x, double y) => Px2(input.x1, input.x3, k2, k3, T, y);
            double funcX3(double x, double y) => Px3(input.x_cb, k1, T1, y);
            double funcX_CB(double x, double y) => Px_cb(input.x_cb, T0, T3, E(input.x1, k_fb, x), y);

            tempArray[0] = input;

            for (int i = 1; i < divCount; i++)
            {
                input = tempArray[i - 1];
                var time = h * (i - 1);

                var x1 = RungeCuttFunc(time, input.x1, h, funcX1);
                var x2 = RungeCuttFunc(time, input.x2, h, funcX2);
                var x3 = RungeCuttFunc(time, input.x3, h, funcX3);
                var x_cb = RungeCuttFunc(time, input.x_cb, h, funcX_CB);

                tempArray[i] = new XTuple(x1, x2, x3, x_cb);
            }

            return tempArray;
        }*/
    }
}
