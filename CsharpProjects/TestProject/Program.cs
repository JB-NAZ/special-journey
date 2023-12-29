Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
string win = "You win";
string lose = "You lose";

int total = roll1 + roll2 + roll3;

Console.WriteLine("Dice\tScores:");
if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    Console.WriteLine("\nYou got +2 bonus points for rolling doubles!");
    total = total + 2;
}
if (roll1 == roll2 && roll1 == roll3)
{
    Console.WriteLine("\nYou got +6 bonus points for rolling tripples!");
    total = total + 6;
}
Console.WriteLine($"\nDice roll: {roll1} + {roll2} + {roll3} = {total}\n");

if (total >= 15)
{
    Console.WriteLine(win);
}
else if (total < 15)
{
    Console.WriteLine(lose);
}