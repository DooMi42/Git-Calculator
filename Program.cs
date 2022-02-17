using System;

namespace GitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Paina numeroa jonka lasku vastaa tarvettasi!");
            Console.WriteLine("1 = Pluslasku");
            Console.WriteLine("2 = Minuslasku");
            Console.WriteLine("3 = Kertolasku");
            Console.WriteLine("4 = Jakolasku \n");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna ensimmäinen arvo");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna toinen arvo");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("ERROR 1662");
                    break;
            }
            Console.WriteLine("Vastauksesi on {0}", result);
            Console.ReadKey();
        }
        //Addition  
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Substraction  
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }
        //Multiplication  
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }
        //Division  
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 / input_2;
            return result;
        }
    }
}
