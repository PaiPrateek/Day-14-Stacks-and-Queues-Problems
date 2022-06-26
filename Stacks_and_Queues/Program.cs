using System;

namespace Stacks_and_Queues
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Queue");
            Queue queue = new Queue(3);

            //Adding Elemt into Queue
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);



            //Stack stack = new Stack(3);

            //         Console.WriteLine("Creating Stack: ");
            //// Adding Element into the stack
            //stack.Push(56);
            //stack.Push(30);
            //stack.Push(70);

            //         Console.WriteLine("\n");


            //// Dispaly the latest added element
            //var TC1=stack.Peek();
            //         Console.WriteLine("Peek :" + TC1);
            //Console.WriteLine("\n");

            //// Remove the latest added element
            //var TC2=stack.Pop();
            //Console.WriteLine("Pop :" + TC2);

            //// Remove the element untill stack is empty
            //var TC3 = stack.Peek();
            //Console.WriteLine("Peek :" + TC3);
            //Console.WriteLine("\n");

            //var TC4 = stack.Pop();
            //Console.WriteLine("Pop :" + TC4);

            //var TC5 = stack.Peek();
            //Console.WriteLine("Peek :" + TC5);
            //Console.WriteLine("\n");

            //var TC6 = stack.Pop();
            //Console.WriteLine("Pop :" + TC6);

            //var TC7 = stack.Peek();
            //Console.WriteLine("Peek :" + TC7);


        }
        // Craeting Stack class
        //public class Stack
        //{
        //	int capacity;
        //	int[] obj;
        //	int top = -1;

        //	// Creating Stack method 
        //	public Stack(int capacity)
        //	{
        //		this.capacity = capacity;
        //		obj = new int[capacity];
        //	}


        //	//Creating method to push data into stack
        //	public bool Push(int data)
        //	{
        //		if (top == capacity - 1)
        //		{
        //			Console.WriteLine("Stack overFlow");
        //			return false;
        //		}
        //		obj[++top] = data;
        //		Console.WriteLine(data);
        //		return true;
        //	}

        //	// Creating Pop() method to remove the latest added element from the stack
        //	public int Pop()
        //	{
        //		if (top == -1)
        //		{
        //			Console.WriteLine("Stack Underflow");
        //			return default(int);
        //		}
        //		return obj[top--];
        //	}

        //	// Creating Peek() method to return th leatest added elemet in the stack
        //	public int Peek()
        //	{
        //		if (top == -1)
        //		{
        //			Console.WriteLine("Stack is UnderFlow");
        //			return (int)default;
        //		}
        //		return obj[top];
        //	}
        //}


        // Creating Queue class
        public class Queue
        {

            int capacity;
            int[] obj;
            int front = -1, rear = -1;

            // Creating Queue method
            public Queue(int capacity)
            {
                this.capacity = capacity;
                obj = new int[capacity];
            }

            // Creating Enqueue method to insert the element into the Queue
            public bool Enqueue(int data)
            {
                if (rear == capacity - 1)
                {
                    Console.WriteLine("Que is Full");
                    return false;
                }
                if (rear == -1)
                    front++;
                obj[++rear] = data;
                Console.WriteLine(data);
                return true;
            }
        }

    }
}
