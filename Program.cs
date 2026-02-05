//this is the begining code, to welcome users, and their choosing of 5 operators
Console.WriteLine("hello, let me calc 4 u");
Console.WriteLine("what operator do you want: +, -, *, /, %. which? ");
string userChoice = Console.ReadLine();

//answering

Console.WriteLine("enter a number");
string answer = Console.ReadLine();
int number1 = int.Parse(answer);
Console.WriteLine("enter your number");
answer = Console.ReadLine();
int number2 = int.Parse(answer);

//if statements

if(userChoice == "+")
{
    int result = number1 + number2;
    Console.WriteLine($"{number1} + {number2} = {result}");
}

else if(userChoice == "-")
{
    int result = number1 - number2;
    Console.WriteLine($"{number1} - {number2} = {result}");
}

else if(userChoice == "*")
{
    int result = number1 * number2;
    Console.WriteLine($"{number1} * {number2} = {result}");
}

else if(userChoice == "/")
{
    int result = number1 / number2;
    Console.WriteLine($"{number1} / {number2} = {result}");
}

else if(userChoice == "%")
{
    int result = number1 % number2;
    Console.WriteLine($"{number1} % {number2} = {result}");
}
else
{
    Console.WriteLine("not a valid operator");
}

