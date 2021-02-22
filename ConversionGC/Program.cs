using System;

class MainClass

{

    public static void Main(string[] args)
    {
        //variables defined 
        string userInput;
        double value;
        double value2;
        string unit;
        double uTranslateF = 3.5;
        double uTranslateM = 5;

        //start loop
        while (true)
        {

            Console.WriteLine("Please Input Unit"); //measurement type

            unit = Console.ReadLine();

            Console.WriteLine("Please Input number"); //amount

            value = Convert.ToDouble(Console.ReadLine()); //convert and store data

            if (unit == "inches")
            { // inches to fidgetspinners with converted output
                value2 = (value * uTranslateF);
                Console.WriteLine(value + " inches = " + value2 + " fidgetspinners");
            }

            else if (unit == "fidgetspinners")
            { //fidgetspinners to inches with converted output
                value2 = (value / uTranslateF);
                Console.WriteLine(value + " fidgetspinners = " + value2 + " inches");
            }

            else if (unit == "feet")
            { //feet to memes with converted output
                value2 = (value * uTranslateM);
                Console.WriteLine(value + " feet = " + value2 + " memes");
            }

            else if (unit == "memes")
            { //memes to feet with converted output
                value2 = (value / uTranslateM);
                Console.WriteLine(value + " memes = " + value2 + " feet");
            }

            Console.WriteLine("Would you like to do another conversion??");
            userInput = Console.ReadLine();

            if (userInput != "yes")
                break;
        }
    }
}
                
            

        


    