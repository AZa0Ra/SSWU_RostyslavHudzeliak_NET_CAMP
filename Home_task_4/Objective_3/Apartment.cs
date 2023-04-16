using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_3
{
    public class Apartment
    {
        public double power = 2.5;     
        public int Number { get; set; }
        public string Owner { get; set; }
        public int StartReading { get; set; }
        public int EndReading { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public double Usage()
        {
            int usage = EndReading - StartReading;
            int days = (int)(DateTime.DaysInMonth(Date.Year, Date.Month) - Date.Day + 1);
            double usagePerDay = (double)usage / days;
            return usagePerDay * 30;
        }
    }
}
