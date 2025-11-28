using System;
using System.Collections.Generic;

namespace BridgeLabz_Training.Practice._3_Linked_List;
{
    public class P1_SLL
    {
        class Node
        {
            public:
            int data;
            Node* next;

            Node(int val) // CONSTRUCTOR
            {
                data = val;
                next = NULL;
            }
        };

        /* 
        Through this above code, we created our nodes.

        Now, in order to combine these nodes, we'll create another class. (let's call it List)

        For tha, we'll store two main things:
        1) Head (Special Node* pointer)
        2) Tail (Special Node* pointer)
        */

        class List
        {
            Node* head;
            Node* tail;
            // we are not passing these values, so we'll face no issues, even if they are private

            public:
            List()
            {
                head = tail = NULL;
            }
            // Because the LL which is created in beginning is Empty, and there's no node in it, for which we will define functions.
            void push_front(int val)
            {

            }




        }


    }
}
}

