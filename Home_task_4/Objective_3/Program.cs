using Objective_3;

while (true)
{
    Accounting accounting = new Accounting();
    Console.WriteLine("------MENU------\n1. Account report\n2. Print one apartament\n3. Print apartament that was not used electricity\n4. Print the owner with the most debt");
    switch (Console.ReadLine())
    {
        case "1":
            {
                accounting.ElectricityUsageTracker();
                Console.WriteLine(accounting.ToString());
            } break;
        case "2":
            {
                Console.WriteLine("Enter the apartment number: ");
                string input = Console.ReadLine();
                accounting.OneApartament(input);
                Console.WriteLine(accounting.ToString());
            } break;
        case "3":
            {
                accounting.ReadApartmentsData(checkNoUsage: true);
                Console.WriteLine(accounting.ToString());
            } break;
        case "4":
            {
                accounting.Debt();
                Console.WriteLine(accounting.ToString());
            } break;
        default:
            {
                accounting.ElectricityUsageTracker();
                Console.WriteLine(accounting.ToString());
            } break;
    }
}




