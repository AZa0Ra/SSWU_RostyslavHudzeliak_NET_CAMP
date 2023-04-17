using Objective_1;

List<Tree> trees = new List<Tree>()
            {
                new Tree(1, 2),
                new Tree(-2, 5),
                new Tree(4, 3),
                new Tree(-3, -1),
                new Tree(0, 0)
            };

Garden garden1 = new Garden(trees);
Garden garden2 = new Garden(new List<Tree>()
            {
                new Tree(0,0),
                new Tree(0,2),
                new Tree(2,0),
                new Tree(2,2),
            });

Console.WriteLine($"Garden 1 fence length: {garden1.Perimeter}");
Console.WriteLine($"Garden 2 fence length: {garden2.Perimeter}");
if (garden1 > garden2 || garden2 < garden1)
{
    Console.WriteLine("The fence of the 1st garden is larger");
}
else if (garden1 < garden2 || garden2 > garden1)
{
    Console.WriteLine("The fence of the 2st garden is larger");
}

