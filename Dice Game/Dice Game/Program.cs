Console.WriteLine("Dice is rolled! Guess the number!");
var userInput = Console.ReadLine();
var randomNumberGenerator = new RandomNumberGenerator();
int randNumber = randomNumberGenerator.generate();
var chances = new TrackChances();
while(chances.haveChances())
{
    if (new InputValidator().isValid(userInput))
    {
        if (new CheckEquality().check(int.Parse(userInput), randNumber))
        {
            Console.WriteLine("You Win!!");
            break;
        }
        else { 
            Console.WriteLine("You Lose!");
            randNumber = randomNumberGenerator.generate();
            Console.WriteLine("Guess the number: ");
            userInput = Console.ReadLine();
            chances.reduce();
        }
    }
}

class DiceGame
{
    
}
