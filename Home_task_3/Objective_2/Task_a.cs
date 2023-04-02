using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_2
{
    internal class Task_a                   // Знайти індекс другого входження заданої підстрічки в текст, якщо таке                                            
    {                                       // входження існує, у іншому випадку - повернути null.
        private string _userString;
        private string _stringToFind;
        public Task_a(string userString, string stringToFind)
        {
            _userString = userString;
            _stringToFind = stringToFind;
        }
        public override string ToString()
        {
            int? index = _userString.IndexOf(_stringToFind);
            if (index == -1)
            {
                index = null;
            }
            Console.Write("\nIndex: ");
            return index.ToString();
        }
    }
}
