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
            int n = 0, counter = 0;
            int? index = _userString.IndexOf(_stringToFind);

            while (n != -1)
            {
                n = _userString.IndexOf(_stringToFind, n + _stringToFind.Length);
                counter++;
                if (counter == 2)
                {
                    index = _userString.IndexOf(_stringToFind, n);
                    break;
                }          
            }          
            if (index == -1)
            {
                index = null;
            }
            Console.Write("\nIndex: ");
            return index.ToString();
        }
    }
}
