using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_1
{
    internal class User
    {
        public int Id { get; set; }
        private double _consumption; 
        public User(double consumption)
        {
            _consumption = consumption;
        }
        public double ConsumeWater()
        {
            return _consumption;
        }
    }
}
