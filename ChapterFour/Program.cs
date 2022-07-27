using System;

namespace ChapterFour
{
    class Program
    {
        static void Main(string[] args)
        {
          /*1. Write a program that reads from the console three numbers of type intand prints their sum.*/
          Console.WriteLine(" Question 1 ");
          Console.Write("Enter First Number : ");
          int firstNo = int.Parse(Console.ReadLine());
          Console.Write("Enter Second Number : ");
          int secondNo = int.Parse(Console.ReadLine());
          Console.Write("Enter Third Number : ");
          int thirdNo = int.Parse(Console.ReadLine());
          int sum = firstNo + secondNo + thirdNo;
          Console.WriteLine($"The sum of the three numbers is : {sum}");
          Console.WriteLine();

          /*2. Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.*/
          Console.WriteLine(" Question 2 ");
          Console.Write("Enter the radius of the circle : ");
          float radius = float.Parse(Console.ReadLine());
          double areaOfCircle = (double) Math.PI * radius * radius;
          double convertTo2Dp = Math.Round(areaOfCircle, 2);
          double perimeterOfCircle = (double) 2 * Math.PI * radius;
          double convertToDp2 = Math.Round(perimeterOfCircle, 2);
          Console.Write($"The area of the circle is {convertTo2Dp} and the perimeter is {convertToDp2}");
          Console.WriteLine();

          /*3. A given company has name, address, phone number, fax number, website and manager. The manager has name, surname and phone number.Write a program that reads information about the company and its 
          manager and then prints it on the console.*/
          Console.WriteLine(" Question 3 ");
          Console.Write("Enter Company Name : ");
          string companyName = Console.ReadLine();
          Console.Write("Enter address : ");
          string address = Console.ReadLine();
          Console.Write("Enter Phone Number : ");
          long phoneNumber = long.Parse(Console.ReadLine());
          Console.Write("Enter fax Number : ");
          int faxNumber = int.Parse(Console.ReadLine());
          Console.Write("Enter website : ");
          string website = Console.ReadLine();
          Console.Write("Enter Manager's First Name : ");
          string managerFirstName = Console.ReadLine();
          Console.Write("Enter Manager's Surname : ");
          string managerSurname = Console.ReadLine();
          Console.Write("Enter Manager's Phone Number : ");
          long managerPhoneNumber = long.Parse(Console.ReadLine()); 
          Console.WriteLine($"{companyName} is situated in {address}.For enquiries, call us on {phoneNumber} or send a letter to us through {faxNumber}. For more information about our company, go on {website}. Holding the managerial position is {managerFirstName} {managerSurname} and can be reached through {managerPhoneNumber}");
          Console.WriteLine();

          /*4. Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.*/
         Console.WriteLine(" Question 4 ");
         Console.Write("Enter a Number : ");
         int hexNum = int.Parse(Console.ReadLine());
         Console.Write("Enter a fractional number : ");
         double fractNo = double.Parse(Console.ReadLine());
         Console.Write("Enter a negative fractional number : ");
         double negativeFractNo = double.Parse(Console.ReadLine());
         Console.WriteLine("|{0, -10:x}|", hexNum);
         Console.WriteLine("|{0, -10:f4}|", fractNo);
         Console.WriteLine("|{0, -10:f4}|", negativeFractNo);
         Console.WriteLine();

         /*5. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.*/
         Console.WriteLine(" Question 5 ");
         Console.Write("Enter First Number : ");
         int num1 = int.Parse(Console.ReadLine());
         Console.Write("Enter Second Number : ");
         int num2 = int.Parse(Console.ReadLine());
         for(int i = num1; i <= num2; i++)
         {
            if(i % 5 == 0)
            {
                Console.Write($"{i},");
            }
         }
         Console.WriteLine();

         /*6. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.*/
         Console.WriteLine(" Question 6 ");
         Console.Write("Enter First Number : ");
         float firstNumber = long.Parse(Console.ReadLine());
         Console.Write("Enter Second Number : ");
         float secondNumber = long.Parse(Console.ReadLine());
         float greaterNumber = Math.Max(firstNumber, secondNumber);
         Console.WriteLine($"The greater number is {greaterNumber}");
         Console.WriteLine();

         /*7. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.*/
         Console.WriteLine(" Question 7 ");
         int sumUp = 0;
         int counter = 0;
         while ( counter <= 4)
         {
           Console.Write("Enter A Number : ");
           string input = Console.ReadLine();
           int x;
           bool isInteger = int.TryParse(input , out x);
          if (!isInteger)
           {
             counter--;
             Console.Write("Invalid input! ");
           }
          sumUp += x;
          counter++;
         }
         Console.WriteLine($"The sum of the numbers is :{sumUp}");
         Console.WriteLine();

         /*8. Write a program that reads five numbers from the console and prints the greatest of them.*/
         Console.WriteLine(" Question 8 ");
         Console.Write("Number 1 : ");
         int number1 = int.Parse(Console.ReadLine());
         Console.Write("Number 2 : ");
         int number2 = int.Parse(Console.ReadLine());
         Console.Write("Number 3 : ");
         int number3 = int.Parse(Console.ReadLine());
         Console.Write("Number 4 :");
         int number4 = int.Parse(Console.ReadLine());
         Console.Write("Number 5 : ");
         int number5 = int.Parse(Console.ReadLine());
         if ((number1 >= number2) && (number1 >= number3) && (number1 >= number4) && (number1 >= number5))
         {
            Console.WriteLine($"The greatest number is: {number1}");
            
         }
         if ((number2 >= number1) && (number2 >= number3) && (number2 >= number4) && (number2 >= number5))
         {
            Console.WriteLine($"The greatest number is: {number2}");
            
         }
         if ((number3 >= number1) && (number3 >= number2) && (number3 >= number4) && (number3 >= number5))
         {
            Console.WriteLine($"The greatest number is : {number3}");
            
         }
         if ((number4 >= number1) && (number4 >= number2) && (number4 >= number3) && (number4 >= number5))
         {
            Console.WriteLine($"The greatest number is : {number4}");
            
         }
         if ((number5 >= number1) && (number5 >= number2) && (number5 >= number3) && (number5 >= number4))
         {
            Console.WriteLine($"The greatest number is : {number5}");
            
         }
         Console.WriteLine();

         /*9. Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.*/
         Console.WriteLine(" Question 9 ");
         Console.Write("Enter An Integer : ");
         int integer = int.Parse(Console.ReadLine());
         int count = 0;
         int summation = 0;
         Console.Write("Enter Number Of Numbers To Be Inputed: ");
         int numberOfNos = int.Parse(Console.ReadLine());
         while(count < numberOfNos)
         {
           Console.Write("Enter An Integer : ");
           int otherIntegers = int.Parse(Console.ReadLine());
           summation += otherIntegers;
           count++;
         }
         summation += integer;
         Console.WriteLine($"The sum all together is = {summation}");
         Console.WriteLine();

         /*10. Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.*/
         Console.WriteLine(" Question 10 ");
         Console.Write("Enter an integer : ");
         int n = int.Parse(Console.ReadLine());
         for(int i = 1; i <= n; i++)
         {
           Console.WriteLine(i);
         }
          Console.WriteLine();

          /*11. Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …*/
          int firstElement = 0;
          int secondElement = 1;
          int thirdElement;
          Console.Write($"{firstElement},");
          Console.Write($"{secondElement},");
          for(int i = 2; i <= 100; i++)
         {
            thirdElement = firstElement + secondElement;
            Console.Write($"{thirdElement},");
            firstElement = secondElement;
            secondElement = thirdElement;
         }
         Console.WriteLine();

         /*12. Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …*/
         Console.WriteLine(" Question 12 ");
         Console.Write("Enter Length : ");
         double length = double.Parse(Console.ReadLine());
         double summingUp = 1.0d;
         for(int i = 2; i <= length; i++)
         {
             if(i % 2 == 0)
             {
                 summingUp += (1.0 / i);
             }
             else if(i % 2 != 0)
             {
                 summingUp += ( 1.0 / -i);
             }
         }
         double roundUpTo3DecimalPlaces = (double) Math.Round(summingUp, 3);
         Console.WriteLine(roundUpTo3DecimalPlaces);
         Console.WriteLine();






       





        }
    }
}
