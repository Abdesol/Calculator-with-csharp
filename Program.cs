using System;


namespace Calculator
{
    class Calculator
    { 
        static void Main(string[] args)
        {
            string options = "\tCalculator\n A) Addition\n S) Subtraction\n M) Multiplication\n D) Division\n Q) Quit)";
            while (true)
            {
                Console.WriteLine(options);
                Console.Write("Choice a letter from the options above: ");
                string option = Console.ReadLine();
                if (option == "A")
                {
                    Console.WriteLine(Startopr('+'));
                }else if (option == "S")
                {
                    Console.WriteLine(Startopr('-'));
                }
                else if (option == "M")
                {
                    Console.WriteLine(Startopr('*'));
                } else if (option == "D")
                {
                    Console.WriteLine(Startopr('/'));
                } else if (option == "Q")
                {
                    Console.WriteLine("Bye");
                    break;
                }else
                {
                    Console.WriteLine("Please Enter a correct Input from the options!!\n");
                }
            }
            
        }

        static string Startopr(char type)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter First Number: ");
                    float num1 = float.Parse(Console.ReadLine());
                    Console.Write("Enter Second Number: ");
                    float num2 = float.Parse(Console.ReadLine());
                    if(type=='+')
                    {
                        float result = num1 + num2;
                        string output = num1 + " + " + num2 + " = " + result + "\n";
                        return output;
                    } else if (type == '-')
                    {
                        float result = num1 - num2;
                        string output = num1 + " - " + num2 + " = " + result + "\n";
                        return output;
                    } else if (type=='*')
                    {
                        float result = num1 * num2;
                        string output = num1 + " * " + num2 + " = " + result + "\n";
                        return output;
                    }
                    else
                    {
                        float result = num1 / num2;
                        string output = num1 + " / " + num2 + " = " + result + "\n";
                        return output;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("\nWrong Input: Please Enter a Number\n");
                }
            }
        }
    }
}