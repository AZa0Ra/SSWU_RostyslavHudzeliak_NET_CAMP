using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_1
{// Домовлялись, що скидаємо і файл з малюнком діаграми.(((
    internal class Simulator
    {// композиція.
        private User _user;
        private WaterTower _waterTower;
// конструктор класу не виконує свою функцію.
        public Simulator()
        {

        }
        //Мала б бути композиція. А тому цього конструктора немає бути..
        public Simulator(User user, WaterTower waterTower)
        {
            _user = user;
            _waterTower = waterTower;
        }
        // а зупинити симулятора користувач не зможе?
        
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
