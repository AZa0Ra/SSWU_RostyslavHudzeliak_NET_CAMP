using Objective_1;

Console.OutputEncoding = System.Text.Encoding.UTF8;

BracketString bracket = new BracketString("Ось речення яке не містить дужок, але ось (тут), вони є." +
                                            " Проте (тут,) воно не правельно, оскіль (там), кома в ()! Чому(?)");
bracket.Check();
Console.WriteLine(bracket.ToString());

BracketString bracketENG = new BracketString("Here is a sentence that does not contain parentheses, but here (here), they are." +
                                            " However (here,) it is not correct, because (there), a comma in ()! Why(?)");
bracketENG.Check();
Console.WriteLine(bracketENG.ToString());

