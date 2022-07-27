using System;

namespace ChapterSix
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.*/
            Console.WriteLine(" Question 1");
            Console.Write("Enter N : ");
            int n = int.Parse(Console.ReadLine());
            for(int q = 0; q < n;)
            {
                q++;
                Console.Write($"{q},");
            }
            Console.WriteLine();

          /*2. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.*/
            Console.WriteLine(" Question 2 ");
            Console.Write("Enter N : ");
            int nNumbers = int.Parse(Console.ReadLine());
            int num = 1;
            for(int j = num; j <= nNumbers; j++)
            {
                if(j % (3 * 7) != 0)
                {
                    Console.Write($"{j},");
                }
            }
             Console.WriteLine();

             /*3. Write a program that reads from the console a series of integers and prints the smallest and largest of them.*/
              int smallest = 0;
              int largest = 0;
              Console.Write("Enter The Numbers Of Integers To Be Inputed : ");
              int length = int.Parse(Console.ReadLine());            
              for (int m = 0; m < length; m++)
              {
                 Console.Write("Enter Number : ");
                 int input = int.Parse(Console.ReadLine());
                 if(m == 0) 
                 {
                    smallest = largest = input;
                 }
                 else
                 {
                    if(smallest > input) 
                    {
                        smallest = input;
                    }
                    if (largest < input) 
                    {
                       largest = input;
                    }
                 }                
            }
            Console.WriteLine($"The smallest integer is {smallest} and the largest is {largest}");
             
             /*4. Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards)*/
             Console.WriteLine(" Question 4 ");
             for (int suits = 0; suits < 4; suits++)
            {
                if(suits != 0)
                { 
                Console.WriteLine();
                }
                for (int cards = 0; cards < 13; cards++)
                {
                    switch (suits)
                    {
                        case 0: 
                        Console.Write("Hearts "); 
                        break;
                        case 1:
                         Console.Write("Diamonds ");
                        break;
                        case 2: 
                        Console.Write("Spades "); 
                        break;
                        case 3: 
                        Console.Write("Clubs ");
                        break;
                    }
                    switch(cards)
                    {
                        case 0: 
                        Console.WriteLine("2"); 
                        break;
                        case 1: 
                        Console.WriteLine("3"); 
                        break;
                        case 2: 
                        Console.WriteLine("4"); 
                        break;
                        case 3: 
                        Console.WriteLine("5");
                        break;
                        case 4:
                        Console.WriteLine("6"); 
                        break;
                        case 5: 
                        Console.WriteLine("7"); 
                        break;
                        case 6: 
                        Console.WriteLine("8"); 
                        break;
                        case 7: 
                        Console.WriteLine("9"); 
                        break;
                        case 8: 
                        Console.WriteLine("10"); 
                        break;
                        case 9: 
                        Console.WriteLine("J"); 
                        break;
                        case 10: 
                        Console.WriteLine("Q"); 
                        break;
                        case 11: 
                        Console.WriteLine("K"); 
                        break;
                        case 12: 
                        Console.WriteLine("A"); 
                        break;
                    }
                }
            }
              Console.WriteLine();

              /*5. Write a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …*/
             Console.WriteLine(" Question 5 ");
             int firstNo = 0;
             int secondNo = 1;
             Console.Write("Enter Number : ");
             int fibonacciNo = int.Parse(Console.ReadLine());
             Console.Write($" {firstNo}, {secondNo},");
             int sum = 1;
             for(int p = 2; p < fibonacciNo; p++)
             {
                
                int thirdNo = firstNo + secondNo;
                Console.Write($"{thirdNo},");
                firstNo = secondNo;
                secondNo = thirdNo;
                sum += thirdNo;
             }	
             Console.WriteLine($"The sum is : {sum}");
             Console.WriteLine();

             /*6. Write a program that calculates N!/K! for given N and K (1<K<N).*/
             Console.WriteLine(" Question 6 ");
             Console.Write("Enter N : ");
             int nNumber = int.Parse( Console.ReadLine());
             Console.Write("Enter K : ");
             int k = int.Parse(Console.ReadLine());
             decimal nNumberFactorial = 1;
             decimal kFactorial = 1;
             do
             {
                nNumberFactorial *= nNumber;
                nNumber--;
             } while (nNumber > 0);
             do
             {
                kFactorial *= k;
                k--;
             } while(k > 0);
             Console.WriteLine($"N!/K! is {nNumberFactorial / kFactorial}");
             Console.WriteLine();

             /*7. Write a program that calculates N!*K!/(N-K)! for given N and K 
             (1<K<N).*/
             Console.WriteLine(" Question 7 ");
             Console.Write("Enter N : ");
             int numberN = int.Parse( Console.ReadLine());
             Console.Write("Enter K : ");
             int numberK = int.Parse(Console.ReadLine());
             decimal factorialN = 1;
             decimal factorialK = 1;
             int subtractionOfNAndK = numberN - numberK;
             decimal subtractionFactorial = 1;
             do
             {
                 factorialN *= numberN;
                 numberN--;
             } while (numberN > 0);
             do
             {
               factorialK *= numberK;
               numberK--;
             } while(numberK > 0);
             do
             {
                 subtractionFactorial *= subtractionOfNAndK;
                 subtractionOfNAndK--;
             } while(subtractionOfNAndK > 0);
             Console.WriteLine($"N!*K!/(N-K)! is {factorialN * factorialK / (subtractionFactorial)}");
             Console.WriteLine();

             /*Write a program that calculates the nth Catalan number by given n.*/
             Console.WriteLine(" Question 8 : ");
             Console.Write("Enter N : ");
             int nNo = int.Parse(Console.ReadLine());
             int nNoTimesTwo = nNo * 2;
             int nNoPlusOne = nNo + 1;
             int nNoFactorial = 1;
             int nNoPlusOneFactorial = 1;
              int nNoTimesTwoFactorial = 1;
             do
             {
                nNoFactorial *= nNo;
                nNo--;
             } while(nNo > 0);
             do
             {
                nNoTimesTwoFactorial *= nNoTimesTwo;
                nNoTimesTwo--;
             } while(nNoTimesTwo > 0);
             do
             {
                nNoPlusOneFactorial *= nNoPlusOne;
                nNoPlusOne--;
             } while(nNoPlusOne > 0);
             Console.WriteLine($"(2n)!/(n+1)!n! is equal to : { (nNoTimesTwoFactorial) / (nNoPlusOneFactorial) * (nNoTimesTwoFactorial)}");
             Console.WriteLine();

             /*9. Write a program that for a given integers n and x, calculates the sum:*/ 
             Console.WriteLine(" Question 9 ");
             
             /*10. Write a program that reads from the console a positive integer number N (N < 20) and prints a matrix of numbers as on the figures below:*/
             Console.WriteLine(" Question 10 ");
             Console.Write("Enter Number : ");
             int no = int.Parse(Console.ReadLine());
             for (int row = 1; row <= no; row++)
             {
              for (int col = 1; col <= row; col++)
             {
              Console.Write($"{col} ");
             }
             Console.WriteLine();
             }

             /*11. Write a program that calculates with how many zeroes the factorial of a given number ends. Examples:*/
             Console.WriteLine(" Question 11 ");
             Console.Write("Enter N: ");
             decimal noN = Int32.Parse(Console.ReadLine());
             int zeroes = 0;
             for (int s = (int)(noN - 1); s > 0; s--)
             {
                noN *= s; 
             }
             
             Console.Write($"N! is {nNo} and it ends ");
    
             do
             {
              nNo /= 10;
              zeroes++;
             } while (nNo % 10 == 0);
    
             Console.Write($"with {zeroes} zeroes.");
             Console.WriteLine();

             /*12. Write a program that converts a given number from decimal to binary notation (numeral system).*/
             Console.WriteLine(" Question 12 ");
             Console.Write("Enter A Decimal Number : ");
             string decimalNumber = Convert.ToString(Console.ReadLine());
             int binaryValue = Convert.ToInt32(decimalNumber, 10);
             string convertBinary = Convert.ToString(binaryValue, 2);
             Console.WriteLine($"It's equivalent Binary Value is : {convertBinary}");
             Console.WriteLine();
             
             /*13. Write a program that converts a given number from binary to decimal notation.*/
             Console.WriteLine(" Question 13 ");
             Console.Write("Enter A Binary Number : ");
             string binaryNumber = Convert.ToString(Console.ReadLine());
             int decimalValue = Convert.ToInt32(binaryNumber, 2);
             Console.WriteLine($"Its Decimal Number is equivalent to : {decimalValue}");
             Console.WriteLine();

             /*14. Write a program that converts a given number from decimal to hexadecimal notation.*/
             Console.WriteLine(" Question  16 ");
             int i;
             Console.Write("Enter A Decimal Number : ");
             int decimalNo = int.Parse(Console.ReadLine());
             char [] hexadecimalNumber = new char[100];
             for(i = 0; i < decimalNo; i++)
             {
                int remainder = decimalNo % 16;
                
                if(decimalNo < 10)
                {
                    hexadecimalNumber[i] = (char)(remainder + 48);
                }
                else
                {
                    hexadecimalNumber[i] = (char)(remainder + 55);
                }
                decimalNo /= 16;
             }
            
             for(int r = hexadecimalNumber.Length - 1; r >= 0; r--)
             {
                Console.Write($"It's equivalent hexadecimal number is : {hexadecimalNumber[r]}");
             }
             Console.WriteLine();

             /*15. Write a program that converts a given number from hexadecimal to decimal notation.*/
             Console.Write("Enter a Hexadecimal Number : ");
             string hexdecNo = Convert.ToString(Console.ReadLine());
             int deciValue = Convert.ToInt32(hexdecNo, 16);
             Console.Write($"It's equivalent DecimalValue is : {deciValue}");
             Console.WriteLine();

             /*16. Write a program that by a given integer N prints the numbers from 1 to N in random order.*/
             Console.WriteLine(" Question 16 ");
             Random random = new Random();
             Console.Write("Enter N : ");
             int nNum = int.Parse(Console.ReadLine());
             int numN = random.Next(0, nNum);
             int counter = 0;
             for(; counter <= n;)
             {
                counter++;
                Console.Write($"{numN}");
             }
             Console.WriteLine();

             /*17. Write a program that given two numbers finds their greatest common divisor (GCD) and their least common multiple (LCM). You may use the formula LCM(a, b) = |a*b| / GCD(a, b)*/
             Console.WriteLine(" Question 17 ");
             Console.Write("Enter First Number : ");
             int no1 = int.Parse(Console.ReadLine());
             Console.Write("Enter Second Number : ");
             int no2 = int.Parse(Console.ReadLine());
             










        }
    }
}
