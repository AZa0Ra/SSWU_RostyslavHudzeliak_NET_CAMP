using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_1
{
    internal class Simulator
    {
        private User _user;
        private WaterTower _waterTower;
        private Pump _pump;

        public Simulator()
        {

        }
        public Simulator(User user, WaterTower waterTower, Pump pump)
        {
            _user = user;
            _waterTower = waterTower;
            _pump = pump;
        }
        public void Start()
        {
            Console.WriteLine("Program is started");
        }
        public void Pumping()
        {
            Console.WriteLine("Pumping...");
        }
        public string GetWater()
        {
            //return $"Current level of water in the tower: {_waterTower.CurrentLevel}";
            return $"Current level of water in the tower: ";
        }

        public override string ToString()
        {
            Start();
            Pumping();
            return GetWater();
        }
    }
}
