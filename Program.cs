using System;
using System.Collections.Generic;

namespace DataStuctureWeekTwo
{
    class Program
    {
        static void Main(string[] args)
        {
             //Stack Unit Test
            Stack Platestack = new Stack();

            Console.WriteLine(Platestack.IsEmpty());
            Platestack.Push("Plate1");
            Platestack.Push("Plate2");
            Platestack.Pop();
            Console.WriteLine($"The Plate at the top  is {Platestack.Peek()}");
            Console.WriteLine($"Size of plate after Poping Plate2 is {Platestack.Sizes()}");
            Platestack.Push("Plate3");
            Platestack.Push("Plate4");
            Console.WriteLine($"The Plate at the top  is {Platestack.Peek()}");
            Console.WriteLine($"Size of plate after Pusing 3 and 4 are Plate is {Platestack.Sizes()}");
            Console.WriteLine(Platestack.IsEmpty());
            

        }
    }

    public class Stack
    {
        private List<object> stackList = new List<object>();

        public Stack()
        {
            
        }
        public void Push(object data)
        {
            if (data == null)
            {
                throw new InvalidOperationException("Please enter a valid Data to push");
            }
            stackList.Add(data);           
        }

        public bool IsEmpty()
        {
            int stackContents = stackList.Count;
            return (stackContents == 0) ? true : false;
        }
        public void Pop()
        {
            int stackContents = stackList.Count;
            //Check if the stackList is empty

            if (stackContents==0)
            {
                Console.WriteLine("Nothing to Pop");
            }           
            
            stackList.RemoveAt(stackContents - 1);
            

        }
        public object Peek()
        {
            int stackContents = stackList.Count;
            var topVal = stackList[stackContents-1];
            return topVal;

        }
        
        public int Sizes()
        {
            int stackContents = stackList.Count;
            return stackContents;
        }

    }

    public class Queue
    {
        private List<object> queueList = new List<object>();

        public void Enqueue(object data){
            if (data == null)
            {
                throw new InvalidOperationException("Please enter a valid Data to push");
            }
            queueList.Add(data);
        
        }

       
        public void Dequeue()
        {
            if (queueList[0]==null)
            {
                throw new InvalidOperationException("No Data in the Queue to Deque");
            }
            queueList.RemoveAt(0);
        }

        public bool IsEmpty()
        {
            int queueContents = queueList.Count;
            return (queueContents == 0) ? true : false;
        }
        public int Size()
        {
            int queueContents = queueList.Count;
            return queueContents;
        }
    
    }



}
