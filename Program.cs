using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO specify a method to run
            showDiamondPatternWithAsterisk();
            showPrimeNumbersWithinARange();
            showTrianglePatternWithNumbers();
            showNumbersInReverseOrder();
            checkWhetherNumbersArePalindrome();
            sumOfAllIntegersBetween100And200DivisibleBy9();
            convertBinaryNumberToDecimal();
            getHCFofTwoNumbers();
            displayAPattern();
            displayDPattern();
            Console.ReadLine();
        }

        //Program to display the pattern like a diamond with asterisk
        static void showDiamondPatternWithAsterisk() {
            int i, j, r;
            Console.Write("\n\nDisplay the pattern like diamond : ");
            Console.Write("\n\n-----------------------------------");
            Console.Write("\n\nInput number of rows : ");
            r = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }

        //Program to find the prime numbers within a range of numbers
        static void showPrimeNumbersWithinARange() {
            int number, i, ctr, stno, enno;
            Console.Write("\n\nFind the prime numbers within a range of numbers : ");
            Console.Write("\n\n---------------------------------------------------");
            Console.Write("\n\nInput starting number of range: ");
            stno = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nInput ending number of range : ");
            enno = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nThe prime numbers between {0} and {1} are : \n\n", stno, enno);
            for (number = stno; number <= enno; number++)
            {
                ctr = 0;

                for (i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && number != 1)
                    Console.Write("{0} ", number);
            }
            Console.Write("\n");
        }

        //Program to display the such a pattern for n number of rows using a number which will start with the number 1 and the first and a last number of each row will be 1
        static void showTrianglePatternWithNumbers() {
            int i, j, n;
            Console.Write("\n\nDisplay the pattern in which first and last number of each row will be 1 : ");
            Console.Write("\n\n------------------------------------------------------------------------");
            Console.Write("\n\nInput number of rows : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);
                for (j = i - 1; j >= 1; j--)
                    Console.Write("{0}", j);
                Console.Write("\n");
            }
        }

        //Program to display the number in reverse order
        static void showNumbersInReverseOrder() {
            int num, r, sum = 0, t;
            Console.Write("\n\nDisplay the number in reverse order : ");
            Console.Write("\n\n--------------------------------------");
            Console.Write("\n\nInput a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (t = num; t != 0; t = t / 10)
            {
                r = t % 10;
                sum = sum * 10 + r;
            }
            Console.Write("\n\nThe number in reverse order is : {0}", sum);
        }

        //Program to check whether a number is a palindrome or not
        static void checkWhetherNumbersArePalindrome() {
            int num, r, sum = 0, t;
            Console.Write("\n\nCheck whether a number is a palindrome or not : ");
            Console.Write("\n\n------------------------------------------------");
            Console.Write("\n\nInput a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (t = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum * 10 + r;
            }
            if (t == sum)
            {
                Console.Write("{0} is a palindrome number.\n", t);
            }
            else
            {
                Console.Write("{0} is not a palindrome number.\n", t);
            }
        }

        //Program to find the number and sum of all integer between 100 and 200 which are divisible by 9
        static void sumOfAllIntegersBetween100And200DivisibleBy9() {
            int i, sum = 0;
            Console.Write("\n\nFind the number and sum of all integer between 100 and 200, divisible by 9 : ");
            Console.Write("\n\n-----------------------------------------------------------------------------");
            Console.Write("\n\nNumbers between 100 and 200, divisible by 9 : \n");
            for (i = 101; i < 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write("{0}  ", i);
                    sum += i;
                }
            }
            Console.Write("\n\nThe sum : {0} \n", sum);
        }

        //Program to convert a binary number into a decimal number without using array, function and while loop
        static void convertBinaryNumberToDecimal() {
            int n1, n, p = 1;
            int dec = 0, i = 1, j, d;
            Console.Write("\n\nConvert a binary to decimal using for loop and without using array : ");
            Console.Write("\n\n---------------------------------------------------------------------");
            Console.Write("\n\nInput a binary number : ");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;
            for (j = n; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                {
                    p *= 1;
                }
                else
                {
                    p *= 2;
                }

                dec = dec + (d * p);
                i++;
            }
            Console.Write("\n\nThe Binary Number : {0}\nThe equivalent Decimal  Number : {1}", n1, dec);
        }

        //Program to find HCF (Highest Common Factor) of two numbers
        static void getHCFofTwoNumbers() {
            int i, n1, n2, j, hcf = 1;
            Console.Write("\n\nDetermine the HCF of two numbers : ");
            Console.Write("\n\n-----------------------------------");
            Console.Write("\n\nInput 1st number for HCF : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nInput 2nd number for HCF : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            j = (n1 < n2) ? n1 : n2;
            for (i = 1; i <= j; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    hcf = i;
                }
            }
            Console.Write("\n\nHCF of {0} and {1} is : {2}", n1, n2, hcf);
        }

        //Program to display alphabet pattern like 'A' with an asterisk
        static void displayAPattern() {
            int row, column;
            Console.Write("\n\nDisplay the pattern like 'A' with an asterisk : ");
            Console.Write("\n\n---------------------------------------------\n\n");
            for (row = 0; row <= 7; row++)
            {
                for (column = 0; column <= 7; column++)
                {
                    if (((column == 1 || column == 5) && 
                        row != 0) ||
                         ((row == 0 || row == 3) && 
                         (column > 1 && column < 5)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        //Program to display alphabet pattern like 'D' with a asterisk
        static void displayDPattern() {
            int row, column;
            Console.Write("\n\nDisplay the pattern like 'D' with an asterisk : ");
            Console.Write("\n\n---------------------------------------------\n\n");
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || 
                        ((row == 0 || row == 6) &&
                        (column > 1 && column < 5)) ||
                        (column == 5 && row != 0 && 
                        row != 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

    }
}
