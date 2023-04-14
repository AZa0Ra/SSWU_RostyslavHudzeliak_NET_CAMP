using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_1
{
    internal class BracketString
    {
        private string _text = "";
        string[] _sentences;
        List<string> _sentencesParentheses = new List<string>();
        public BracketString(string text)
        {
            _text = text;
            _sentences = _text.Split(new char[] { '.', ',', '!', '?' });        // Масив який містить розділені рядки
        }

        public List<string> Check()                                             // Додає рядки які мають круглі дужки
        {
            foreach (var item in _sentences)
            {
                if (item.Contains("(") && item.Contains(")"))
                {
                    _sentencesParentheses.Add(item.Trim());
                }
            }
            return _sentencesParentheses;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine("Заданий текст: \n{0}", _text);
            Console.WriteLine("\nРядки які містять круглі дужки: ");
            foreach (var item in _sentencesParentheses)
            {
                stringBuilder.Append(item + " | ");
            }
            return stringBuilder.ToString();
        }
    }
}
