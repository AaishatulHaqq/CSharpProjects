using System;

namespace ChapterSeven
{
    class Program
    {
        static void Main(string[] args)
        {
           /*1. Write a program, which creates an array of 20 elements of type integer and initializes each of the elements with a value equals to the index of the element multiplied by 5. Print the elements to the console.*/
           Console.WriteLine(" Question 1 ");
           int [] integers = new int [20];
           for(int i = 0; i < integers.Length; i++)
           {
               Console.Write("Enter Element[{0}] = ", i);
               integers[i] = int.Parse(Console.ReadLine());
           }
           for(int i = 0; i < integers.Length; i++)
           {
               Console.Write($"{5 * integers[i]},");
           }
           Console.WriteLine();

           /*2. Write a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal).*/
           Console.WriteLine(" Question 2 ");
           Console.Write("Enter Length Of The First Array : ");
           int firstLength = int.Parse(Console.ReadLine());
           int [] firstArrayIntegers = new int [firstLength];
           int p;
           for(p = 0; p < firstLength; p++)
           {
               Console.Write("Enter Element[{0}] = ", p);
               firstArrayIntegers[p] = int.Parse(Console.ReadLine());
           }
           Console.WriteLine();
           Console.WriteLine("******************");
           Console.Write("Enter Length Of Second Array : ");
           int secondLength = int.Parse(Console.ReadLine());
           int [] secondArrayIntegers = new int [secondLength];
           int q;
           for(q = 0; q < secondLength; q++)
           {
               Console.Write("Enter Element[{0}] = ", q);
               secondArrayIntegers[q] = int.Parse(Console.ReadLine());
           }
           Console.WriteLine();
           Console.WriteLine("******************");
           if(firstLength != secondLength && firstArrayIntegers[p] != secondArrayIntegers[q])
           {
               Console.WriteLine("The two arrays are not equal");
           }
           else
           {
               Console.WriteLine("The two arrays are equal");
           }
           Console.WriteLine();

           /*3. Write a program, which compares two arrays of type char lexicographically (character by character) and checks, which one is first in the lexicographical order.*/
           Console.WriteLine(" Question 3 ");
           char [] alphabets1 = new char [9] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I'};
           char [] alphabets2 = new char [10] {'Z', 'Y', 'X', 'W', 'V', 'U', 'T', 'S', 'R', 'Q'};
           bool alphabetsEqual = false;
           if (alphabets1.Length < alphabets2.Length)
           {
             Console.WriteLine("First array is lexicographically first.");
           }
           else if (alphabets1.Length > alphabets2.Length)
           {
             Console.WriteLine("Second array is lexicographically first.");
           }
           else
            {
                for (int i = 0; i < alphabets1.Length; i++)
                {
                    if (alphabets1[i] < alphabets2[i])
                    {
                        Console.WriteLine("First array is lexicographically first.");
                        alphabetsEqual = false;
                        break;
                    }
                    if (alphabets1[i] > alphabets2[i])
                    {
                        Console.WriteLine("Second array is lexicographically first.");
                        alphabetsEqual = false;
                        break;
                    }
                }
                if(!alphabetsEqual)
                {
                Console.WriteLine("Arrays are lexicographicaly equal.");
                }
            }
            Console.WriteLine();

            /*4. Write a program, which finds the maximal sequence of consecutive equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.*/
            Console.WriteLine(" Question 4 ");
            int counter = 1; 
            int temporaryCounter = 1; 
            int number = 0;
            Console.Write ("Enter The Length Of The Array : ");
			int length = int.Parse(Console.ReadLine ());
			int [] arrayNumbers = new int [length];

			for (int i = 0; i < length; i++) 
			{
				Console.Write ("Enter Element[{0}] : ", i);
				arrayNumbers[i] = int.Parse (Console.ReadLine ());
			}
            for (int i = 0; i < length - 1; i++) 
			{
                if (arrayNumbers[i] == arrayNumbers[i + 1]) 
                {
                   temporaryCounter++;
                }
                else 
                {
                   temporaryCounter = 1;
                }

				if (temporaryCounter > counter) 
				{
					counter = temporaryCounter;
					number = arrayNumbers[i];
				}
			}
            for(int i = 0; i < counter; i++) 
            {
                Console.Write ("Element[{0}]", number);
            }
            Console.WriteLine();

            /*5. Write a program, which finds the maximal sequence of consecutively placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/
            Console.WriteLine(" Question 5 ");
            int count = 1; 
            int temporarycount = 1; 
            int num = 0;
            Console.Write("Enter The Length Of The Array : ");
			int arrayLength = int.Parse(Console.ReadLine ());
			int [] arrayElements = new int [arrayLength];

			for (int r = 0; r < arrayLength; r++) 
			{
				Console.Write ("Enter Element[{0}] : ", r);
				arrayElements[i] = int.Parse (Console.ReadLine ());
			}



        

           
            



        }
    }
}
