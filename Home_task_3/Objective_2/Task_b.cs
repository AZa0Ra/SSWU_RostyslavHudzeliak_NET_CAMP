using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_2
{
    internal class Task_b               // Повернути кількість слів, що починаються з великої літери.
    {
        private string _userString;
        private byte _counter = 0;
        public Task_b(string userString)
        {
            _userString = userString;
        }
        public override string ToString()
        {
            char[] array = _userString.ToCharArray();
            for (int i = 0; i < array.Length; i++)          // Виводить кількість слів які розділені пробілок і починаються з великої букви
                if (char.IsUpper(array[i]) && i == 0)
                    _counter++;
                else if (char.IsUpper(array[i]) && array[i - 1] == ' ' && i != 0)
                    _counter++;
            Console.Write("\nNumber of words starting with a capital letter: ");
            return _counter.ToString();
        }
    }
}
