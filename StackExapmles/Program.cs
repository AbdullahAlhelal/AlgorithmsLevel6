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

        static void BrowserBackButton()
        {

            Stack<string> history = new Stack<string>();
            history.Push("Page1");
            history.Push("Page2");
            history.Push("Page3");

            Console.WriteLine("Back from: " + history.Pop()); // Output: Back from: Page3
            Console.WriteLine("Current Page: " + history.Peek()); // Output: Current Page: Page2
            Console.ReadKey();
        }


        static void PrinterJobScheduling()
        {
            Queue<string> printerQueue = new Queue<string>();
            printerQueue.Enqueue("Document1");
            printerQueue.Enqueue("Document2");
            printerQueue.Enqueue("Document3");

            Console.WriteLine("Processing: " + printerQueue.Dequeue()); // Output: Processing: Document1
            Console.WriteLine("Next Job: " + printerQueue.Peek()); // Output: Next Job: Document2

        }


        static void Simulatevehicleswaitingatatrafficsignal()
        {
            // Initialize a queue to represent vehicles at the traffic signal
            Queue<string> trafficQueue = new Queue<string>();


            // Add vehicles to the queue
            trafficQueue.Enqueue("Car 1");
            trafficQueue.Enqueue("Truck 1");
            trafficQueue.Enqueue("Bike 1");
            trafficQueue.Enqueue("Bus 1");


            Console.WriteLine("Traffic Signal Simulation Started...\n");

            while ( trafficQueue.Count > 0 )
            {
                // Process the vehicle at the front of the queue
                string vehicle = trafficQueue.Dequeue();
                Console.WriteLine($"{vehicle} has passed the signal.\n");


                // Display the remaining vehicles
                if ( trafficQueue.Count > 0 )
                {
                    Console.WriteLine("Vehicles waiting: " + string.Join(", " , trafficQueue));
                }
                else
                {
                    Console.WriteLine("No vehicles waiting.");
                }


                Console.WriteLine();
            }


            Console.WriteLine("Traffic Signal Simulation Ended.");
        }

     
        static void TicketingSystemSimulation()
        {
            // Initialize a queue to represent ticket numbers
            Queue<int> ticketQueue = new Queue<int>();


            // Simulate ticket generation
            for ( int i = 101 ; i <= 105 ; i++ )
            {
                ticketQueue.Enqueue(i);
                Console.WriteLine($"Ticket {i} issued.");
            }


            Console.WriteLine("\nTicketing System Simulation Started...\n");


            // Process tickets in the queue
            while ( ticketQueue.Count > 0 )
            {
                int currentTicket = ticketQueue.Dequeue();
                Console.WriteLine($"Processing Ticket: {currentTicket}");


                // Display remaining tickets in the queue
                if ( ticketQueue.Count > 0 )
                {
                    Console.WriteLine("Remaining Tickets: " + string.Join(", " , ticketQueue));
                }
                else
                {
                    Console.WriteLine("No more tickets in the queue.");
                }


                Console.WriteLine();
            }


            Console.WriteLine("Ticketing System Simulation Ended.");
        }


        static void ImplementingSimpleBacktracking() 
        {
            Stack<string> path = new Stack<string>();


            Console.WriteLine("Start -> Go to Gaz Station -> Go to Super Market -> Go To Work -> Go to Cafe -> Go Home.\n");

            // Simulate My Day


            path.Push("Start");
            path.Push("Go to Gaz Station");
            path.Push("Go to Super Market");
            path.Push("Go To Work");
            path.Push("Go to Cafe");
            path.Push("Go Home");


            // Backtracking
            Console.WriteLine("Backtracking...\n");
            while ( path.Count > 0 )
            {
                Console.WriteLine($"Back to: {path.Pop()}");
            }
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
