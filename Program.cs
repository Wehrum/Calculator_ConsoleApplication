using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 0;
            selection(number);
        }



        static void selection(double number)

        {
            Console.Clear();
            Console.WriteLine("Welcome to test Connor's Calculator");
            Console.WriteLine("");
            Console.WriteLine("Enter 1 to add");
            Console.WriteLine("Enter 2 to subtract");
            Console.WriteLine("Enter 3 to multiply");
            Console.WriteLine("Enter 4 to divide");

            try
            {
                number = byte.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {

                Console.WriteLine("There was an error: {0}", e.Message);
                System.Threading.Thread.Sleep(2000);
                selection(number);
            }
            
            try
            {
                switch (number)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("What is the first number you would like to add?");
                        Console.WriteLine("------------------------------------------------");
                        double add = double.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("And what is the second?");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("{0} + ?", add);
                        double add2 = double.Parse(Console.ReadLine());
                        double addresult = add + add2;
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("{0} + {1} = {2}", add, add2, addresult);
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to input another value, press any other key to return to selection");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            goto case 1;
                        }
                        else
                        {
                            selection(number);
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("What is the first number you would like to subtract?");
                        Console.WriteLine("------------------------------------------------");
                        double subtract = double.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("And what is the second?");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("{0} - ?", subtract);
                        double subtract2 = double.Parse(Console.ReadLine());
                        double subresult = subtract - subtract2;
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("{0} - {1} = {2}", subtract, subtract2, subresult);
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to input another value, press any other key to return to selection");
                        ConsoleKeyInfo keyInfo1 = Console.ReadKey(true);
                        if (keyInfo1.Key == ConsoleKey.Enter)
                        {
                            goto case 2;
                        }
                        else
                        {
                            selection(number);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("What is the first number you would like to multiply?");
                        Console.WriteLine("------------------------------------------------");
                        double multiply = double.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("And what is the second?");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("{0} * ?", multiply);
                        double multiply2 = double.Parse(Console.ReadLine());
                        double multiplyresult = multiply * multiply2;
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("{0} * {1} = {2}", multiply, multiply2, multiplyresult);
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to input another value, press any other key to return to selection");
                        ConsoleKeyInfo keyInfo2 = Console.ReadKey(true);
                        if (keyInfo2.Key == ConsoleKey.Enter)
                        {
                            goto case 3;
                        }
                        else
                        {
                            selection(number);
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("What is the first number you would like to divide?");
                        Console.WriteLine("------------------------------------------------");
                        double divide = double.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("And what is the second?");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("{0} / ?", divide);
                        double divide2 = double.Parse(Console.ReadLine());
                        if (divide2 == 0)
                        {
                        Console.WriteLine("Try not to divide by zero genius..");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        goto case 4;
                            
                            }
                        double divideresult = divide / divide2;
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("{0} / {1} = {2}", divide, divide2, divideresult);
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to input another value, press any other key to return to selection");
                        ConsoleKeyInfo keyInfo3 = Console.ReadKey(true);
                        if (keyInfo3.Key == ConsoleKey.Enter)
                        {
                            goto case 4;
                        }
                        else
                        {
                            selection(number);
                        }
                        break;
                    default:
                        Console.WriteLine("Did you not pick a number 1-4? It's not rocket science..");
                        System.Threading.Thread.Sleep(2500);
                        selection(number);
                        break;



                }
            }
            catch (Exception e)
            {

                Console.WriteLine("There was an error: {0}", e.Message);
                System.Threading.Thread.Sleep(2000);
                selection(number);
            }



        }

    }
}
