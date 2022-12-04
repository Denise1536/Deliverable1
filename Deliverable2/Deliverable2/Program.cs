using System;

public class Menu
{public Double buffet = 9.99; 
    public Double smoothie = 3.99;
    public Double coffee = 1.99;
}

public class Program
{

    public static void Main()
    {

        Console.WriteLine("Welcome to our Mac & Cheese Buffet. All you can eat for $9.99! " +
            "We only charge extra for coffee & smoothies. How many people are in your group? " +
            "Please, groups of 6 or fewer.");
        int Num = int.Parse(Console.ReadLine());

        if (Num < 7)
        {
            Console.WriteLine("A table for " + Num + "! Please follow me and take a seat. " +
                "Let's get everyone started with some drinks. A water fountain and glasses are next to the plates;" +
                " if you want water you can grab that. We have flavor of the day smoothie or coffee.");
            Console.WriteLine(" ");

            for (int i = 1; i < Num; i++)
            {
                Console.WriteLine("Go ahead, person number " + i + " , smoothie or coffee?");
                String answer = (Console.ReadLine());
                
                if (answer == "coffee")
                {
                    Console.WriteLine("Coffee, Great!");
                }  //some way to get it to count number of coffees

                else if (answer == "smoothie")
                {
                    Console.WriteLine("Smoothie, Great!");
                }       //some way to get it to count number of smoothies

                else
                { Console.WriteLine("We don't have that option. You can get water from the fountain by the plates."); }
            }

            //I'll be able to finalize this part when I've figured out how to count replies...
            //Console.WriteLine("Okay, so that's __ coffees and __ smoothies. I'll be right back. Feel free to grab your food!");

            //Math to calculate bill:
            //Num*buffet = buffets
            //__*smoothie = smoothies
            //__*coffee = coffees
            //buffets + smoothies + coffees = total

            //Console.WriteLine("Here's you bill! Total price: $ __ ");

            break;
        }
        else
            { Console.WriteLine("Sorry, we can only seat groups up to 6 right now. Have a nice day."); }
    }

}
    //ps - I improved Deliverable 1 using what I learned doing this, and it works! I couldn't put up the changes though, because the "git push" on Terminal (as advised on the cheat sheet) returned an error about not having a destination. 