using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_1
{
    internal class WaterTower
    {
        public int Id { get; set; }
        private readonly int _maxWaterLevel;
        private readonly int _minWaterLevel = 20;
        private int _currentWaterLevel;
        //List<Pump> TowerPumps;
        private Pump _pump;

        public WaterTower(int maxWaterLevel, int currenntWaterLevel, Pump pump)
        {
            _currentWaterLevel = currenntWaterLevel;
            _maxWaterLevel = maxWaterLevel;
            //TowerPumps.Add(pump);
            _pump = pump;
        }

        public void PumpWater(Pump pump)
        {
            Console.WriteLine("Pumping...");
        }

        public int WaterIncrease(int currenntWaterLevel)
        {
            return 1;
        }

        public int WaterDecrease(int currenntWaterLevel)
        {
            return 0;
        }
    }
}
