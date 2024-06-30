public class DiceGame
{
    private Dice _dice;
    private const int _initialChance = 3;
    public DiceGame(Dice dice)
    {
        _dice = dice;
    }
    
    public void play()
    {
        var diceResult = _dice.roll();
        Console.WriteLine($"Dice is rolled, and value is {diceResult}." +
            $" Guess the number. {_initialChance} chances remaining!");
        var triesLeft = _initialChance;
        while (triesLeft > 0)
        {
            triesLeft--;
            var userGuess = UserInput.ReadInteger("Enter a number: ");
            if (isValid(userGuess))
            {
                bool hasMatched = Compare(int.Parse(userGuess), diceResult);
                if (hasMatched)
                {
                    PrintResult(hasMatched, triesLeft);
                    break;
                }
                PrintResult(hasMatched, triesLeft);
            }  
        }
    }

    private void PrintResult(bool hasMatched, int triesLeft)
    {
        if (hasMatched)
        {
            Console.WriteLine("You win!!");
        }
        else if(triesLeft > 0)
        {
            Console.WriteLine($"Wrong number! You have {triesLeft} tries left.");
        }
        else
        {
            Console.WriteLine($"You lose!");
        }
    }

    private bool Compare(int first, int second)
    {
        if(first == second)
        {
            return true;
        }
        return false;
    }

    private bool isValid(string userInput)
    {
        if (userInput == null || !int.TryParse(userInput, out int result))
        {
            return false;
        }
        return true;
    }
}

