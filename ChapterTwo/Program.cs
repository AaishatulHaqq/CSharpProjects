using System;
namespace ChapterTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, longand ulong in order to assign them the following values: 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.*/
            Console.WriteLine(" Question 1 ");
            sbyte number1 = -115;
            sbyte number2 = -44;
            byte number3 = 97;
            byte number4 = 112;
            byte number5 = 224;
            ushort number6 = 1990;
            ushort number7 = 20000;
            short number8 = -10000;
            ushort number9 = 52130;
            uint number10 = 4825932;
            int number11 = -1000000;
            ulong number12 = 970700000;
            long number13 = 123456789123456789;
          
            Console.Write($"{number1}, {number2}, {number3}, {number4}, {number5}, {number6}, {number7}, {number8}, {number9}, {number10}, {number11}, {number12}, {number13}");
            Console.WriteLine();

          /*2. Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;3456.091124875956542151256683467?*/
           Console.WriteLine("Question 2 ");
           float firstNo = 5.0f;
           float secondNo = -5.01f;
           float thirdNo = 12.345f;
           decimal fourthNo = 8923.1234857m;
           double fifthNo = 3456.091124875956542151256683467d;
           Console.Write($"{firstNo}, {secondNo}, {thirdNo}, {fourthNo}, {fifthNo}");
           Console.WriteLine();
          /*3.Write a program, which compares correctly two real numbers with accuracy at least 0.000001.*/
           Console.WriteLine("Question 3 ");
           Console.Write("Enter A Number : ");
           double numberA = double.Parse(Console.ReadLine());
           Console.Write("Enter Another Number : ");
           double numberB = double.Parse(Console.ReadLine());
           bool equality = Math.Abs(numberA - numberB) < 0.000001;
           Console.Write(equality);
           Console.WriteLine();

          /*4.Initialize a variable of type int with a value of 256 inhexadecimal format (256 is 100 in a numeral system with base 16).*/
           Console.WriteLine(" Question 4 ");
           int hexadecimalNumber = 0x100;
           Console.WriteLine(hexadecimalNumber);
          /*5. Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).*/
           Console.WriteLine(" Question 5 ");
           char character = '\u0072';
           Console.WriteLine(character);

          /*6. Declare a variable isMale of type bool and assign a value to it depending on your gender.*/
           Console.WriteLine("Question 6 ");
           bool isMale = false;
           Console.Write(isMale);
           Console.WriteLine();

          /*7. Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.*/
           Console.WriteLine("Question 7 ");
           string firstString = "Hello ";
           string secondString = "World";
           string concatenation = String.Concat(firstString, secondString);
           object output = concatenation;
           Console.Write(output);
           Console.WriteLine();

          /*8. Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by the concatenation of the two variables of type string (do not miss the space in the middle) to a variable of type object. Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).*/
          Console.WriteLine("Question 8");
          string firstWord = "Hello ";
          string secondWord = "World";
          object concat = String.Concat(firstWord, secondWord);
          string result = concatenation.ToString();
          Console.Write(result);
          Console.WriteLine();

           /*Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer quotes). In one of the variables use quoted string and in the other do not use it.*/
          Console.WriteLine("Question 9 ");
          string firstSentence = "The \"use\" of quotations causes difficulties";
          string secondSentence = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties";
          Console.WriteLine(firstSentence);
          Console.WriteLine(secondSentence);
          Console.WriteLine();

          /*10. Write a program to print a figure in the shape of a heart by the sign "o".*/
          Console.WriteLine(" Question 10 ");
          Console.WriteLine("  0        0 ");
          Console.WriteLine("0   0    0   0");
          Console.WriteLine(" 0   0  0   0");
          Console.WriteLine("  0   00   0");
          Console.WriteLine("   0      0 ");
          Console.WriteLine("    0    0  ");
          Console.WriteLine("     0  0   ");
          Console.WriteLine("      00   ");

          /*11. Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".*/
           Console.WriteLine(" Question 11 ");
           Console.WriteLine("    © ");
           Console.WriteLine("   © © ");
           Console.WriteLine("  ©   © ");
           Console.WriteLine(" ©     © ");
           Console.WriteLine(" ©©©©©©©© ");
           
         /*12. A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables needed to maintain the  information for an employee by using the appropriate data types and attribute names.*/
                Console.WriteLine("Question 12 ");
                Console.Write("Enter Your First Name : ");
                string firstName = Console.ReadLine();
                Console.Write("Enter Your Last Name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter Your Age : ");
                byte age = byte.Parse(Console.ReadLine());
                Console.Write("Gender : ");
                char gender = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter Your ID : ");
                int iD = int.Parse(Console.ReadLine());
                int initialNo = 27560000;
                for(int i = 0; i <= 27569999; i++)
                {
                     iD = i;
                     i = initialNo;
                     if(iD >= 27560000 && iD <= 27569999)
                    {
                       Console.Write(iD);
                       break;
                    }
                    
                     initialNo++;
                     iD++;
                 }
                 
                 /*13 .Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.*/
                   Console.WriteLine(" Question 13 ");
                   int fNo = 5;
                   int sNo = 10;
                   int oldFNo = fNo;
                   fNo = sNo;
                   sNo = oldFNo;
                   Console.WriteLine($"The First Number is : {fNo}");
                   Console.WriteLine($"The second Number is : {sNo}");
                   Console.WriteLine();














          

        }
    }
}
