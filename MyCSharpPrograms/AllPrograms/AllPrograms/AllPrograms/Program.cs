
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine("Fuction and Recursion:");
        Console.WriteLine("Choose the following program :- ");
        Console.WriteLine();
        Console.WriteLine("1. Cube");
        Console.WriteLine("2. Circle");
        Console.WriteLine("3. Max/Min");
        Console.WriteLine("4. Even/Odd");
        Console.WriteLine("5. Prime/Armstrong/Perfect");
        Console.WriteLine("6. Print Primes in Interval");
        Console.WriteLine("7. Strong numbers in range");
        Console.WriteLine("8. Armstrong numbers in range");
        Console.WriteLine("9. Perfect numbers in range");
        Console.WriteLine("10. Natural numbers from 1 to n");
        Console.WriteLine("11. Even/Odd numbers in range");
        Console.WriteLine("12. Sum of natural numbers 1 to n");
        Console.WriteLine("13. Sum of even/odd numbers in range");
        Console.WriteLine("14. Reverse a number");
        Console.WriteLine("15. Check palindrome");
        Console.WriteLine("16. Sum of digits of a number");
        Console.WriteLine("17. Factorial of a number");
        Console.WriteLine("18. nth Fibonacci term");
        Console.WriteLine("19. GCD of two numbers");
        Console.WriteLine("20. LCM of two numbers");
        Console.WriteLine();

        int choice = int.Parse(Console.ReadLine()!);

        switch (choice)
        {
            case 1: 
                CubeProgram(); 
                 break;
            case 2:
                CircleProgram();
                 break;
            case 3: 
                MaxMinProgram(); 
                break;
            case 4: 
                EvenOddProgram(); 
                break;
            case 5: 
                PrimeArmstrongPerfectProgram(); 
                break;
            case 6: 
                PrintPrimesInRange();
                 break;
            case 7: 
                PrintStrongInRange();
                 break;
            case 8: 
                PrintArmstrongInRange(); 
                break;
            case 9: 
                PrintPerfectInRange();
                 break;
            case 10: 
                PrintNaturalNumbers();
                 break;
            case 11: 
                PrintEvenOddNumbers(); 
                break;
            case 12: 
                SumNaturalNumbers(); 
                break;
            case 13: 
                SumEvenOddNumbers(); 
                break;
            case 14:
                ReverseNumberProgram(); 
                break;
            case 15: 
                CheckPalindrome();
                 break;
            case 16: 
                SumDigitsProgram(); 
                break;
            case 17:  
                FactorialProgram();  
                break;
            case 18: 
                FibonacciProgram(); 
                 break;
            case 19: 
                GCDProgram(); 
                break;
            case 20: 
               LCMProgram(); 
               break;
            default: 
               Console.WriteLine("Invalid choice"); 
               break;
        }
    }

    
    static void CubeProgram()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Cube = " + (n * n * n));
    }

   


    static void CircleProgram()
    {
        Console.Write("Enter radius: ");
        double r = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Diameter = " + (2 * r));
        Console.WriteLine("Circumference = " + (2 * Math.PI * r));
        Console.WriteLine("Area = " + (Math.PI * r * r));
    }

    


    static void MaxMinProgram()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Maximum = " + Math.Max(a, b));
        Console.WriteLine("Minimum = " + Math.Min(a, b));
    }




    static void EvenOddProgram()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine()!);
        Console.WriteLine(IsEven(num) ? "Even" : "Odd");
    }
    static bool IsEven(int n) => n % 2 == 0;

   


    static void PrimeArmstrongPerfectProgram()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine()!);
        Console.WriteLine(IsPrime(num) ? "Prime" : "Not Prime");
        Console.WriteLine(IsArmstrong(num) ? "Armstrong" : "Not Armstrong");
        Console.WriteLine(IsPerfect(num) ? "Perfect" : "Not Perfect");
    }
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }
    static bool IsArmstrong(int n)
    {
        int sum = 0, temp = n, digits = n.ToString().Length;
        while (temp != 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, digits);
            temp /= 10;
        }
        return sum == n;
    }
    static bool IsPerfect(int n)
    {
        int sum = 0;
        for (int i = 1; i < n; i++)
            if (n % i == 0) sum += i;
        return sum == n;
    }




    static void PrintPrimesInRange()
    {
        Console.Write("Enter lower bound: ");
        int lower = int.Parse(Console.ReadLine()!);
        Console.Write("Enter upper bound: ");
        int upper = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Primes in range:");
        for (int i = lower; i <= upper; i++)
            if (IsPrime(i)) Console.Write(i + " ");
        Console.WriteLine();
    }

  



    static void PrintStrongInRange()
    {
        Console.Write("Enter lower bound: ");
        int lower = int.Parse(Console.ReadLine()!);
        Console.Write("Enter upper bound: ");
        int upper = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Strong numbers in range:");
        for (int i = lower; i <= upper; i++)
            if (IsStrong(i)) Console.Write(i + " ");
        Console.WriteLine();
    }
    static bool IsStrong(int n)
    {
        int sum = 0, temp = n;
        while (temp > 0)
        {
            sum += Factorial(temp % 10);
            temp /= 10;
        }
        return sum == n;
    }
    static int Factorial(int n) => n <= 1 ? 1 : n * Factorial(n - 1);

   




    static void PrintArmstrongInRange()
    {
        Console.Write("Enter lower bound: ");
        int lower = int.Parse(Console.ReadLine()!);
        Console.Write("Enter upper bound: ");
        int upper = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Armstrong numbers in range:");
        for (int i = lower; i <= upper; i++)
            if (IsArmstrong(i)) Console.Write(i + " ");
        Console.WriteLine();
    }





    static void PrintPerfectInRange()
    {
        Console.Write("Enter lower bound: ");
        int lower = int.Parse(Console.ReadLine()!);
        Console.Write("Enter upper bound: ");
        int upper = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Perfect numbers in range:");
        for (int i = lower; i <= upper; i++)
            if (IsPerfect(i)) Console.Write(i + " ");
        Console.WriteLine();
    }

 




    static void PrintNaturalNumbers()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Natural numbers:");
        PrintNatural(1, n);
        Console.WriteLine();
    }
    static void PrintNatural(int current, int n)
    {
        if (current > n) return;
        Console.Write(current + " ");
        PrintNatural(current + 1, n);
    }






    static void PrintEvenOddNumbers()
    {
        Console.Write("Enter start: ");
        int start = int.Parse(Console.ReadLine()!);
        Console.Write("Enter end: ");
        int end = int.Parse(Console.ReadLine()!);
        Console.Write("1 for Even, 0 for Odd: ");
        bool even = Console.ReadLine() == "1";
        PrintEvenOddRecursive(start, end, even);
        Console.WriteLine();
    }
    static void PrintEvenOddRecursive(int start, int end, bool even)
    {
        if (start > end) return;
        if ((even && start % 2 == 0) || (!even && start % 2 != 0))
            Console.Write(start + " ");
        PrintEvenOddRecursive(start + 1, end, even);
    }

   





    static void SumNaturalNumbers()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Sum = " + SumNatural(1, n));
    }
    static int SumNatural(int current, int n)
    {
        if (current > n) return 0;
        return current + SumNatural(current + 1, n);
    }

    



    static void SumEvenOddNumbers()
    {
        Console.Write("Enter start: ");
        int start = int.Parse(Console.ReadLine()!);
        Console.Write("Enter end: ");
        int end = int.Parse(Console.ReadLine()!);
        Console.Write("1 for Even sum, 0 for Odd sum: ");
        bool even = Console.ReadLine() == "1";
        Console.WriteLine("Sum = " + SumEvenOddRecursive(start, end, even));
    }
    static int SumEvenOddRecursive(int start, int end, bool even)
    {
        if (start > end) return 0;
        int sum = SumEvenOddRecursive(start + 1, end, even);
        if ((even && start % 2 == 0) || (!even && start % 2 != 0))
            sum += start;
        return sum;
    }

   



    static void ReverseNumberProgram()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Reversed = " + ReverseNumber(n, 0));
    }
    static int ReverseNumber(int n, int rev)
    {
        if (n == 0) return rev;
        return ReverseNumber(n / 10, rev * 10 + n % 10);
    }




    static void CheckPalindrome()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine(ReverseNumber(n, 0) == n ? "Palindrome" : "Not Palindrome");
    }

   



    static void SumDigitsProgram()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Sum of digits = " + SumDigits(n));
    }
    static int SumDigits(int n)
    {
        if (n == 0) return 0;
        return n % 10 + SumDigits(n / 10);
    }

   



    static void FactorialProgram()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Factorial = " + Factorial(n));
    }





    static void FibonacciProgram()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine(n + "th Fibonacci term = " + Fibonacci(n));
    }
    static int Fibonacci(int n) => n <= 1 ? n : Fibonacci(n - 1) + Fibonacci(n - 2);

    


    static void GCDProgram()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("GCD = " + GCD(a, b));
    }
    static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);

 



    static void LCMProgram()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("LCM = " + (a * b) / GCD(a, b));
    }
}
