/*

*** ARRAY: ***

LIMITATIONS OF AN ARRAY:

1) SIZE UPDATION IS NOT POSSIBLE IN STATIC ARRAY.

In an array, the array size is fixed, unless it is a dynamic array.

The only way to increase the size in case of static array is to resize it, by using the Resize function.

Here, a new array is created, and in that the original array values are copied, and the original array is destroyed.


int[] arr = new int[10];
Array.Resize(ref arr, 15);
//we pass the reference parameter of the array

2) ELEMENT CANNOT BE INSERTED OR DELETED FROM MIDDLE OF AN ARRAY.
________________________________________________________
In order to overcome these limitations, we use Collections.

*** COLLECTIONS: ***

A collection can also store multiple values, but the main difference is, it stores like Dynamic Array.

It covers both the limitations of Array.
- It has a feature of Auto-resizing.
- We can insert or delete an element from the middle of the collection.

It is the standardized way in which the objects are handled by a program.

It contains a set of classes which contain the elts in generalized manner.

With the help of collections, the user can perform several operations on objects like the store, update, delete, retrieve, search, sort etc.

There is difference between the modern collections, and old collections.
________________________________________________________
*** 1) NON-GENERIC COLLECTIONS: ***

These were included in the 1.0 version of collections.
Older, store objects (type-safety not enforced).

Eg: ArrayList, Hashtable, Stacks, Queues, LinkedList, SortedList

All these are Collection Classes.

They are not available readily.
We have to first define the class, then only we can use it.

These are defined under the NAMESPACE as:
namespace System.Collections;
________________________________________________________
*** 2) GENERIC COLLECTIONS: ***

Type-safe and faster.

List<T>
Dictionary<TKey, TValue>
Queue<T>
Stack<T>
HashSet<T>
SortedList<TKey, TValue>

The T here stands for "TYPE PARAMETER".
It’s a placeholder for the data type, that the collection will store.

________________________________________________________
*** Difference between Arrays and ArrayList: ***

ARRAYS:

1) Fixed length
2) Not possible to insert items from middle
3) Not possible to delete items from middle

ARRAYLIST:
1) Variable length
2) Possible to insert items from middle
3) Possible to delete items from middle
________________________________________________________
1) AUTO-RESIZING

ArrayList al = new ArrayList(); 
-> We create an ArrayList (NG-Collection), to store the elements.
-> The size isn't mentioned for now, so capacity = 0.

Console.WriteLine(al.Capacity);
-> Using this we can check its capacity.

al.Add(100);
-> Using this we can add an element within the ArrayList.
-> Doing this, will make Capacity = 4.
________________________________________________________
2) INSERTION

al.Insert(<index>, <value>)

Example: al.Insert(3, 350)
________________________________________________________
3) REMOVAL

al.Remove(<value>)
OR
al.RemoveAt(<index>)

Example: al.Remove(350);
________________________________________________________
* NOTE: Array and ArrayList follow a Key/Value Pair.

The problem here is that, Key is Pre-Defined, 
which is the INDEX -> 0 - (size-1)
_______________________________________________________
*** ANOTHER PROBLEM IN ARRAYS AND ARRAYLIST: ***

We have to know the INDEX POSITION of the Attributes, of what elt is stored at which index position.
_______________________________________________________
*** HASHTABLE: ***
In order to solve this problem, we use -> HASH-TABLE.

Just like ArrayList, it can also Auto-Resize it, and also follows the Key-Value Pair Combination.

But the main difference here is that, the Keys are User-Defined, and not Pre-Defined, unlike Arrays and ArrayList.

Hashtable ht = new Hashtable();
ht["id"] = 10001;
ht["name"] = "Pranav";

// Explicit-Casting required after it
int id = (int) ht["id"];
string name = (string) ht["name"];

Console.WriteLine($

_______________________________________________________
DICTIONARY:
Stores data in key–value pairs, where both key and value have specified types.

Dictionary<string, int> marks = new Dictionary<string, int>();
marks.Add("Pranav", 52);

int pranavMarks = marks["Pranav"];
Console.WriteLine("Pranav Marks: " + pranavMarks);
Console.WriteLine($"Pranav Marks : {pranavMarks}");
// String Interpolation
_______________________________________________________
LIST:
A type-safe dynamic array that can store elements of the same type.

List<string> names = new List<string> {"Pranav", "Adarsh"};

foreach (string name in names)
{
    Console.WriteLine(name);
}
_______________________________________________________
QUEUE:

First-In-First-Out (FIFO)

Task scheduling
Message processing (first come, first served)

Queue<string> names = new Queue<string>();
names.Enqueue("Pranav");
_______________________________________________________
STACK:
Last-In-First-Out (LIFO)

Undo/Redo functionality
Backtracking problems

Stack<int> numbers = new Stack();
numbers.Push(10);
_______________________________________________________
SORTED LIST:

Stores key-value pairs in sorted order of keys.

SortedList<int, string> students = new SortedList<int, string>();
students.Add(1, "Pranav");
students.Add(3, "Gaurav");
students.Add(2, "Adarsh");

foreach(var pair in students){
    cw($"{pair.Key} -> {pair.Value}");
}
_______________________________________________________
HASH-SET

A HashSet stores unique elements only (no duplicates).

Hashset<string> fruits = new Hashset<string>();

fruits.Add("Apple");
fruits.Add("Banana");
fruits.Add("Apple");

foreach(var fruit in fruits){
    cw($"fruits : {fruit}");
 */
//_______________________________________________________

ArrayList arr = new ArrayList();

arr.Add(100);

//_______________________________________________________

Hashtable ht = new Hashtable();

ht["id"] = 10001;
ht["name"] = "Pranav";

int id = (int)ht["id"];
string name = (string)ht["name"];

//_______________________________________________________

List<string> names = new List<string>();

names.Add("Pranav");

//_______________________________________________________

Dictionary<string, int> marks = new Dictionary<string, int>();

marks.Add("Pranav", 100);

int pranavMarks = marks["Pranav"];

// _______________________________________________________

SortedArray<int, string> students = new SortedArray<int, string>();

students.Add(3, "Gaurav");
students.Add(1, "Pranav");
students.Add(2, "Adarsh");

// _______________________________________________________

HashSet<string> fruits = new Hashset<string>;

fruits.Add("Apple");
fruits.Add("Banana");
fruits.Add("Apple");

// _______________________________________________________