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


        //Queue 



        static void TrafficSignalSystemSimulation()
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

        static void TaskScheduling()
        {
            // Initialize a queue to hold the tasks
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("Task1");
            tasks.Enqueue("Task2");
            tasks.Enqueue("Task3");
            tasks.Enqueue("Task4");


            Console.WriteLine("Executing tasks:");


            // Process tasks in the order they were added
            while ( tasks.Count > 0 )
            {
                // Dequeue the task at the front of the queue
                string currentTask = tasks.Dequeue();
                Console.WriteLine($"Processing: {currentTask}");
            }

            Console.ReadKey();
        }


        static void CustomerService()
        {
            // Initialize a queue to simulate customer arrivals
            Queue<string> customers = new Queue<string>();
            customers.Enqueue("Customer1");
            customers.Enqueue("Customer2");
            customers.Enqueue("Customer3");


            Console.WriteLine("Serving customers:\n");


            // Serve customers in the order they arrived
            while ( customers.Count > 0 )
            {
                // Dequeue the customer at the front of the queue
                string currentCustomer = customers.Dequeue();
                Console.WriteLine($"Serving: {currentCustomer}");
            }
        }

        static void WebPageRequestHandling()
        {
            Queue<string> requests = new Queue<string>();
            requests.Enqueue("Request1");
            requests.Enqueue("Request2");
            requests.Enqueue("Request3");


            Console.WriteLine("Processing web requests:\n");
            while ( requests.Count > 0 )
            {
                string currentRequest = requests.Dequeue();
                Console.WriteLine($"Processed: {currentRequest}");
            }
        }
        
        static Queue<int> ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            while ( queue.Count > 0 )
            {
                stack.Push(queue.Dequeue());
            }
            while ( stack.Count > 0 )
            {
                queue.Enqueue(stack.Pop());
            }
            return queue;
        }
        static bool PalindromeQueue(Queue<int> queue) 
        {


            Stack<int> stack = new Stack<int>(queue);
            foreach ( var item in queue )
            {
                if ( stack.Pop() != item )
                    return false;
            }
            return true;
        }

        static void GenerateBinaryNumbers(int n)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");


            for ( int i = 0 ; i < n ; i++ )
            {
                string binary = queue.Dequeue();
                Console.WriteLine(binary);
                queue.Enqueue(binary + "0");
                queue.Enqueue(binary + "1");
            }
        }

        static void Main()
        {
            Console.WriteLine(DecimalToBinary(10)); // Output: 1010
            Console.ReadKey();

            Queue<int> queue = new Queue<int>(new[] { 1 , 2 , 3 , 4 , 5 });
            Queue<int> reversedQueue = ReverseQueue(queue);
            Console.WriteLine(string.Join(", " , reversedQueue)); // Output: 5, 4, 3, 2, 1
        }

    }
}
