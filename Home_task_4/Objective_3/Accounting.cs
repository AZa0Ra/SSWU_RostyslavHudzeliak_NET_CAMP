using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_3
{
    class Accounting
    {
        public string filename = "electricity_usage.txt";
        private List<Apartment> _apartments = new List<Apartment>();
        private int _quarter = 0;
        private static int _startMonth = 1;
        private static int _endMonth = 3;

        public void ReadApartmentsData(string numberOfApartment = null, bool checkNoUsage = false, bool moreEnergy = false)
        {
            using (StreamReader file = new StreamReader(filename))
            {
                string line = file.ReadLine();
                string[] data = line.Split(' ');
                int numApartments = int.Parse(data[0]);
                _quarter = int.Parse(data[1]);
                double energy = 0.0;
                for (int i = 0; i < numApartments; i++)
                {
                    line = file.ReadLine();
                    data = line.Split(' ');
                    Apartment apartment = new Apartment();
                    apartment.Number = int.Parse(data[0]);
                    apartment.Owner = data[1] + " " + data[2];
                    apartment.StartReading = int.Parse(data[3]);
                    apartment.EndReading = int.Parse(data[4]);
                    apartment.Date = DateTime.ParseExact(data[5], "dd.MM.yy", CultureInfo.InvariantCulture);
                    apartment.Address = data[6];

                    if (moreEnergy)                                                                 // Пошук власника з найбільшою заборгованістю
                    {
                        _apartments.Add(apartment);
                        if (energy < apartment.Usage())
                        {
                            energy = apartment.Usage();
                        }
                        if (i == numApartments - 1)
                        {
                            var foundedItem = _apartments.Find(apartment => apartment.Usage() == energy);
                            List<Apartment> newList = new List<Apartment>() { foundedItem };
                            _apartments = newList;
                        }
                        continue;
                    }
                    else if (checkNoUsage && apartment.StartReading == apartment.EndReading)        // Пошук квартири, в якій не використовувалась електроенергія.
                    {
                        _apartments.Add(apartment);
                        break;
                    }
                    else if (numberOfApartment != null && !data[0].Contains(numberOfApartment))     // Друк інформації тільки по заданій квартирі.
                    {
                        continue;
                    }
                    else if (checkNoUsage == false)                                                 // Пошук квартири, в якій не використовувалась електроенергія.
                    {
                        _apartments.Add(apartment);
                    }
                }
            }
        }
        static string GetQuarterName(int quarter)
        {
            switch (quarter)
            {
                case 1:
                    {
                        _startMonth = 1;
                        _endMonth = 3;
                    }
                    return "I";
                case 2:
                    {
                        _startMonth = 4;
                        _endMonth = 6;
                    }
                    return "II";
                case 3:
                    {
                        _startMonth = 7;
                        _endMonth = 9;
                    }
                    return "III";
                case 4:
                    {
                        _startMonth = 10;
                        _endMonth = 12;
                    }
                    return "IV";
                default:
                    return "";
            }
        }
        public override string ToString()
        {
            Console.OutputEncoding = Encoding.UTF8;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Report for {GetQuarterName(_quarter)} quarter:");
            stringBuilder.AppendLine($"---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            stringBuilder.AppendLine($"|  №  | Address(City-Street)\t\t | Owner\t\t\t | Usage \t | Meter reading | First Quarter Month | Last Quarter Month | Need to pay | Days passed |");
            stringBuilder.AppendLine($"---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (var apartment in _apartments)
            {
                stringBuilder.AppendLine($"| {apartment.Number,-3} | {apartment.Address,-32} | {apartment.Owner,-29} | {apartment.Usage(),-9:F2} kWh | " +
                    $"{apartment.Date.ToString("dd.MM.yy"),-13} | {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(_startMonth),-19}" +
                    $" | {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(_endMonth),-18} | {apartment.Usage() * apartment.power,-9:F2} ₴" +
                    $" | {Math.Round((DateTime.Now - apartment.Date).TotalDays),-11} |");
            }
            stringBuilder.AppendLine($"---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            return stringBuilder.ToString();
        }
    }
}
