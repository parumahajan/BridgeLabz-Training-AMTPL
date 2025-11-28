/*

** LINKED - LIST **

We have individual boxes inside the memory,
 which we call as Nodes.

These boxes are connected in form of a chain
 with each other.

It is a Dynamic data structure, which stores the
 elements in linear fashion.

We can add, delete nodes , and can resize it
 during the runtime. (just like Vector).

THE MAIN DIFFERENCE BETWEEN LL AND ARRAY/VECTOR :

1) MEMORY ADDRESS 

The address of elements in Arrays and Vectors
 are stored in continguous memory 
 (100, 104, 108, ...),

But the Address of Nodes in a Linked list can be
 any value.

LL is already available through STL via <List>.

LL has two components: 
1) Data
2) Address
-> Using pointers, we store the address of the next node.

If its the last node at the end, then it will store "NULL" as its address.
 

2) INDEX VALUE TRAVERSING

Unlike Arrays and Vectors, we can't access the elements through their index values.

LL can only be tranversed one by one, in linear fashion. 

Hence, its impossible to get O(1) time complexity in case of LL to access a value.

In worst case, we get O(n) time complexity
 
Due to this reason, we maintain an extra pointer, which is the "HEAD POINTER".

It always points to the first node.

If we node the value of any other node, then we'll traverse using it.

We use Head pointer only, in case of SLL.
But in case of DLL, we use both Head and Tail ptr.

Now, the value that we will take within our LL will be of INTEGER TYPE.

-------------------------------------------------
* FUNCTIONS IN LL:

LL has 4 main fns:

1) push_front
-> Inserts a new node in front of the LL, when   
   we pass a value.

2) push_back
-> Inserts a new node at the end of the LL, when 
   we pass a value. 

3) pop_front
-> Deletes the node present at the start of the 
   LL.
 
4) pop_back
-> Deletes the node present at the end of the LL
-------------------------------------------------
Now, we'll practice it:

1) push_front

-> The LL starts with NULL values, so head and tail values will be NULL.

When we try to add a value in the LL, then we have 2 cases:

1) Head is NULL (LL is empty)
2) Head is NOT-NULL (some nodes are available)


1) Head is Null

push_front(1) 

Step 1: Create a node for storing data = 1.

Step 2: We will add the node to our LL, since that node will become the head.

data = 1
Node* = NULL (next pointing address)

Step 3: Both the Head and Tail pointers will point to the new node.






 */