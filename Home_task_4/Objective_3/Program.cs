using Objective_3;

while (true)
{
    Accounting accounting = new Accounting();
    Console.WriteLine("------MENU------\n1. Account report\n2. Print one apartament\n3. Print apartament that was not used electricity\n4. Print the owner with the most debt");
    switch (Console.ReadLine())
    {
        case "1":
            {
                accounting.ReadApartmentsData();
                Console.WriteLine(accounting.ToString());
            } break;
        case "2":
            {
                Console.WriteLine("Enter the apartment number: ");
                string input = Console.ReadLine();
                accounting.ReadApartmentsData(numberOfApartment: input);
                Console.WriteLine(accounting.ToString());
            } break;
        case "3":
            {
                accounting.ReadApartmentsData(checkNoUsage: true);
                Console.WriteLine(accounting.ToString());
            } break;
        case "4":
            {
                accounting.ReadApartmentsData(moreEnergy: true);
                Console.WriteLine(accounting.ToString());
            } break;
        default:
            {
                accounting.ReadApartmentsData();
                Console.WriteLine(accounting.ToString());
            } break;
    }
}




