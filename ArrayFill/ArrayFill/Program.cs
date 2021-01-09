using System;

namespace ArrayFill
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            int count = 0;
            int countEven = 0;

            Console.WriteLine("sheiyvanet masivshi chasaweri ricxvi.");
            Console.WriteLine("shesachereblad sheiyvanet aso 'a'.");
            Console.WriteLine("ricxvebis maqsimaluri raodenobaa 15.\n\n\n");

            //masivis shevseba
            while (true)
            {
                count++;
                Console.Write("sheiyvanet mteli ricxvi:  ");
                string input = Console.ReadLine();
                if(input == "a" || count == 15)
                {
                    break;
                }
                arr[count] = Convert.ToInt32(input);
            }

            Console.Write("{");
            //luwebis datvla
            for(int i = 0; i < count; i++)
            {
                Console.Write($"{i}, ");
                if(arr[i] %2 == 0)
                {
                    countEven++;
                }
            }
            Console.Write("}\n");

            Console.WriteLine("\n\n\n");
            Console.WriteLine($"masivshi luwi ricxvebis raodenobaa: {countEven}");
        }
    }
}
