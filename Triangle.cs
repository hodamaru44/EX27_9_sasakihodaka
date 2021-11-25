using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSampe
{
    class Triangle
    {
        float Length;
        float Height;
        float SidesA;
        float SidesB;
        float SidesC;
        float Area;

        public Triangle(float l, float h)
        {
            this.Length = l;
            this.Height = h;
            this.Area = Length * Height / 2;
        }
        public Triangle(float a, float b, float c)
        {
            this.SidesA = a;
            this.SidesB = b;
            this.SidesC = c;
            float s = (SidesA + SidesB + SidesC) / 2;
            this.Area = s * (s - SidesA) * (s - SidesB) * (s - SidesC);

        }

        public float GetArea()
        {
            return Area;
        }
    }
}
