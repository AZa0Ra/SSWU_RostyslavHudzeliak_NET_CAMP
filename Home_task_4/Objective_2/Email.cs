using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Objective_2
{
    internal class Email
    {// тут все добре
        private string[] _words;
        List<string> correctEmails = new List<string>();
        List<string> incorrectEmails = new List<string>();
        public Email(string text)
        {
            _words = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        }
        public bool CheckEmail(string email)        // Здійснює пошук за @ та .
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            int atIndex = email.IndexOf('@');
            if (atIndex == -1 || atIndex == 0 || atIndex == email.Length - 1 || email.IndexOf('@', atIndex + 1) != -1 || email.Length >= 64 || email.IndexOf('_', atIndex + 1) != -1)
            {
                return false;
            }

            int pointIndex = email.IndexOf('.', atIndex + 1);
            if (pointIndex == -1 || pointIndex == atIndex + 1 || pointIndex == email.Length - 1)
            {
                return false;
            }
            return true;
        }
        public void SortEmails()               // Переміщує адресу електронної пошти до колекції дійсних або недійсних адрес
        {
            foreach (var item in _words)
            {
                if (item.Contains('@'))
                {
                    if (CheckEmail(item))
                    {
                        correctEmails.Add(item);
                    }
                    else
                    {
                        incorrectEmails.Add(item);
                    }
                }
                else
                {
                    incorrectEmails.Add(item);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder correctStringBuilder = new StringBuilder();
            StringBuilder incorrectStringBuilder1 = new StringBuilder();
            foreach (var item in correctEmails)
            {
                correctStringBuilder.Append(item.ToString() + '\n');
            }

            foreach (var item in incorrectEmails)
            {
                incorrectStringBuilder1.Append(item.ToString() + '\n');
            }
            return $"Правильнi електроннi адреси:\n" + correctStringBuilder.ToString()+ "\nНеправильнi електроннi адреси:\n" + incorrectStringBuilder1.ToString();
        }
    }
}
