//Global variables
using System.Reflection;
using System.Runtime.CompilerServices;

double var1 = 0;
double var2 = 0;
string input = string.Empty;
bool checkDigit = false;

Console.ForegroundColor = ConsoleColor.Green; //Changes the font colour to green
//An infinite loop...which 
while (true)
{
    Console.WriteLine("WELCOME...Feel free to do your computations!!!\n");
    Console.WriteLine(" Press 1 for Addition\n Press 2 for Subtraction \n Press 3 for Multiplication \n Press 4 for Division" +
        "\n Press 5 for Exponent \n Press 6 for Square Root \n Press 7 for Sine \n Press 8 for Cosine \n Press 9 for Tangent\n".ToUpper());
    input = Console.ReadLine();

    checkDigit = int.TryParse(input, out int x);

    //if statement to check user input
    if (checkDigit == true)
    {
        if (x >= 1 && x <= 9)
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
                        double additionResult = addition(var1, var2);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(additionResult, decimalPlaces);

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
                        double subtractionResult = subtraction(var1, var2);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(subtractionResult, decimalPlaces);
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
                        double multiplicationResult = multiplication(var1, var2);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(multiplicationResult, decimalPlaces);
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
                        double divisionResult = division(var1, var2);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(divisionResult, decimalPlaces);
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
                        double exponentResult = Exponents(var1, (int)var2);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(exponentResult, decimalPlaces);
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
                        double squareRootResult = SquareRoots(var1);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(squareRootResult, decimalPlaces);
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
                        double sineResult = Sine(var1);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(sineResult, decimalPlaces);
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
                        double cosineResult = Cosine(var1);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(cosineResult, decimalPlaces);
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
                        double tangentResult = Tangent(var1);

                        //Prompts the user for the number of decimal places to approximate answer to
                        Console.WriteLine("Enter the number of decimal places to round result to: ");
                        int decimalPlaces = int.Parse(Console.ReadLine());

                        //This function approximates answer to specified number of places
                        DecimalPrecision(tangentResult, decimalPlaces);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Enter valid integers only. {ex.Message}");
                    }
                    break;
            }
        }

        else
        {
            Console.WriteLine("You should enter numbers from 1 to 4 only!!");
        }
        
    }
    //Using a switch to acc
   
}

//addition method double
double addition(double a, double b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
    return a + b;
}


//subtraction methods for double
double subtraction(double a, double b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
    return a - b;
}


//multiplication method for double
double multiplication(double a, double b)
{
    Console.WriteLine($"{a} X {b} = {a * b}");
    return a * b;
}


//division method
double division(double a, double b)
{
    try
    {
        Console.WriteLine($"{a} / {b} = {a / b}");
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
    Console.WriteLine($"Exponent is: {answer}");
    return answer;
}

//squareroots method
double SquareRoots(double number)
{
    double answer = Math.Sqrt(number);
    Console.WriteLine($"Exponent is: {answer}");
    return answer;
}

//Trigonometric functions
//Sine
double Sine(double number)
{
    //Converting each number the user enters to radian...in order to get the correct answer by multiplying number with (3.142/180) = (22.0/1260)
    double answer = Math.Sin(number * (22.0/1260));
    Console.WriteLine($"Sine is: {answer}");
    return answer;
}

//Cosine
double Cosine(double number)
{
    //Converting each number the user enters to radian...in order to get the correct answer by multiplying number with (3.142/180)
    double answer = Math.Cos(number * (22.0/1260));
    Console.WriteLine($"Cosine is: {answer}");
    return answer;
}

//Tangent
double Tangent(double number)
{
    //Converting each number the user enters to radian...in order to get the correct answer by multiplying number with (3.142/180)
    double answer = Math.Tan(number * (22.0/1260)); 
    Console.WriteLine($"Exponent is: {answer}");
    return answer;
}

//Attempting to write precision method to handle decimal places
//accepts number of decimal places
//formats a number in the required number of places
//returns the approximated number
void DecimalPrecision(double numberToApproximate, int numberOfDecimalPlaces)
{
    double approximatedNumber = Math.Round(numberToApproximate, numberOfDecimalPlaces);

    Console.WriteLine($"Answer in {numberOfDecimalPlaces} decimal places is: {approximatedNumber}");
}
