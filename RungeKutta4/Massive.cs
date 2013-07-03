using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RungeKutta4
{
    public class Massive
    {
        public int size;
        public int precision;
        public double[] elements;

        public Massive()
        {
            this.size = 0;
            this.elements = new double[size];
        }

        public Massive(int size)
        {
            this.size = size;
            this.elements = new double[size];

            for (int i = 0; i < this.size; ++i)
            {
                this.elements[i] = 0.0;
            }
        }
        public Massive(int size, int precision)
        {
            this.size = size;
            this.precision = precision;
            this.elements = new double[size];

            for (int i = 0; i < this.size; ++i)
            {
                this.elements[i] = 0.0;
            }
        }

        public double this[int i]
        {
            set
            {
                elements[i] = Math.Round(value, precision);
            }
            get
            {
                return Math.Round(elements[i], precision);
            }
        }
    }
}
