using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GA_Recursion_EdnaLynnLaxa
{
    //Edna Lynn Laxa ; Computer Programming V ; Assignemnt: Recursion ; January 26, 2024 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NUMBERS PRINT 1-10");
            Console.WriteLine("------------------");
            Console.WriteLine();
            PrintNumbersFrom1to10(1);
            Console.WriteLine();

            Console.WriteLine("Down & Up Count");
            CountDownandUp(5);

            Console.WriteLine();

            int[] numbers = { 12, 45, 7, 23, 9 }; // Adding 5 hardcoded numbers to the array

            Console.WriteLine("Array elements:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            int sum = CalculateSum(numbers, 0);
            Console.WriteLine($"\nSum of the array elements: {sum}");

            Console.WriteLine();
            Console.WriteLine("Fibonacci Method");
            Console.WriteLine("----------------");
            int n = 10; // Change n to the desired Fibonacci sequence length
            Console.WriteLine($"Fibonacci sequence of length {n}:");
            for (int i = 0; i < n; i++)
            {
                int result = Fibonacci(i);
                Console.Write(result + " ");
            }
        }
        static void PrintNumbersFrom1to10(int currentNumber)
        {
            // Step 1 - The Break Case
            //Recursive Method -Print 1 - 10
            //Step 1: We check if the current number(currentNumber) is less than or equal to 10.If this condition is true, we proceed with the following steps. 

            if(currentNumber <=10)
            {
                Console.WriteLine(currentNumber);

                // Increase the current Number by 1 

                int nextNumber = currentNumber + 1;

                // Recursively call the function with the next number 
                PrintNumbersFrom1to10(nextNumber); 

                //When the recursion reaches to 11 b/c the condition in step 1 is no longer valid & no numbers will printed then on. 
            }
        }
        static void CountDownandUp(int currentNumber)
        {
            // Base Case Check for Counting Down: Ensure we don't continue indefinitely while counting down
            if (currentNumber >= 1)
            {
                Console.WriteLine($"Before Recursive Call: {currentNumber}");

                // Recursive Call: Recursively count down
                CountDownandUp(currentNumber - 1);

                Console.WriteLine($"After Recursive Call: {currentNumber}");
            }
        }
        static int CalculateSumIterative(int[] arr)
        {
            //Base Case: When we have reached the end of our array
            //Equivalent of i < arr.Length
            //Recursive Call: Pass in our array, and then increment the index
            //Pass in our array, while also passing in the next iteration of our index
            //When method call is closed, it's returning the current sum of values up to that point.
            //Return: Returns the sum of numbers current, plus the current number.

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static int CalculateSum(int[] arr, int index)
        {
            // Base Case: If the index is equal to the array length, return 0 (no elements to add)
            if (index == arr.Length)
            {
                return 0;
            }
            else
            {
                // Recursive Case:
                // Add the current element (at the current index) to the sum of the rest of the elements
                int currentElement = arr[index];
                int restOfTheSum = CalculateSum(arr, index + 1);
                return currentElement + restOfTheSum;
            }
        }
        static int FibonacciIterative(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int fibNMinus2 = 0; // Initialize the value for F(n-2)
            int fibNMinus1 = 1; // Initialize the value for F(n-1)
            int fibN = 0; // Initialize the value for F(n)

            for (int i = 2; i <= n; i++)
            {
                fibN = fibNMinus1 + fibNMinus2;
                fibNMinus2 = fibNMinus1;
                fibNMinus1 = fibN;
            }

            return fibN;
        }
        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }


        // My take on the explanation that was provided : 
        //Programming Recursion is a process by which a function makes direct or indirect calls to itself. When a case base is hit, the nexted procedure is then 
        //produced ending the recursive calls. 
        // Nested execution is a stack of active function callings formed by each recursive call in which establishes a new level of process. 

        // Topic of Outputs : 
        // With each recursive call, the recursive procedure completes beneficial task. The current number is printed and every desired process can be 
        //carried out at each step by recursive execution. 

        // Topic of Incremental Steps: 
        //  // 3. Incremental Step: Move towards the base case
        //int nextNumber = currentNumber + 1; 
        // To advance a step closer to the base case, this steps make certain modification to input arguments or state. By being certain that recursion approaches
        //the termination of the condition that it is uphelding , this prevent the operation from being stuck. 

        //Topic Recursion Call : Using updated arguments, the recursive procedure calls itself back. The ability to help the function figure out a smaller version 
        //of the same issue which makes this function so fundemental. The recursive calling executes more manageable and it straightforward. 

        //Topic of Base Case Exit: There's indication of the circumstances in which recursion ends. It ends on its own base case when it hits it mark. In the absence
        //of a base case exit, the recursion just does not stop. 


        //TOPIC OF CALL STACK : I like the visual of imagining a stack of plates and plates can be added or removed from the top. 
        // Calling a fucntion is equivalent to adding a new dish to the stack. That dish contains information of that function such as 
        //patterns aka variables. When the function is executed  , the function is done and calls another. This maintains order and guarantee that we
        //we are aware of the program's upcoming steps. 
        //If too many plates were stack, the stack will be too tall and its becomes wobbly, then it becomes a problem. 

        //The key data structure sounds like that call stacks records the function that is currently running basically. It is essential for controlling memory use, 
        //function usage and provides a flow of execution. 


        //The Fibonacci Sequence: 
        // The Recursive Method : This si a direct recflection of the Fibonacci sequence concept which each term is equal to the sum of the two terms that came 
        //before it. The repeated calculation may make it less effective or large quanities. This sequence checks for base case values in the if condition. 



}

