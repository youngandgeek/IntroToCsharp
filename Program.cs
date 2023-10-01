// See https://aka.ms/new-console-template for more information

/**Console.WriteLine("Hello, World!");

//Console.WriteLine("enter your name");
//String firstName = Console.ReadLine();
//Console.WriteLine("enter your second name");
//String secondName = Console.ReadLine();

////writeLine with concatination syntax
//Console.WriteLine("Hello," + firstName + " " + secondName);
//// writeline with plase holder syntax {0},{1} is a place holder for the inputed values
Console.WriteLine("Hello,{0} {1}", firstName, secondName);
**/

////coffee shop program
/***
 * int totalCost=0;
int userChoice;
String userDecission;

Console.WriteLine("Hello, Welcome to The Coffee Shop");

Start:

Console.WriteLine("Please enter your Choice, 1:Small , 2:Medium , 3:Large ");

//parse the user input to store it as an Int from readline
userChoice = int.Parse(Console.ReadLine());

switch (userChoice)
{
    case 1:
        totalCost += 1;
        break;
    case 2:
        totalCost += 2;
        break;
    case 3:
        totalCost += 3;
        break;
    default: 
        Console.WriteLine("Invalid input {0}", totalCost);
        goto Start;
       
}


Decide:
Console.WriteLine("Would you like to add anything else- Yes or No ");

userDecission = Console.ReadLine();

//add .toUpper to avoid case sensitive
switch (userDecission.ToUpper())
{
    case "YES":
        goto Start;

    case "NO":
        break;

    default:
        Console.WriteLine("your choice {0} is Invalid, Please try again.. ",userDecission);
        goto Decide;

}

Console.WriteLine("Total Cost= {0} ", totalCost, "Thank You have a nice day");
*/

///Do while Loop instead of goto label statement 
int target = 0; ;
int start=0;
String userDecission = string.Empty;

do
{
    Console.WriteLine("please enter target number");

target = int.Parse(Console.ReadLine());

while (start <= target)
{
    Console.Write(start + " ");
    start=start+2;

}
    do
    {
        Console.WriteLine("Do you want to continoue? Yes Or No");
        userDecission = Console.ReadLine().ToUpper();
        if (userDecission != "YES" && userDecission != "NO")
        {
            Console.WriteLine("Invalid answer please try again");
        }

    }
    while (userDecission != "YES" && userDecission != "NO");
    }
    while (userDecission=="YES");
