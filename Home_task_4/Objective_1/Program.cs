using Objective_1;
// Як тест Ви вибрали складніший випадок, ніж було запропоновано. Ви вважаєте,що дужки можуть бути в кількох реченнях...А запрпоновано було, що речення можуть бути в кількох стрічках.
//А в реченні можуть бути дужки. Щодо коми, то це неточність. Я про це окремо кілька разів наголошувала.
Console.OutputEncoding = System.Text.Encoding.UTF8;

BracketString bracket = new BracketString("Ось речення яке не містить дужок, але ось (тут), вони є." +
                                            " Проте (тут,) воно не правельно, оскіль (там), кома в ()! Чому(?)");
bracket.Check();
Console.WriteLine(bracket.ToString());

BracketString bracketENG = new BracketString("Here is a sentence that does not contain parentheses, but here (here), they are." +
                                            " However (here,) it is not correct, because (there), a comma in ()! Why(?)");
bracketENG.Check();
Console.WriteLine(bracketENG.ToString());

