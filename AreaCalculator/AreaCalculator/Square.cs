﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Square : Shape
    {
        public int side;
        public Square(int side)
        {
            this.side = side;
        }

        public override double CalculateArea()
        {
            area = side * side;
            return area;
        }

    }
}
