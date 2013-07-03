using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    public class Massive
    {
        public int size;
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

        public double this[int i]
        {
            set
            {
                elements[i] = value;
            }
            get
            {
                return elements[i];
            }
        }
    }
}
