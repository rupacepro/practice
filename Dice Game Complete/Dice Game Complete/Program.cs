Random random = new Random();
Dice dice = new Dice(random);
DiceGame diceGame = new DiceGame(dice);
diceGame.play();
Console.ReadKey();

