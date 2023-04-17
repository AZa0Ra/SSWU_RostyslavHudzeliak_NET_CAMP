using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_1
{
    internal class Garden
    {
        private List<Tree> _trees;

        public Garden(List<Tree> trees)
        {
            _trees = trees;
        }
        public double Perimeter                 // Довжина огорожі
        {
            get
            {
                double minX = double.MaxValue;
                double maxX = double.MinValue;
                double minY = double.MaxValue;
                double maxY = double.MinValue;

                foreach (Tree tree in _trees)
                {
                    if (tree.X < minX)
                    {
                        minX = tree.X;
                    }
                    if (tree.X > maxX)
                    {
                        maxX = tree.X;
                    }
                    if (tree.Y < minY)
                    {
                        minY = tree.Y;
                    }
                    if (tree.Y > maxY)
                    {
                        maxY = tree.Y;
                    }
                }

                double width = maxX - minX;
                double height = maxY - minY;
                return 2 * (width + height);
            }
        }

        public static bool operator <(Garden g1, Garden g2)
        {
            return g1.Perimeter < g2.Perimeter;
        }

        public static bool operator >(Garden g1, Garden g2)
        {
            return g1.Perimeter > g2.Perimeter;
            //return g1.GetFenceLength() > g2.GetFenceLength();
        }
    }
}
