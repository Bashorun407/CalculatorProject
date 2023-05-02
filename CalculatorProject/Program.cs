//Global variables
using System.Reflection;
using System.Runtime.CompilerServices;

double var1 = 0.0; //This is a global variable representing user's first input
double var2 = 0.0; //This is a global variable representing user's second input
double result; //All calculation results will be stored in this variable
string input = string.Empty; //This string accepts user input
bool checkDigit = false; //This boolean checks if user enters the correct digit
bool quitApp = true; //This boolean helps terminate the while loop...and the program

Console.ForegroundColor = ConsoleColor.Green; //Changes the font colour to green

//A while loop...which displays users options and runs the entire implementation of subsequent functions
while (quitApp)
{
    Console.WriteLine("WELCOME...Feel free to do your computations!!!\n");
    Console.WriteLine(" Press 1 for Addition\n Press 2 for Subtraction \n Press 3 for Multiplication \n Press 4 for Division" +
        "\n Press 5 for Exponent \n Press 6 for Square Root \n Press 7 for Sine \n Press 8 for Cosine \n Press 9 for Tangent\n" +
        "Press 10 to Quit\n".ToUpper());
    input = Console.ReadLine();

    checkDigit = int.TryParse(input, out int x);

    //if statement to check user input
    if (checkDigit == true)
    {
        //if statement to check that user's input is within the desired range (1 - 10)
        if (x >= 1 && x <= 10)
        {
            switch (x)
            {
                case 1://Addition
                    try
                    {
                        //Prompts users for input
                        Console.WriteLine("ADDITION- Enter first digit: ");
                        var1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second digit: ");
                        var2 = double.Parse(Console.ReadLine());

                        //Calls the addition method
                        result = addition(var1, var2);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(result, decimalPlaces);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Enter valid integers only. {ex.Message}");
                    }
                    break;

                case 2: //Subtraction
                    try
                    {
                        //Prompts users for input
                        Console.WriteLine("SUBTRACTION- Enter first digit: ");
                        var1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second digit: ");
                        var2 = double.Parse(Console.ReadLine());

                        //Calls the addition method
                        result = subtraction(var1, var2);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(result, decimalPlaces);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Enter valid integers only. {ex.Message}");
                    }
                    break;

                case 3: //Multiplication
                    try
                    {
                        //Prompts users for input
                        Console.WriteLine("MULTIPLICATION- DEnter first digit: ");
                        var1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second digit: ");
                        var2 = double.Parse(Console.ReadLine());

                        //Calls the addition method
                        result = multiplication(var1, var2);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(result, decimalPlaces);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Enter valid integers only. {ex.Message}");
                    }
                    break;

                case 4://Division
                    try
                    {
                        //Prompts users for input
                        Console.WriteLine("DIVISION- Enter first digit: ");
                        var1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second digit: ");
                        var2 = double.Parse(Console.ReadLine());

                        //Calls the addition method
                        result = division(var1, var2);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(result, decimalPlaces);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Enter valid integers only. {ex.Message}");
                    }
                    break;

                case 5: //Exponents
                    try
                    {
                        //Prompts users for input
                        Console.WriteLine("Enter number to find Exponent: ");
                        var1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter power: ");
                        var2 = double.Parse(Console.ReadLine());

                        //Calls the addition method
                        result = Exponents(var1, (int)var2);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(result, decimalPlaces);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Enter valid integers only. {ex.Message}");
                    }
                    break;

                case 6: //Square Roots
                    try
                    {
                        //Prompts users for input
                        Console.WriteLine("Enter to find Square Root: ");
                        var1 = double.Parse(Console.ReadLine());
                        

                        //Calls the addition method
                        result = SquareRoots(var1);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(result, decimalPlaces);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Enter valid integers only. {ex.Message}");
                    }
                    break;

                case 7: //Sine
                    try
                    {
                        //Prompts users for input
                        Console.WriteLine("Enter digit to find Sine: ");
                        var1 = double.Parse(Console.ReadLine());
                        

                        //Calls the addition method
                        result = Sine(var1);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(result, decimalPlaces);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Enter valid integers only. {ex.Message}");
                    }
                    break;

                case 8: //Cosine
                    try
                    {
                        //Prompts users for input
                        Console.WriteLine("Enter digit to find Cosine: ");
                        var1 = double.Parse(Console.ReadLine());


                        //Calls the addition method
                        result = Cosine(var1);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(result, decimalPlaces);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Enter valid integers only. {ex.Message}");
                    }
                    break;

                case 9: //Tangent
                    try
                    {
                        //Prompts users for input
                        Console.WriteLine("Enter digit to find Tangent: ");
                        var1 = double.Parse(Console.ReadLine());


                        //Calls the addition method
                        result = Tangent(var1);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(result, decimalPlaces);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Enter valid integers only. {ex.Message}");
                    }
                    break;

                case 10: //Here, the user quits and stops the application
                    Console.WriteLine("Thank you for using this application...bye bye");
                    quitApp = false;
                    break;
            }
        }

        else
        {
            Console.WriteLine("You should enter numbers from 1 to 10 only!!\n");
        }
        
    }
    else
    {
        Console.WriteLine("Ensure to enter only digits as specified in the drop-down menu.\n");
    }
    //Using a switch to acc
   
}

