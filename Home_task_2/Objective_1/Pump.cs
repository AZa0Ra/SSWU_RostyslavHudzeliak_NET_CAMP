using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_1
{
    internal class Pump
    {
        private readonly int _power;
        private bool _enabled = false;

        public Pump(int power)
        {
            _power = power;
            // _enabled = true;
        }
        public bool IsEnabled
        {
            set { _enabled = value; }
            get { return _enabled; }
        }

        public int Power
        {
            get { return _power; }
        }

/*        public void ChangeState()
        {
            if (_enabled)
            {
                _enabled = false;
            }
            else _enabled = true;
        }*/
    }
}
