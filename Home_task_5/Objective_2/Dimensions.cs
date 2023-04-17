using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_2
{
    public class Dimensions
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public Dimensions(double width, double length, double height)
        {
            Width = width;
            Length = length;
            Height = height;
        }
    }
}
