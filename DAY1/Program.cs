/*Create a console app solution in visual studio code that will print your full name, age and gender*/
string FirstName = "Jeffre";
string MiddleName = "Aquino";
string LastName = "Villa";
int age = 22;
string gender = "Male";

Console.WriteLine($"Full Name: {FirstName} {MiddleName} {LastName}"); 
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Gender: {gender}");

/*Create decision logic with if statement*/
Random dice = new Random();

int dice1 = dice.Next(1, 7);
int dice2 = dice.Next(1, 7);
int dice3 = dice.Next(1, 7);

int sum = dice1 + dice2 + dice3;

Console.WriteLine("Rolled dice: {0}, {1}, {2}", dice1, dice2, dice3);
Console.WriteLine("Total sum: " + sum);

if (sum >= 15)
{
    Console.WriteLine("You Win");
}
else
{
    Console.WriteLine("Sorry You Lose");
}

/*Comparing 3 numbers*/

int num1 = 25;
int num2 = 75;
int num3 = 10;

Console.WriteLine("highest Number:"+ Math.Max(num1, Math.Max(num2,num3)));
Console.WriteLine("Lowest Number:"+ Math.Min(num1, Math.Min(num2,num3)));

/*Check if even*/
int numberToCheck = 6;

if (numberToCheck % 2 == 0)
{
    Console.WriteLine("Number" + " " + numberToCheck + " " + "is even");
}

else
{
    Console.WriteLine("Number" + " " + numberToCheck + " " + "is not even");
}