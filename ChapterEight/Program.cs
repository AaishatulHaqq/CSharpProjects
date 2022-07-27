using System;

namespace ChapterEight
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system.*/
            int firstNumber = 151;
            string decimalNumber1 = firstNumber.ToString();
            int binaryValue1 = Convert.ToInt32(decimalNumber1, 10);
            string convertToBinary1 = Convert.ToString(binaryValue1, 2);
            Console.WriteLine($"The equivalent Binary Value of {firstNumber} is : {convertToBinary1}");
            int secondNumber = 35;
            string decimalNumber2 = secondNumber.ToString();
            int binaryValue2 = Convert.ToInt32(decimalNumber2, 10);
            string convertToBinary2 = Convert.ToString(binaryValue2, 2);
            Console.WriteLine($"The equivalent Binary Value of {secondNumber} is : {convertToBinary2}");
            int thirdNumber = 43;
            string decimalNumber3 = thirdNumber.ToString();
            int binaryValue3 = Convert.ToInt32(decimalNumber3, 10);
            string convertToBinary3 = Convert.ToString(binaryValue3, 2);
            Console.WriteLine($"The equivalent Binary Value of {thirdNumber} is : {convertToBinary3}");
            int fourthNumber = 251;
            string decimalNumber4 = fourthNumber.ToString();
            int binaryValue4 = Convert.ToInt32(decimalNumber4, 10);
            string convertToBinary4 = Convert.ToString(binaryValue4, 2);
            Console.WriteLine($"The equivalent Binary Value of {fourthNumber} is : {convertToBinary4}");
            int fifthNumber = 1023;
            string decimalNumber5 = fifthNumber.ToString();
            int binaryValue5 = Convert.ToInt32(decimalNumber5, 10);
            string convertToBinary5 = Convert.ToString(binaryValue5, 2);
            Console.WriteLine($"The equivalent Binary Value of {fifthNumber} is : {convertToBinary5}");
            int sixthNumber = 1024;
            string decimalNumber6 = sixthNumber.ToString();
            int binaryValue6 = Convert.ToInt32(decimalNumber6, 10);
            string convertToBinary6 = Convert.ToString(binaryValue6, 2);
            Console.WriteLine($"The equivalent Binary Value of {sixthNumber} is : {convertToBinary6}");
            Console.WriteLine();

            /*2. Convert the number 1111010110011110(2) to hexadecimal and decimalnumeral systems.*/
            long bNo = 1111010110011110;
            string numberInBinary = bNo.ToString();
            long inBinary =  Convert.ToInt64(numberInBinary, 2);
            string toDecimal = Convert.ToString(inBinary, 10);
           // string toHexaDecimal = Convert.ToString(toDecimal, "X");
            Console.WriteLine($"1111010110011110 to decimal is {toDecimal}");
           

            /*3. Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and decimal numeral systems.*/
            Console.WriteLine(" Question 3 ");
            

           // 4. Write a program that converts a decimal number to binary one.
             Console.WriteLine(" Question 4 ");
             Console.Write("Enter A Decimal Number : ");
             string decimalNo = Convert.ToString(Console.ReadLine());
             int binaryVal = Convert.ToInt32(decimalNo, 10);
             string binaryConvert = Convert.ToString(binaryVal, 2);
             Console.WriteLine($"It's equivalent Binary Value is : {binaryConvert}");
             Console.WriteLine();

             //5. Write a program that converts a binary number to decimal one.
             Console.WriteLine(" Question 5 ");
             Console.Write("Enter A Binary Number : ");
             string binaryNumb = Convert.ToString(Console.ReadLine());
             int deciValue = Convert.ToInt32(binaryNumb, 2);
             Console.WriteLine($"Its Decimal Number is equivalent to : {deciValue}");
             Console.WriteLine();

             //6. Write a program that converts a decimal number to hexadecimal one.
             Console.WriteLine(" Question 6 ");
             Console.Write("Enter A Decimal Number : ");
             int decimalFigure = int.Parse(Console.ReadLine());
             char [] hexadecimalNumber = new char[100];
             for(int i = 0; i < decimalFigure; i++)
             {
                int remainder = decimalFigure % 16;
                
                if(decimalFigure < 10)
                {
                    hexadecimalNumber[i] = (char)(remainder + 48);
                }
                else
                {
                    hexadecimalNumber[i] = (char)(remainder + 55);
                }
                decimalFigure /= 16;
             }
             Console.Write("It's equivalent hexadecimal number is : ");
             for(int k = hexadecimalNumber.Length - 1; k >= 0; k--)
             {
                Console.Write(hexadecimalNumber[k]);
             }
             Console.WriteLine();

             //7. Write a program that converts a hexadecimal number to decimal one.
             Console.WriteLine(" Question 7 ");
             Console.Write("Enter hexadecimal number: ");
             string hexaDeci = Console.ReadLine();
             Console.WriteLine("{0} to decimal is {1}.", hexaDeci, Convert.ToInt32(hexaDeci, 16));
             Console.WriteLine();

             //8. Write a program that converts a hexadecimal number to binary one.
              Console.WriteLine(" Question 8 ");
              Console.Write("Enter hexadecimal number: ");
              string base16 = Console.ReadLine();
              Console.WriteLine("{0} to binary is {1}.", base16, Convert.ToString(Convert.ToInt32(base16, 16), 2));
              Console.WriteLine();

             //9. Write a program that converts a binary number to hexadecimal one.
              Console.WriteLine(" Question 9 ");
              Console.Write("Enter binary number : ");
              string base2 = Console.ReadLine();
              Console.WriteLine("{0} to hexadecimal is {1}.", base2, Convert.ToInt32(base2, 2).ToString("X"));
              Console.WriteLine();

              //10. Write a program that converts a binary number to decimal using the Horner scheme.
              /*Console.WriteLine(" Question 10 ");
              int numberinBaseTwo = 1001; 
              int solveToBaseTen = (((1 * 2 + 0) * 2 + 0) * 2 + 1 = 2 * 2 * 2 + 1);
              Console.WriteLine($"{numberinBaseTwo} in binary is {solveToBaseTen} in decimal");*/
        








           


            

        }
    }
}
