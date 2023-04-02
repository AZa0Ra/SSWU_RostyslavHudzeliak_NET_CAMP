using Objective_2;
sbyte choise = 0;
string str1, str2 = "";

Console.WriteLine("1. Task a\n2. Task b\n3. Task c");
while (choise != 1 || choise != 2 || choise !=3)
{
    choise = 0;
    Console.WriteLine("\nChoose the number:");
    try
    {
        choise = SByte.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Wrong format, please write number 1-3\n");
    }
    switch (choise)
    { 
        case 1:
            {
                Console.WriteLine("\nPrint string:");
                str1 = Console.ReadLine();
                Console.WriteLine("\nPrint substring to find in the string:");
                str2 = Console.ReadLine();
                Task_a task_a = new Task_a(str1, str2);
                Console.WriteLine(task_a.ToString()); break;
            }         
        case 2:
            {
                Console.WriteLine("\nPrint string:");
                str1 = Console.ReadLine();
                Task_b task_b = new Task_b(str1);
                Console.WriteLine(task_b.ToString()); break;
            }
        case 3:
            {
                Console.WriteLine("\nPrint string:");
                str1 = Console.ReadLine();
                Console.WriteLine("\nPrint substring to change doubling in the string:");
                str2 = Console.ReadLine();
                Task_c task_c = new Task_c(str1, str2);
                Console.WriteLine(task_c.ToString()); break;
            }
        default: break;
    } 
}