//addition method double
double addition(double a, double b)
{
    Console.WriteLine($"{a} + {b} = {a + b}\n");
    return a + b;
}


//subtraction methods for double
double subtraction(double a, double b)
{
    Console.WriteLine($"{a} - {b} = {a - b}\n");
    return a - b;
}


//multiplication method for double
double multiplication(double a, double b)
{
    Console.WriteLine($"{a} X {b} = {a * b}\n");
    return a * b;
}


//division method
double division(double a, double b)
{
    try
    {
        Console.WriteLine($"{a} / {b} = {a / b}\n");
    }
    catch (Exception e)
    {
        Console.WriteLine($" Error {e} occured and it means {e.Message}!!!");
    }

    return a / b;
}

//exponential method 
double Exponents(double number, int power)
{
    double answer = Math.Pow(number, power);
    Console.WriteLine($"{number} raised to power {power} = {answer}\n");
    return answer;
}

//squareroots method
double SquareRoots(double number)
{
    double answer = Math.Sqrt(number);
    Console.WriteLine($"Square Root of {number} = {answer}\n");
    return answer;
}

//Trigonometric functions
//Sine
double Sine(double number)
{
    //Converting each number the user enters to radian...in order to get the correct answer by multiplying number with (3.142/180) = (22.0/1260)
    double answer = Math.Sin(number * (22.0/1260));
    Console.WriteLine($"Sine of {number} = {answer}\n");
    return answer;
}

//Cosine
double Cosine(double number)
{
    //Converting each number the user enters to radian...in order to get the correct answer by multiplying number with (3.142/180)
    double answer = Math.Cos(number * (22.0/1260));
    Console.WriteLine($"Cosine of {number} = {answer}\n");
    return answer;
}

//Tangent
double Tangent(double number)
{
    //Converting each number the user enters to radian...in order to get the correct answer by multiplying number with (3.142/180)
    double answer = Math.Tan(number * (22.0/1260)); 
    Console.WriteLine($"Tangent of {number} = {answer}\n");
    return answer;
}

//Attempting to write precision method to handle decimal places
//accepts number of decimal places
//formats a number in the required number of places
//returns the approximated number
void DecimalPrecision(double numberToApproximate, int numberOfDecimalPlaces)
{
    double approximatedNumber = Math.Round(numberToApproximate, numberOfDecimalPlaces);

    Console.WriteLine($"Answer in {numberOfDecimalPlaces} decimal places = {approximatedNumber}\n");
}
