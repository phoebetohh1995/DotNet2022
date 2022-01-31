using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.q1();
            program.q2();
            Console.ReadKey();
        }

        public void q1()
        {
            Console.WriteLine("Please enter your 16 digit card number:");
            string cardNum = Console.ReadLine();

            while (cardNum.Length != 16)
            {
                Console.WriteLine("Invalid number. Please enter your 16 digit card number again:");
                cardNum = Console.ReadLine();

            }
            string reverseCardNum = "";
            for (int i = cardNum.Length - 1; i >= 0; i--)
            {

                reverseCardNum += cardNum[i];
            }
            int sum = 0;
            for (int i = 0; i < reverseCardNum.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    string evenNum = (Convert.ToInt32(reverseCardNum[i].ToString()) * 2).ToString();
                    for (int j = 0; j < evenNum.Length; j++)
                    {

                        sum += Convert.ToInt32(evenNum[j].ToString());
                    }
                }
                else
                {

                    sum += Convert.ToInt32(reverseCardNum[i].ToString());
                }
            }

            if (sum % 10 == 0)
            {
                Console.WriteLine(sum);
                Console.WriteLine("Card Number is valid");
            }
            else
            {
                Console.WriteLine(sum);
                Console.WriteLine("Card Number is invalid");
            }

        }

        public void q2()
        {
            Console.WriteLine("Please enter 11 numbers seperated by commas: (eg 1,2,3)");
            var input = Console.ReadLine().Split(',');

            while (input.Length != 11)
            {
                Console.WriteLine("Invalid input. Please enter again:");
                input = Console.ReadLine().Split(',');
            }
            string nonRepeatedNum = "";
            bool status = false;
            for (int i = 0; i < input.Length; i++)
            {
                status = false;
                for (int j = 0; j < input.Length; j++)
                {
                    if (i != j && input[i] == input[j])
                    {
                        status = true;
                    }
                }
                if (status == false)
                {
                    nonRepeatedNum = input[i];
                    break;
                }
            }
            if (!status)
            {
                Console.WriteLine("The non-repeating number is " + nonRepeatedNum);
            }
            else
                Console.WriteLine("There are no repeating values");
        }

        
        

    }
}