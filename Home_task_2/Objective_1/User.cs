using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_1
{
    internal class User
    {
        private double _consumption; 
        public User(double consumption)
        {
            _consumption = consumption;
        }
        public double Consumption
        {
            get { return _consumption; }       
        }
    }
}
