namespace Queue
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
            if(FRONT == - 1)
            {
                FRONT= 0;
                REAR= 0;
            }
            else
            {
                /* If REAR is at the last position of the array, then the value of
                 * REAR is set to, that corresponds to the first position of the array.*/
                if(REAR == max - 1)
                {
                    REAR = 0;
                }
                else
                {
                    /* If REAR is not at the last position, then it's value is in incremented by 1.*/
                    REAR = REAR + 1;
                }
            }
            /* Once the position of REAR is determined, the element is added at  it's proper place.*/
            queue_array[REAR] = element;
        }
        public void remove(int element) 
        {
            /* Checks wheather the queue is empty.*/
            if(FRONT == - 1)
            {
                Console.WriteLine("\nQueue is empty.\n");
                return;
            }
            Console.WriteLine("\nThe element deleted [" + queue_array[FRONT] + "]\n");
            /* Check if the queue has one element.*/
            if(FRONT == REAR)
            {
                FRONT = - 1;
                REAR = - 1;
            }
            else
            {
                /* If the element to be deleted is at the last position of the array, then the value
                 * of FRONT is set to 0 i.e to the first element of the array.*/
                if(FRONT == max - 1)
                {
                    FRONT = 0;
                }
                else
                {
                    /* FRONT is incremented by one if it's not the first element of array.*/
                    FRONT = FRONT + 1;
                }
            }
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            /* */
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            

        }
    }
}