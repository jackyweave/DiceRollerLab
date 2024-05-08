using System.ComponentModel.Design;
using System.Diagnostics;

class program
{
    static void Main()
    {
        bool rollAgain = true;
        //loop for number
        while (rollAgain)
        {
            Console.WriteLine("Enter the number of sides for a pair of dice: ");
          
            int sides = GetNumberInput();

            int dice1 = RollDice(sides);
            int dice2 = RollDice(sides);
            Console.WriteLine($"Dice 1: {dice1}");
            Console.WriteLine($"Dice 2: {dice2}");

            string combo = CheckCombo(dice1, dice2); 
            string total = CheckTotal(dice1, dice2);
            if (!string.IsNullOrEmpty(combo))
            {
                Console.WriteLine("Combination" + combo); 
            }

            if (!string.IsNullOrEmpty(total))
            {
                Console.WriteLine("Do you want to roll again? (y/n)");
                rollAgain = Console.ReadLine().ToUpper() == "y"; 
            }



        }

    }



    //method 
    static int GetNumberInput()
    {
        while (true)
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number! :)");
            }
        }
    }


    static int RollDice(int sides)
    {
        Random random = new Random();
        return random.Next(1, sides + 1);
    }
    //adding name
    static string CheckCombo(int dice1, int dice2)
    {
        if (dice1 == 1 && dice2 == 1)
        {
            return "Snake Eyes";
        }
        else if (dice1 == 1 && dice2 == 2)
        {
            return "Ace Deuce";
        }
        else if ((dice1 == 6 && (dice2 == 6)))

        {
            return "Box Cars";
        }

        return "";
    }
    //conclusion
    static string CheckTotal(int dice1, int dice2)
    {
        int total = dice1 + dice2;
        if (total == 7 || total == 11)
        {
            return "Win";
        }
        else if (total == 2 || total == 3 || total == 12)

        {
            return "Craps";
        }

        return "";
    }























































}

