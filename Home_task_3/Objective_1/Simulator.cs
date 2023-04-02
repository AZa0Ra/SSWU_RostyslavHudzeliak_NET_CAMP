﻿using System;
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

        public Simulator()
        {

        }
        public Simulator(User user, WaterTower waterTower)
        {
            _user = user;
            _waterTower = waterTower;
        }
        public void StartSimulator()
        {
            Console.WriteLine("Program is started");
        }

        public string GetWaterLevel()
        {
            //return $"Current level of water in the tower: {_waterTower.CurrentLevel}";
            return $"Current level of water in the tower: ";
        }

        public override string ToString()
        {
            StartSimulator();
           // Pumping();
            return GetWaterLevel();
        }
    }
}
