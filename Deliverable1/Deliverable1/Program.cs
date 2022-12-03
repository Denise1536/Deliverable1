{
    bool hungry = true;

    do
    {
        Console.Write("How many people are we making PB&J sandwiches for?");
        int Num = int.Parse(Console.ReadLine());
        Decimal Val2 = Num * 2;
        Decimal Val4 = Num * 4;
        Decimal ValL = (Val2 / 28);
        Decimal ValPB = (Val2 / 32);
        Decimal ValJ = (Val4 / 48);

        Console.WriteLine("You need:");
        Console.WriteLine(" ");
        Console.WriteLine(Num * 2 + " slices of bread");
        Console.WriteLine(Num * 2 + " tablespoons of peanut butter");
        Console.WriteLine(Num * 4 + " teaspoons of jelly");

        Console.WriteLine(" ");
        Console.WriteLine("Which is...");
        Console.WriteLine(" ");

        Console.WriteLine(Math.Ceiling(ValL) + " loaves of bread");
        Console.WriteLine(Math.Ceiling(ValPB) + " jars of peanut butter");
        Console.WriteLine(Math.Ceiling(ValJ) + " jars of jelly");
        Console.WriteLine(" ");
        Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");

        if (Console.ReadLine("y")) //I know this isn't fully working, can't figure out why.
        {
            hungry = true; 
        }
        else if (Console.ReadLine("yes")) //I know this isn't fully working, can't figure out why.
        {
            hungry = true;
        }
        else
            Console.WriteLine("Goodbye!");
    }
    while (hungry);
}


