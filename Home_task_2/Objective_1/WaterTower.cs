using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_1
{
    internal class WaterTower
    {
        private readonly int _maxLevelWater;
        private readonly int _minLevelWater = 20;
        private int _currentLevel;

        private Pump _pump;
        public int CurrentLevel
        {
            get { return _currentLevel; }
        }

        public WaterTower(int maxLevelWater, int currenntLevel, Pump pump)
        {
            _currentLevel = currenntLevel;
            _maxLevelWater = maxLevelWater;
            _pump = pump;
        }

        public int WaterIncrease(int currentLevel)
        {
            return 1;
        }

        public int WaterDecrease(int currentLevel)
        {
            return 0;
        }
    }
}
