// code that can break goes in try
using System.Text.RegularExpressions;
using System.Threading.Channels;

int x = 0;
try
{
    // throws exception
    x = int.Parse("0");
    Console.WriteLine(5 / x);
}
// catch the exception
catch (FormatException e)
{
    Console.WriteLine("Value is not a number");
}
catch (Exception e)     // <-- this will catch everything
{
    Console.WriteLine(e.Message);
}
Console.WriteLine(x);


// create a try catch
// ask the user for a number
// parse the number to an int
// display an error message
// display the parsed number outside of the try catch

int y = 0;
while (true)
{
    try
    {
        Console.WriteLine("Enter a number");
        y = int.Parse(Console.ReadLine());
        if (y <= 0)
        {
            // this can just be a cw
            throw new Exception("input too low");

        }
        else
        {
            // valid
            break;
        }
        

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    
}

Console.WriteLine(y);


// TryParse
Console.WriteLine("Enter another number");
string input  = Console.ReadLine();
int value = -1;
if (int.TryParse(input, out value)) // (input string, parsed value)  // bool return
{
    Console.WriteLine(value);
}
else
{
    Console.WriteLine("Not valid");
}


// Validation loop with tryparse               (really good replacement with codes w numbers)
Console.WriteLine("Please enter a number");


//Justin's version
int result = -1;

while (result <= 0)
{
    while (int.TryParse(Console.ReadLine(), out result) == false)
    {
        Console.WriteLine("Invalid response. Try again");  //error message
    }
    if (result <= 0)
    {
        Console.WriteLine("Number too low. Try again");
    }
}

Console.WriteLine(result);

//Tim's version
//while ((int.TryParse(Console.ReadLine(), out result) == false) || result < 0)
//{
//    if (result <= 0)
//    {
//        Console.WriteLine("Number too low. Try again");
//    }
//}



// regex
Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

if (regex.IsMatch("justin.jones@grandcircus.co"))
{
    Console.WriteLine("Valid email");
}
else
{
    Console.WriteLine("Invalid email");
}


