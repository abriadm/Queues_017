﻿namespace Queue
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Queues()
        {
            /* Initializing the values of the REAR and FRONT to -1 is indicate that
             * the queue is initially empty.*/
            FRONT= -1;
            REAR= -1;
        }
        public void insert(int element)
        {
            /* This statement checks for the stackoverflow condition. */
            if((FRONT == 0 && REAR == max - 1) || (FRONT == REAR +1))
            {
                Console.WriteLine("\nStackOverflow\n");
                return;
            }
            /* This following statement checks whether the queue is empty
             * then the value of the REAR and FRONT variable is set to 0.*/
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            

        }
    }
}