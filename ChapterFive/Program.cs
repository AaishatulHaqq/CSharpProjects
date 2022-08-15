using System;

namespace ChapterFive
{
    class Program
    {
        static void Main(string[] args)
        {
          /*1. Write an if-statement that takes two integer variables and exchangestheir values if the first one is greater than the second one.*/
          Console.WriteLine(" Question 1 ");
          Console.Write("Enter First Number : ");
          int firstNumber = int.Parse(Console.ReadLine());
          int oldFirstNumber = firstNumber;
          Console.Write("Enter Second Number : ");
          int secondNumber = int.Parse(Console.ReadLine());
          if(firstNumber > secondNumber)
          {
              firstNumber = secondNumber;
              secondNumber = oldFirstNumber;
              Console.Write($"The new value of the first number is {firstNumber} and the new value of the second number is {secondNumber}");
          }
          Console.WriteLine();

          /*2. Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators.*/
          Console.WriteLine(" Question 2 ");
          Console.Write("Enter First Number : ");
          int number1 = int.Parse(Console.ReadLine());
          Console.Write("Enter Second Number : ");
          int number2 = int.Parse(Console.ReadLine());
          Console.Write("Enter Third Number : ");
          int number3 = int.Parse(Console.ReadLine());
          if(number1 * number2 * number3 < 0)
          {
              Console.WriteLine("-");
          }
          if(number1 * number2 * number3 == 0)
          {
              Console.WriteLine("0");
          }
          if(number1 * number2 * number3 > 0)
          {
              Console.WriteLine("+");
          }

          /*3. Write a program that finds the biggest of three integers, using nested if statements.*/
          Console.WriteLine(" Question 3 ");
          Console.Write("Enter First Integer : ");
          int firstInteger = int.Parse(Console.ReadLine());
          Console.Write("Enter Second Integer : ");
          int secondInteger = int.Parse(Console.ReadLine());
          Console.Write("Enter Third Integer : ");
          int thirdInteger = int.Parse(Console.ReadLine());
          if(firstInteger > secondInteger && firstInteger > thirdInteger)
          {
              Console.WriteLine($"The biggest integer is {firstInteger}");
          }
          else
          {
              if(secondInteger > firstInteger && secondInteger > thirdInteger)
              {
                  Console.WriteLine($"The biggest integer is {secondInteger}");
              }
              else
              {
                  Console.WriteLine($"The biggest integer is {thirdInteger}");
              }
          }
          Console.WriteLine();

          /*4. Sort 3 real numbers in descending order. Use nested if statements.*/
          Console.WriteLine(" Question 4 ");
          Console.Write("Enter First Real Number : ");
          int firstRealNumber = int.Parse(Console.ReadLine());
          Console.Write("Enter Second Real Number : ");
          int secondRealNumber = int.Parse(Console.ReadLine());
          Console.Write("Enter Third Real Number : ");
          int thirdRealNumber = int.Parse(Console.ReadLine());
          if(firstRealNumber > secondRealNumber && firstRealNumber > thirdRealNumber)
          {
               if(secondRealNumber > thirdRealNumber)
              {
                  Console.Write($"The numbers in descending order is {firstRealNumber}, {secondRealNumber}, {thirdRealNumber}");
              }
              else
              {
                  Console.Write($"The numbers in descending order is {firstRealNumber}, {thirdRealNumber}, {secondRealNumber}");
              }
          }
          else
          {
              if(secondRealNumber > firstRealNumber && secondRealNumber > thirdRealNumber)
              {
                 if(firstRealNumber > thirdRealNumber)
                  {
                     Console.Write($"The numbers in descending order is {secondRealNumber}, {firstRealNumber}, {thirdRealNumber}");
                  }
                  else
                  {
                      Console.Write($"The numbers in descending order is {secondRealNumber}, {thirdRealNumber}, {firstRealNumber}");
                  }
              } 
                  if(thirdRealNumber > secondRealNumber && thirdRealNumber > firstRealNumber)
                  {
                     if(secondRealNumber > firstRealNumber)
                      {
                          Console.Write($"The numbers in descending order is {thirdRealNumber}, {secondRealNumber}, {firstRealNumber}");
                      }
                      else
                      {
                          Console.Write($"The numbers in descending order is {thirdRealNumber}, {firstRealNumber}, {secondRealNumber}");
                      }
                  }
              }
              Console.WriteLine();

              /*5. Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.*/
             Console.WriteLine("Please enter a number between 0 and 9:");
             string numbers = Console.ReadLine();
 
             switch (numbers)
             {
               case "0": 
               Console.WriteLine("Zero");
               break;
               case "1": 
               Console.WriteLine("One"); 
               break;
               case "2": 
               Console.WriteLine("Two"); 
               break;
               case "3": 
               Console.WriteLine("Three"); 
               break;
               case "4": 
               Console.WriteLine("Four");
               break;
               case "5": 
               Console.WriteLine("Five"); 
               break;
               case "6": 
               Console.WriteLine("Six"); 
               break;
               case "7": 
               Console.WriteLine("Seven"); 
               break;
               case "8": 
               Console.WriteLine("Eight"); 
               break;
               case "9": 
               Console.WriteLine("Nine"); 
               break;
               default: 
               Console.WriteLine("Not a digit"); 
               break;
             }
             Console.WriteLine();

         /*6. Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.*/
            Console.WriteLine(" Question 6 ");
            Console.Write("Input the value of a : ");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Input the value of b : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Input the value of c : ");
            int c = int.Parse(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            double firstRoot;
            double secondRoot;
            if(discriminant == 0)
            {
               Console.WriteLine("Both roots are equal");
                firstRoot = -b / (2 * a);
                secondRoot = firstRoot;
               Console.WriteLine($"First  Root = {firstRoot}");
               Console.WriteLine($"Second Root = {secondRoot}");
            }
            else if(discriminant > 0)
	        {
	           Console.WriteLine("Both roots are real and different");
               firstRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
	           secondRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
               Console.WriteLine($"First  Root = {firstRoot}");
	           Console.WriteLine($"Second Root = {secondRoot}");
	        }
	        else
            {
	          Console.Write("Roots are imaginary");
            }
         Console.WriteLine();

         /*7. Write a program that finds the greatest of given 5 numbers.*/
         Console.WriteLine("Number 1 : ");
         int firstNo = int.Parse(Console.ReadLine());
         Console.WriteLine("Number 2 : ");
         int secondNo = int.Parse(Console.ReadLine());
         Console.WriteLine("Number 3 : ");
         int thirdNo = int.Parse(Console.ReadLine());
          Console.WriteLine("Number 4 :");
         int fourthNo = int.Parse(Console.ReadLine());
         Console.WriteLine("Number 5 : ");
         int fifthNo = int.Parse(Console.ReadLine());
         if ((firstNo >= secondNo) && (firstNo >= thirdNo) && (firstNo >= fourthNo) && (firstNo >= fifthNo))
         {
            Console.WriteLine($"The biggest number is: {firstNo}");
            
         }
         if ((secondNo >= firstNo) && (secondNo >= thirdNo) && (secondNo >= fourthNo) && (secondNo >= fifthNo))
         {
            Console.WriteLine($"The biggest number is : {secondNo}");
            
         }
         if ((thirdNo >= firstNo) && (thirdNo >= secondNo) && (thirdNo >= fourthNo) && (thirdNo >= fifthNo))
         {
            Console.WriteLine($"The biggest number is : {thirdNo}");
            
         }
         if ((fourthNo >= firstNo) && (fourthNo >= secondNo) && (fourthNo >= thirdNo) && (fourthNo >= fifthNo))
         {
            Console.WriteLine($"The biggest number is : {fourthNo}");
            
         }
         if ((fifthNo >= firstNo) && (fifthNo >= secondNo) && (fifthNo >= thirdNo) && (fifthNo >= fourthNo))
         {
            Console.WriteLine($"The biggest number is : {fifthNo}");
            
         }
         Console.WriteLine();

         /*8. Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or double, the program increases it by 1. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement.*/
          Console.WriteLine(" Question 8 ");
          Console.Write("Enter 1 for int, 2 for double and 3 for string \nEnter Number : ");
          int variable = int.Parse(Console.ReadLine());
          
          switch (variable)
         {
           case 1 :
           Console.Write("Enter Input For Variable int : ");
           int intVariable = int.Parse(Console.ReadLine());
           Console.WriteLine(++intVariable);
           break;
           case 2 :
           Console.WriteLine("Enter Input For Variable double : ");
           double doubleVariable = double.Parse(Console.ReadLine());
           Console.WriteLine(++doubleVariable);
           break;
           case 3 :
           Console.Write("Enter Input For Variable string : ");
           string stringVariable = Console.ReadLine();
           Console.WriteLine($"{stringVariable}*");
           break;
           default :
           Console.WriteLine("Invalid variable!");
           break;
         }

         /*9. We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:
         - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
         - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.*/
         Console.WriteLine(" Question 9 ");
         Console.Write("Enter First Number : ");
         int num1 = int.Parse(Console.ReadLine());
         Console.Write("Enter Second Number : ");
         int num2 = int.Parse(Console.ReadLine());
         Console.Write("Enter Third Number : ");
         int num3 = int.Parse(Console.ReadLine());
         Console.Write("Enter Fourth Number : ");
         int num4 = int.Parse(Console.ReadLine());
         Console.Write("Enter Fifth Number : ");
         int num5 = int.Parse(Console.ReadLine());
         if(num1 + num2 == 0)
         {
            Console.WriteLine($"{num1 + num2}");
         }
         if(num1 + num3 == 0)
         {
            Console.WriteLine($"{num1 + num3}"); 
         }
         if(num1 + num4 == 0)
         {
            Console.WriteLine($"{num1 + num4}");
         }
         if(num1 + num5 == 0)
         {
            Console.WriteLine($"{num1 + num5}");
         }
         if(num2 + num3 == 0)
         {
            Console.WriteLine($"{num2 + num3}");
         }
         if(num2 + num4 == 0)
         {
            Console.WriteLine($"{num2 + num4}");
         }
         if(num2 + num5 == 0)
         {
            Console.WriteLine($"{num2 + num5}");
         }
         if(num3 + num4 == 0)
         {
            Console.WriteLine($"{num3 + num5}");
         }
         if(num3 + num5 == 0)
         {
            Console.WriteLine($"{num3 + num5}");
         }
         if(num4 + num5 == 0)
         {
            Console.WriteLine($"{num4 + num5}");
         }
         if(num1 + num2 + num3 == 0)
         {
            Console.WriteLine($"{num1 + num2 + num3}");
         }
         if(num1 + num2 + num4 == 0)
         {
            Console.WriteLine($"{num1 + num2 + num4}");
         }
         if(num1 + num2 + num5 == 0)
         {
            Console.WriteLine($"{num1 + num2 + num5}");
         }
         if(num1 + num3 + num4 == 0)
         {
            Console.WriteLine($"{num1 + num3 + num4}");
         }
         if(num1 + num3 + num5 == 0)
         {
            Console.WriteLine($"{num1 + num3 + num5}");
         }
         if(num2 + num3 + num4 == 0)
         {
            Console.WriteLine($"{num2 + num3 + num4}");
         }
         if(num2 + num4 + num5 == 0)
         {
            Console.WriteLine($"{num2 + num4 + num5}");
         }
         if(num3 + num4 + num5 == 0)
         {
            Console.WriteLine($"{num2 + num3 + num4}");
         }
         Console.ReadLine();

          /*10. Write a program that applies bonus points to given scores  in the range [1…9] by the following rules:
          - If the score is between 1 and 3, the program multiplies it by 10.
          - If the score is between 4 and 6, the program multiplies it by 100.
          - If the score is between 7 and 9, the program multiplies it by 1000.
          - If the score is 0 or more than 9, the program prints an error message.*/
          Console.WriteLine(" Question 10 ");
          Console.Write("Enter score : ");
          int score = int.Parse(Console.ReadLine());

          switch(score)
         {
            case 1 :
            case 2 :
            case 3 :
            Console.WriteLine($"The final score is {score * 10}");
            break;
            case 4 :
            case 5 :
            case 6 :
            Console.WriteLine($"The final score is {score * 100}");
            break;
            case 7 :
            case 8 :
            case 9 :
            Console.WriteLine($"The final score is {score * 1000}");
            break;
            default :
            Console.WriteLine("It's either you failed or an invalid score has been inputed");
            break;
         }
         Console.WriteLine();

          /*11. * Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
         - 0 --> "Zero"
         - 12 --> "Twelve"
         - 98 --> "Ninety eight"
         - 273 --> "Two hundred seventy three"
         - 400 --> "Four hundred"
         - 501 --> "Five hundred and one"
         - 711 --> "Seven hundred and eleven"*/
         Console.WriteLine(" Question 11 ");
         Console.Write("Enter a number between 0 and 999 : ");
         short number = short.Parse(Console.ReadLine());
         byte hundreds = (byte)(number / 100 | 0);
         byte tensAndUnits;

         if (number > 99) 
         {
            tensAndUnits = (byte)(number % 100);
         }
         else 
         {
            tensAndUnits = (byte)(number * 1);
         }
         byte units = (byte)(number % 10);

         switch (hundreds)
         {
            case 1:
            Console.Write("One hundred ");
            break;
            case 2: 
            Console.Write("Two hundred "); 
            break;
            case 3: 
            Console.Write("Three hundred "); 
            break;
            case 4: 
            Console.Write("Four hundred ");
            break;
            case 5:
            Console.Write("Five hundred "); 
            break;
            case 6: 
            Console.Write("Six hundred ");
            break;
            case 7: 
            Console.Write("Seven hundred "); 
            break;
            case 8: 
            Console.Write("Eight hundred "); 
            break;
            case 9: 
            Console.Write("Nine hundred "); 
            break;
         }
         if(hundreds >= 1 && tensAndUnits >= 1) 
         {
            Console.Write( "and "); 
         }

         if(tensAndUnits >= 20 && tensAndUnits < 30) 
         {
           Console.Write("Twenty");
         }
         else if (tensAndUnits >= 30 && tensAndUnits < 40) 
         {
            Console.Write("Thirty");
         }
         else if (tensAndUnits >= 40 && tensAndUnits < 50) 
         {
            Console.Write("Fourty");
         }
         else if (tensAndUnits >= 50 && tensAndUnits < 60) 
         {
            Console.Write("Fifty");
         }
         else if (tensAndUnits >= 60 && tensAndUnits < 70) 
         {
            Console.Write("Sixty");
         }
         else if (tensAndUnits >= 70 && tensAndUnits < 80) 
         {
            Console.Write("Seventy");
         }
         else if (tensAndUnits >= 80 && tensAndUnits < 90) 
         {
            Console.Write("Eighty");
         }
         else if (tensAndUnits >= 90 && tensAndUnits < 100) 
         {
            Console.Write("Ninety");
         }

         switch(tensAndUnits)
         {
            case 1:
            Console.Write("One"); 
            break;
            case 2: 
            Console.Write("Two"); 
            break;
            case 3: 
            Console.Write("Three"); 
            break;
            case 4: 
            Console.Write("Four"); 
            break;
            case 5: 
            Console.Write("Five"); 
            break;
            case 6: 
            Console.Write("Six"); 
            break;
            case 7: 
            Console.Write("Seven");
            break;
            case 8:
            Console.Write("Eight"); 
            break;
            case 9: 
            Console.Write("Nine"); 
            break;
            case 10: 
            Console.Write("Ten"); 
            break;
            case 11: 
            Console.Write("Eleven"); 
            break;
            case 12: 
            Console.Write("Twelve"); 
            break;
            case 13: 
            Console.Write("Thirteen"); 
            break;
            case 14: 
            Console.Write("Fourteen"); 
            break;
            case 15: 
            Console.Write("Fifteen"); 
            break;
            case 16: 
            Console.Write("Sixteen"); 
            break;
            case 17: 
            Console.Write("Seventeen"); 
            break;
            case 18: 
            Console.Write("Eighteen"); 
            break;
            case 19: 
            Console.Write("Nineteen");
             break;                
         }
         if (tensAndUnits > 20)
         {
           switch(units)
            {
               case 1: 
               Console.Write("-one"); 
               break;
               case 2: 
               Console.Write("-two"); 
               break;
               case 3: 
               Console.Write("-three"); 
               break;
               case 4:
               Console.Write("-four"); 
               break;
               case 5: 
               Console.Write("-five"); 
               break;
               case 6: 
               Console.Write("-six"); 
               break;
               case 7: 
               Console.Write("-seven"); 
               break;
               case 8: 
               Console.Write("-eight"); 
               break;
               case 9: 
               Console.Write("-nine"); 
               break;
            }
         }
	        if(number == 0) 
            {
               Console.Write("Zero");
            }





          

        }
    }
}
