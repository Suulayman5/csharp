// See https://aka.ms/new-console-template for more information

// Console.WriteLine("   /|");
// Console.WriteLine("  / |");
// Console.WriteLine(" /  |");
// Console.WriteLine("/___|");

// int age = 25;
// string name = "suleiman ajah";
// string city = "lagos";

// Console.WriteLine($"My name is {name}, i am {age} years old and i live in {city} state.");
// Console.WriteLine(50 % 3);
// Console.WriteLine(50 / 3);
// Console.WriteLine(Math.Round(50.2));

// Console.WriteLine("Enter Your Name: ");
// string userName = Console.ReadLine();
// Console.WriteLine($"Hello {userName}, welcome to C#");

// Console.Write("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(" enter another number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The sum of {num} and {num2} is {num + num2}");

// Console.Write(" enter a number: ");
// double num3 = Convert.ToDouble(Console.ReadLine());

// Console.Write(" enter another num: ");
// double num4 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($" {num3 + num4}");

// string color, pluralNoun, celebrity;

// Console.WriteLine("enter a color:");
// color = Console.ReadLine();
// Console.WriteLine("enter a plural noun:");
// pluralNoun = Console.ReadLine();
// Console.WriteLine("enter a celebrity:");
// celebrity = Console.ReadLine();
// Console.WriteLine($"Roses are {color} {pluralNoun} are blue and I love {celebrity}");

int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
Console.WriteLine(luckyNumbers[3]);
SayHi("sule");
SayHi("sanni");
SayHi("tom");
SayHi("patt");
Console.WriteLine(cube(5));

static void SayHi(string name) {
    Console.WriteLine($"hiiii {name}");
}

static int cube(int num) {
    int result = num * num * num + num;
    return result;
}

bool isMale = false;
bool isTall = true;

if (isMale || isTall)
{
    Console.WriteLine("You are male and 6ft4");
} else
{
    Console.WriteLine("You are female and 4ft3");

}

// static int GetMax(int num1, int num2) {
//     int result;
//     if (num1 > num2)
//     {
//         result = num1;
//     } else
//     {
//         result = num2;
//     }
//     return result;
// };

// Console.WriteLine(GetMax(2, 11));


// static int getMin( int num3, int num4){
//     if (num3 < num4)
//     {
//         return num3;
//     }else {
//         return num4;
//     }
// };

// Console.WriteLine(getMin(8,6));



//calculator


// Console.Write("Enter a number: ");

// double num1 = Convert.ToDouble(Console.ReadLine());


// Console.Write("Enter operator: ");

// string op = Console.ReadLine();
// Console.Write("Enter a number: ");

// double num2 = Convert.ToDouble(Console.ReadLine());

// if (op == "+")
// {
//     Console.WriteLine($"your answer is {num1 + num2}");
// }
// else if (op == "-")
// {
//     Console.WriteLine($"your answer is {num1 - num2}");

// }
// else if (op == "/")
// {
//     Console.WriteLine($"your answer is {num1 / num2}");

// }
// else
// {
//     Console.WriteLine($"your answer is {num1 * num2}");

// }


// Console.Write("Enter a number: ");
// double num1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter an operator: ");
// string op = Console.ReadLine();

// Console.Write("Enter your second number: ");
// double num2 = Convert.ToDouble(Console.ReadLine());

// if (op == "+")
// {
//     Console.WriteLine($"Your ansa is {num1 + num2}");
// }
// else if (op == "-")
// {
//     Console.WriteLine($"Your ansa is {num1 - num2}");
// }
// else if (op == "*")
// {
//     Console.WriteLine($"Your ansa is {num1 * num2}");
// }
// else if (op == "/")
// {
//     Console.WriteLine($"Your ansa is {num1 / num2}");
// }else
// {
//     Console.WriteLine("invalid operator");
// }

static string GetDay(int dayNum)
{
    string dayName;

    switch (dayNum)
    {
        case 0:
            dayName = "Sunday";
            break;
        case 1:
            dayName = "Monday";
            break;
        case 2:
            dayName = "Tuesday";
            break;
        case 3:
            dayName = "Wednesday";
            break;
        case 4:
            dayName = "Thursday";
            break;
        case 5:
            dayName = "Friday";
            break;
        case 6:
            dayName = "Saturday";
            break;
        default:
            dayName = "Invalid";
            break;

    }

    return dayName;
};
Console.WriteLine(GetDay(2));


int index = 24;

while (index <= 26)
{
    Console.WriteLine($" i am {index} years old");
    index++;
}

string secretWord = "tangiro";
string guess = "";

while (guess != secretWord)
{
    Console.WriteLine("Enter a guess: ");
    guess = Console.ReadLine();

    if (guess == secretWord)
    {
        Console.WriteLine($"Congrats you won! the word was {guess}");
    }
}
int num = 0;
while (num <= 10)
{
    Console.WriteLine(num);
    num++;
}
Build a simple number guessing game where the user must guess a number between 1 and 10. 
Give feedback like “Too high” or “Too low” until they get it right.

int num = 5;
int guess = 0;
int guessCount = 0;
int guessLimit = 3;
bool outOfGuesses = false;
while (num != guess && !outOfGuesses)
{
    if (guessCount < guessLimit)
    {

        Console.WriteLine("input your guess");
        guess = Convert.ToInt32(Console.ReadLine());
        guessCount++;
        if (guess < num)
        {
            Console.WriteLine("Too Low");
        }
        else if (guess > num)
        {
            Console.WriteLine("Too High");

        }
        else if (guess == num)
        {
            Console.WriteLine($"You Win! Your guess was {guess}");

        }
        else
        {
            Console.WriteLine("Invalid Input");

        }
    }
    else
    {
        outOfGuesses = true;
    }

}
if (outOfGuesses)
{
    Console.WriteLine("You Lose, maximum guess count");

}

int num = 5;

int guess = 0;
int guesscount = 0;
int guessLimit = 4;

bool outOfGuess = false;

while (guess != num && !outOfGuess)
{
    if (guesscount < guessLimit)
    {
        Console.WriteLine("Enter your guess: ");
        guess = Convert.ToInt32(Console.ReadLine());
        guesscount++;
        if (guess == num)
        {
            Console.WriteLine($"You Win! your guess was {guess} ");

        };
    }else
    { 
        outOfGuess = true;
    }
};
if (outOfGuess)
{
    Console.WriteLine("You Loose");

};


// for loop

int[] luckyNumber = { 4, 8, 15, 16, 23, 42 };

for (int i = 0; i < luckyNumber.Length; i++)
{
    Console.WriteLine(luckyNumber[i]);
}

static int GetPower(int baseNum, int powNum)
{
    // baseNum ^ powNum;
    int result = 1;
    for (int i = 0; i < powNum; i++)
    {
        result = result * baseNum;
    }
    return result;
}
;
Console.WriteLine(GetPower(4, 2));

int[,] numberGrid = {
    {1, 5},
    { 3, 4},
    { 2, 9}
 };
Console.WriteLine(numberGrid[2, 1]);



// // exception handling

try
{
    Console.WriteLine("enter a number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter another number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($" your ansa is {num1 - num2}");
}
catch (System.Exception e)
{
    Console.WriteLine(e.Message);

    throw;
}













Console.ReadLine();
