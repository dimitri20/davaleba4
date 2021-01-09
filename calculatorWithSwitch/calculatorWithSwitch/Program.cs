using System;

namespace calculatorWithSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kalkulatori: \n\n");

            while (true)
            {
                Console.Write("sheiyvanet pirveli ricxvi:   ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());

                Console.Write("sheiyvanet operacia: ");
                string operation = Console.ReadLine();

                Console.Write("sheiyvanet meore ricxvi:  ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                double final = 0;
                bool canDisplay = true;

                switch (operation)
                {
                    case "+":
                        final = firstNumber + secondNumber;
                        break;
                    case "-":
                        final = firstNumber - secondNumber;
                        break;
                    case "*":
                        final = firstNumber * secondNumber;
                        break;
                    case "/":
                        if(secondNumber != 0)
                        {
                            final = firstNumber / secondNumber;
                        } else
                        {
                            canDisplay = false;
                            Console.WriteLine("nulze gayofa ar sheidzleba ");
                            Console.WriteLine("scadet tavidan \n");
                        }
                        
                        break;
                    default:
                        Console.WriteLine("tqven sheiyvanet araswori operacia");
                        Console.WriteLine("scadet tavidan \n");
                        break;
                }

                if (canDisplay)
                {
                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {final}");
                }
                
            }
        }
    }
}
