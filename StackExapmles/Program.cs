using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExapmles
{
    internal class Program
    {

        static void ImplementBrowserBackButton()
        {

            Stack<string> history = new Stack<string>();
            history.Push("Page1");
            history.Push("Page2");
            history.Push("Page3");

            Console.WriteLine("Back from: " + history.Pop()); // Output: Back from: Page3
            Console.WriteLine("Current Page: " + history.Peek()); // Output: Current Page: Page2
            Console.ReadKey();
        }


        // Convert Decimal to Binary
        static string DecimalToBinary(int number)
        {

            Stack<int> stack = new Stack<int>();

            while ( number > 0 )
            {
                stack.Push(number % 2);
                number /= 2;
            }

            return string.Join("" , stack);
        }

        //Undo Operations in a Calculator
        static void UndoOperationsinaCalculator()
        {

            Stack<int> calculatorStack = new Stack<int>();
            calculatorStack.Push(10);
            calculatorStack.Push(20);
            calculatorStack.Push(30);


            Console.WriteLine("Undo: " + calculatorStack.Pop()); // Output: Undo: 30
            Console.WriteLine("Current Result: " + calculatorStack.Peek()); // Output: Current Result: 20
            Console.ReadKey();
        } 

        static void Main()
        {
            Console.WriteLine(DecimalToBinary(10)); // Output: 1010
            Console.ReadKey();
        }

    }
}
