using System.Diagnostics;
using Humanizer;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Quantities:");
HumanizeQuantities();

Console.WriteLine("\nDate/Time Manipulation:");
HumanizeDates();

static void HumanizeQuantities()
{
    Console.WriteLine("case".ToQuantity(0));
    Console.WriteLine("case".ToQuantity(1));
    Console.WriteLine("case".ToQuantity(5));
}

static void HumanizeDates()
{
    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
    Console.WriteLine(TimeSpan.FromDays(1).Humanize());
    Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}

int result = Fibonacci(6);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
    Debug.WriteLine($"We are looking for the {n}th number");    
    
    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
        Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
    }
    //no se verá este mensaje en la versión final del programa
    // ejecutar como -> 
    //                  dotnet run --configuration Release
    Debug.Assert(n2 == 5, "The return value is not 5 and it should be.");
    return n == 0 ? n1 : n2;
}

bool errorFlag = true;  
System.Diagnostics.Trace.WriteLineIf(errorFlag, "Error in AppendData procedure.");  
System.Diagnostics.Debug.WriteLineIf(errorFlag, "Transaction abandoned.");  
System.Diagnostics.Trace.WriteLine("Invalid value for data request");

int count = 0;
Debug.WriteLineIf(count == 0, "The count is 0 and this may cause an exception.");

int division1 = IntegerDivide(8,4);
Console.WriteLine("Resultado de 8/4="+division1.ToString());
//int division2 = IntegerDivide(8,0);
//Console.WriteLine("Resultado de 8/0="+division2.ToString());

int IntegerDivide(int dividend, int divisor)
{
    //no se verá este mensaje en la versión final del programa
    // ejecutar como -> 
    //                  dotnet run --configuration Release
    Debug.Assert(divisor != 0, $"{nameof(divisor)} is 0 and will cause an exception.");

    return dividend / divisor;
}
