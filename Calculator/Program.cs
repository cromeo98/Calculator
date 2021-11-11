using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;

            //Console.WriteLine("Inserisci un numero.");
            //num1 = double.Parse(Console.ReadLine()); //ricorda che il readLine restituisce STRINGHE
            //Console.WriteLine("Inserisci il secondo numero");
            //num2 = double.Parse(Console.ReadLine());

            //Solution /many variables
            //int sum = num1 + num2;
            //Console.WriteLine("Sum = " + sum);

            //int substraction = num1 - num2;
            //Console.WriteLine("Substraction = " + substraction);

            //int multiplication = num1 * num2;
            //Console.WriteLine("Multiplication = " + multiplication);

            //int division = num1 / num2;
            //Console.WriteLine("Division = " + division);

            //int min = Math.Min(num1, num2);
            //Console.WriteLine("The minimum number is: " + min);

            //int max = Math.Max(num1, num2);
            //Console.WriteLine("The maximum number is: " + max);

            //Solution /user choosing operator
            string userOperator = "";

            //Console.WriteLine("Choose an operator between +, -, *, /, MIN, MAX, POW, ROOT, RAND");
            //userOperator = Console.ReadLine().ToUpper();         

            while (userOperator != "+" && userOperator != "-" && userOperator != "*" && userOperator != "/" && userOperator != "MIN" && userOperator != "MAX" && userOperator != "POW" && userOperator != "ROOT" && userOperator != "RAND")
            {
                Console.WriteLine("Choose an operator between +, -, *, /, MIN, MAX, POW, ROOT, RAND");
                userOperator = Console.ReadLine().ToUpper();
                //Console.WriteLine(userOperator);
            }

            if (userOperator == "ROOT")
            {
                Console.WriteLine("Inserisci un numero.");
                num1 = double.Parse(Console.ReadLine()); //ricorda che il readLine restituisce STRINGHE
            } else
            {
                Console.WriteLine("Inserisci un numero. (Se hai scelto RAND, il numero è l'inizio del range in cui verrà riportato il numero random)");
                num1 = double.Parse(Console.ReadLine()); //ricorda che il readLine restituisce STRINGHE
                Console.WriteLine("Inserisci il secondo numero.  (Se hai scelto RAND, il numero è la fine del range in cui verrà riportato il numero random)");
                num2 = double.Parse(Console.ReadLine());
            }

            double result;

            //AppDomainSetup random
            Random rand = new Random();
            double range = num2;

            //cases
            switch (userOperator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "MIN":
                    result = Math.Min(num1, num2);
                    break;
                case "MAX":
                    result = Math.Max(num1, num2);
                    break;
                case "POW": 
                    result = Math.Pow(num1, num2);
                    break;
                case "ROOT":
                    result = Math.Sqrt(num1);
                    break;
                case "RAND":
                    result = Math.Floor(rand.NextDouble() * range) + 1;
                    break;
                default:
                    result = 0;
                    break;

            }
            Console.WriteLine("The result is = " + result);
        }
    }
}
