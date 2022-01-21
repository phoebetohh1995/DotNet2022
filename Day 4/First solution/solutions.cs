using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_solutions
{
    internal class solutions
    {
        public void qn1()
        {
            //TakeNumbers();
            int num;
            Console.WriteLine("Please enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: ");
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
            }


        }
        public void qn2()
        {
            //TakeNumbers();
            int num;
            Console.WriteLine("Please enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: ");
            if (num % 2 == 0)
            {
                Console.WriteLine(num + "is an Even number ");
            }
            else
                Console.WriteLine(num + "is an Odd number");
        }

        public void qn3()
        {
            //TakeNumbers();
            int num1, num2;

            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: ");

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is greater than " + num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2 + " is greater than " + num1);
            }
            else
                Console.WriteLine("The numbers are equal");
        }

        public void qn4()
        {
            //TakeNumbers();
            int num1, num2, num3, greatest;

            Console.WriteLine("Please enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the third number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            greatest = num1;

            if (greatest < num2 && num2 > num3)
            {
                greatest = num2;
            }
            else if (greatest < num3 && num3 > num2)
                greatest = num3;

            Console.WriteLine("Result: ");
            Console.WriteLine("The greatest number is " + greatest);


        }

        public void qn5()
        {
            int num1; int num2;
            Console.WriteLine("Please enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: ");
            for (int i = num1 + 1; i < num2; i++)
            {
                Console.WriteLine(i);
            }

            
        }

        public void qn6()
        {
            int num1;
            bool isPrime = true;

            Console.WriteLine("Please enter a number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 <= 1)
            {
                isPrime = false;
            }

            for (int i = 2; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine("Result: ");

            if (isPrime)
                Console.WriteLine(num1 + " is a prime number");
            else
                Console.WriteLine(num1 + " is not a prime number");

        }

        public void qn7()
        {
            int num1, num2, count = 0;

            Console.WriteLine("Please enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: ");
            Console.WriteLine("Prime numbers between " + num1 + " and " + num2 + " are : ");

            for (int i = num1; i < num2; i++)
            {
                count = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
        public void qn8()
        {
            int num, sum = 0;
            Console.WriteLine("Enter negative number to stop");

            do
            {
                Console.Write("Please enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 7 == 0)
                    sum += num;


            } while (num >= 0);

            Console.WriteLine("Result : ");
            Console.WriteLine("Total sum of numbers which are divisible by 7 is " + sum);

        }





        public void qn9()
        {
            int n, sum = 0, m;
            Console.WriteLine("Please Enter a number with 4 digits: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.WriteLine("Result: "); 
            Console.WriteLine("Total of all digits are :" + sum);
        }

        public void qn10()
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Please enter a number with 4 digits: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            Console.WriteLine("Result: ");
            if (temp == sum)
                Console.WriteLine( temp + " is Palindrome.");
            else
                Console.WriteLine(temp + " is not Palindrome");
        }
        







    }
}
