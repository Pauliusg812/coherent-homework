/*
 Task 1. Create a console application, which asks the user for two integers a and b 
(assume that the user enters integers without errors). The application then prints out all integers 
in the range from a (inclusive) to b (inclusive), that have exactly two 2's in their ternary number system (0, 1, 2) representation.
Develop a console application that implements the specified functionality. 
Note: to convert a string s to an int value, use the int.Parse(s) method.*/

//Request for user to input his Number A and Number B

Console.WriteLine("Enter number A: ");
var numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Your number A is: " + numberA);

Console.WriteLine("Enter number B");
var numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Your number B is: " + numberB);

Display2TwosInNumbersRangeInTernary(numberA, numberB); 


static void Display2TwosInNumbersRangeInTernary(int numberA, int numberB)
{
    //listing of numbers and puting them into an absolute value as we dont know if number is negative or positive int
    var numbersRange = new List<int>();


    var loopsCount = Math.Abs(numberA - numberB);
    var smallerNumber = Math.Min(numberA, numberB);

    for (int i = 0; i <= loopsCount; i++)
    {
        numbersRange.Add(smallerNumber + i);
    }

    foreach (var number in numbersRange)
    {
        var ternary = ReverseString(ConvertToTernary(number));

        if (Has2Twos(ternary))
        {
            Console.WriteLine(number);
        }
    }

    Console.WriteLine();
}
//conversion to ternary number system
static string ConvertToTernary(int number)

{
    var remainder = number % 3;
    var integer = number / 3;

    if (integer == 0)
    {
        return remainder.ToString();
    }

    return remainder.ToString() + ConvertToTernary(integer);

}
// need to change the way of how ternary number is shown
static string ReverseString(string val)
{
    return new string(val.Reverse().ToArray());
}

//logic calculation of 2 two'sin ternary form of number
static bool Has2Twos(string ternary)
{
    var numberOfTwos = 0;

    foreach (var character in ternary)
    {
        if (character == '2')
        {
            numberOfTwos++;
        }
    }
    if (numberOfTwos == 2)
    {
        return true;
    }

    return false;

}


