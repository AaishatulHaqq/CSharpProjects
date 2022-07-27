using System;

namespace ChapterThree
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*1. Write an expression that checks whether an integer is odd or even.*/
            Console.WriteLine("Question 1 ");
            Console.Write("Enter An Integer : ");
            int integer = int.Parse(Console.ReadLine());
            if(integer % 2 == 0)
            {
                Console.WriteLine("This integer is even!");
            }
            else
            {
                Console.WriteLine("This integer is odd!");
            }
            Console.WriteLine();

            /*2. Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.*/
            Console.WriteLine("Question 2 ");
            Console.Write("Enter A Number : ");
            int number = int.Parse(Console.ReadLine());
            if(number % (5*7) == 0)
            {
                Console.WriteLine("This number is divisible by 5 and  7");
            }
            else
            {
                Console.WriteLine("This number is not divisible by 5 and 7");
            }
            Console.WriteLine();

            /*3. Write an expression that looks for a given integer if its third digit (right to left) is 7.*/
            Console.WriteLine("Question 3 ");
            Console.Write("Enter Number : ");
            int num = int.Parse(Console.ReadLine());
            int division = num / 100;
            int thirdDigit = division % 10;
            if(thirdDigit == 7)
            {
                Console.WriteLine($"The third digit of {num} is 7");
            }
           else
           {
               Console.WriteLine($"The third digit of {num} is not 7");
           }
            Console.WriteLine();

            /*4. Write an expression that checks whether the third bit in a given integer is 1 or 0.*/
           Console.WriteLine("Question 4 ");
           Console.Write("Enter an integer : ");
           int numb = int.Parse(Console.ReadLine());
           bool thirdBit = (numb & 8) != 0;
           Console.WriteLine(thirdBit);
           Console.WriteLine();

           /*5. Write an expression that calculates the area of a trapezoid by given sides a, b and height h.*/
           Console.WriteLine("Question 5 ");
           Console.Write("Enter a : ");
           int a = int.Parse(Console.ReadLine());
           Console.Write("Enter b : ");
           int b = int.Parse(Console.ReadLine());
           Console.Write("Enter h : ");
           int h = int.Parse(Console.ReadLine());
           int areaOfTrapezoid = (a + b) * h/2;
           Console.Write($"The area of the trapezoid is : {areaOfTrapezoid}");
           Console.WriteLine();

           /*6. Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.*/
            Console.WriteLine("Question 6 ");
            Console.Write("Enter length : ");
            float length = float.Parse(Console.ReadLine());
            Console.Write("Enter breadth : ");
            float breadth = float.Parse(Console.ReadLine());
            float perimeter = 2 * (length + breadth);
            float area = length * breadth;
            Console.WriteLine($"The perimeter of the rectangle is {perimeter} and its area is {area}");
            Console.WriteLine();

           /*7. The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/
           Console.WriteLine("Question 7 ");
           Console.Write("Enter the weight of a man on earth : ");
           double earthWeight = double.Parse(Console.ReadLine());
           double moonWeight = 17d/100 * earthWeight;
           Console.Write($"The weight of the man on the moon is : {moonWeight}");
           Console.WriteLine();

           /*8. Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of the circle and 5 is the radius.*/
          Console.WriteLine("Question 8 ");
          Console.Write("Enter x : ");
          int x = int.Parse(Console.ReadLine());
          Console.Write("Enter y : ");
          int y = int.Parse(Console.ReadLine());
          double result = (x * x) + (y * y);
          double sqrtResult = Math.Sqrt(result);
          if(sqrtResult <= 5)
          {
             Console.WriteLine("It is within the circle");
          }
          else
          {
             Console.WriteLine("It is not within the circle");
          }
          Console.WriteLine();

          /*9. Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.*/
          Console.WriteLine(" Question 9 ");
          Console.WriteLine("Enter Value For x1 : ");
          int x1 = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter Value For y1 : ");
          int y1 = int.Parse(Console.ReadLine());
          bool insideOfCircle = (x1 * x1) + (y1 * y1) <= 25;
          bool outOfRectangle = (x < -1 && x > 5) && (y < 1 && y > 5);
          if(insideOfCircle && outOfRectangle) 
          {
              Console.WriteLine("It is within the circle and out of the rectangle");
          }
          else
          {
              Console.WriteLine("It is not within the circle and in the rectangle");
          }

          Console.WriteLine();
          
          /*10. Write a program that takes as input a four-digit number in format abcd(e.g. 2011) and performs the following actions:
            - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            - Prints on the console the number in reversed order: dcba (in our example 1102).
            - Puts the last digit in the first position: dabc (in our example 1201).
            - Exchanges the second and the third digits: acbd (in our example 2101).*/
            Console.WriteLine("Question 10");
            Console.Write("Enter a four digit number: ");
            string figure = Console.ReadLine();
            int first = Convert.ToInt32(figure[0].ToString());
            int second = Convert.ToInt32(figure[1].ToString());
            int third = Convert.ToInt32(figure[2].ToString());
            int fourth = Convert.ToInt32(figure[3].ToString());

            Console.WriteLine($"Calculates the sum of the digits: {first + second + third + fourth}");
            Console.WriteLine($"Prints on the console the number in reversed order: {fourth}{third}{second}{first}");
            Console.WriteLine($"Puts the last digit in the first position: {fourth}{first}{second}{third}");
            Console.WriteLine($"Exchanges the second and the third digit: {first}{third}{second}{fourth}");
            Console.WriteLine();

            /*11. We are given a number n and a position p. Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.*/
            Console.WriteLine(" Question 11 ");
            Console.Write("Enter n : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter p : ");
            int p = int.Parse(Console.ReadLine());
            int counter = 1;
            int shiftLeft = counter << p;
            Console.WriteLine((n & shiftLeft) != 0 ? "Third bit is 1" : "Third bit is 0"); 
            Console.WriteLine();

            /*12. Write a Boolean expression that checks if the bit on position p in the integer v has the value  1. Example v=5, p=1 -> false.*/
            Console.WriteLine(" Question 12 ");
            Console.Write("Enter v : ");
            int v = int.Parse(Console.ReadLine());
            int positionP = int.Parse(Console.ReadLine());
            int shiftToTheLeft = 1 << p;
            bool isOne = (v & shiftToTheLeft) != 0 ? true : false;
            Console.WriteLine($"The bit at position {p} of number {v} is 1? {isOne}");
            Console.WriteLine();

            /*13. We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, so the bit on the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. Another example: n=35, p=2, v=1 -> n=39.*/
            Console.WriteLine(" Question 13 ");
            Console.Write("Enter nNumber : ");
             int nNumber = int.Parse(Console.ReadLine());
            int valueV = 0;
            int pPosition = int.Parse(Console.ReadLine());
            nNumber = (valueV == 0) ? nNumber = nNumber & (~(1 << pPosition)) : nNumber = nNumber | (1 << pPosition);
            Console.WriteLine(nNumber);
            Console.WriteLine();

            /*14. Write a program that checks if a given number n (1 < n < 100) is a prime number (i.e. it is divisible without remainder only to itself and 1).*/
            Console.WriteLine(" Question 14 ");
            Console.Write("Enter A Number Between 1 and 100 : ");
            int nNum = int.Parse(Console.ReadLine());
            int squareRootOfN = (int) Math.Sqrt(n);
            int divisor = 2;
            bool prime = true;
            while (prime && (divisor <= squareRootOfN))
            {
                if(nNum % divisor != 0)
                {
                    prime = true;
                    Console.WriteLine($"{nNum} is a prime number");
                }
                else
                {
                   prime = false;
                   Console.WriteLine($"{nNum} is not a prime number");
                }
                divisor++;
            }
             Console.WriteLine();
            /*15.  Write a program that exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24 25 and 26 of a given 32-bit unsigned integer.*/
            Console.WriteLine(" Question 15 ");
            Console.Write("Enter Number : ");
            int vNumber = int.Parse(Console.ReadLine());
            int shift = 1 << 3;
            int thirDBit = (vNumber &shift ) != 0 ? 1 : 0;
            shift = 1 << 4;
            int fourthBit= (vNumber & shift) != 0 ? 1 : 0;
            shift = 1 << 5;
            int fifthBit = (vNumber & shift) != 0 ? 1 : 0;
            shift = 1 << 24;
            int twentyFourthBit = (vNumber & shift) != 0 ? 1 : 0;
            shift = 1 << 25;
            int twentyFifthBit = (vNumber & shift) != 0 ? 1 : 0;
            shift = 1 << 26;
            int twentySixthBit = (vNumber & shift) != 0 ? 1 : 0;

            vNumber = (thirDBit == 0) ? vNumber = vNumber & (~(1 << 24)) : vNumber = vNumber | (1 << 24);
            vNumber = (fourthBit == 0) ? vNumber = vNumber & (~(1 << 25)) : vNumber = vNumber | (1 << 25);
            vNumber = (fifthBit == 0) ? vNumber = vNumber & (~(1 << 26)) : vNumber = vNumber | (1 << 26);
            vNumber = (twentyFourthBit == 0) ? vNumber = vNumber & (~(1 << 3)) : vNumber = vNumber | (1 << 3);
            vNumber = (twentyFifthBit == 0) ? vNumber = vNumber & (~(1 << 4)) : vNumber = vNumber | (1 << 4);
            vNumber = (twentySixthBit == 0) ? vNumber = vNumber & (~(1 << 5)) : vNumber = vNumber | (1 << 5);
            Console.WriteLine(vNumber);
            Console.WriteLine();

           
            

            


       

       
       








        }
    }
}
