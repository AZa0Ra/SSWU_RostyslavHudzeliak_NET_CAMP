using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_2
{
    internal class Task_c           // Замінити всі слова, що містять подвоєння літер на заданий користувачем текст.
    {                              
        private string _userString;
        private string _stringToChange;
        public Task_c(string userString, string stringToChange)
        {
            _userString = userString;
            _stringToChange = stringToChange;
        }

        public override string ToString()
        {
            char[] array = _userString.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                if (i + 1 != array.Length)
                {
                    if (array[i].Equals(array[i + 1]))
                    {
                        sb.Append(_stringToChange);
                        i++;
                    }
                    else sb.Append(array[i]);
                }
                else sb.Append(array[i]);					// Для виводу останнього елемента масиву
            }
            return sb.ToString();
        }
    }
}
