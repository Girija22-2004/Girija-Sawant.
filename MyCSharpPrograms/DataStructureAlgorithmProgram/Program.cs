using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine(" *** DATA STRUCTURE & ALGORITHM *** ");
        Console.WriteLine("Choose the following Data Structure & Algorithm program:");
        Console.WriteLine();
        Console.WriteLine("1. Sort String & Fibonacci Series");
        Console.WriteLine("2. Stack using Array");
        Console.WriteLine("3. Queue using Array");
        Console.WriteLine("4. Singly Linked List");
        Console.WriteLine("5. Doubly Linked List");
        Console.WriteLine("6. Circular Linked List");
        Console.WriteLine("7. Doubly Circular Linked List");
        Console.WriteLine("8. Binary Search & Sequential Search");
        Console.WriteLine("9. Fibonacci Search");
        Console.WriteLine("10. Insertion Sort");
        Console.WriteLine("11. Bubble Sort");
        Console.WriteLine("12. Hashing");
        Console.WriteLine();

        int choice = int.Parse(Console.ReadLine()!);

        switch (choice)
        {
            case 1:
             SortStringAndFibonacci();
              break;
            case 2:
             StackArray();
              break;
            case 3:
             QueueArray();
              break;
            case 4:
             SinglyLinkedList();
              break;
            case 5:
             DoublyLinkedList();
              break;
            case 6:
             CircularLinkedList();
              break;
            case 7:
             DoublyCircularLinkedList();
              break;
            case 8:
             SearchPrograms();
              break;
            case 9:
             FibonacciSearchProgram();
              break;
            case 10:
             InsertionSort();
              break;
            case 11:
             BubbleSort();
              break;
            case 12:
             HashingProgram();
              break;
            default:
             Console.WriteLine("Invalid Choice");
              break;
        }
    }

    



static void SortStringAndFibonacci()
{
    
    Console.Write("Enter string: ");
    string input = Console.ReadLine()!;
    char[] s = input.ToCharArray();
    Array.Sort(s);
    Console.WriteLine("Sorted string: " + new string(s));

  
    Console.Write("Enter n for Fibonacci: ");
    int n = int.Parse(Console.ReadLine()!);

    int a = 0, b = 1;
    Console.Write("Fibonacci: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write(a + " ");
        int c = a + b;
        a = b;
        b = c;
    }
}











    // 2. Stack using Array
    
    
static void StackArray()
{
    int[] stack = new int[5];
    int top = -1;

    while (true)
    {
        Console.WriteLine("\n1. Push");
        Console.WriteLine("2. Pop");
        Console.WriteLine("3. Display");
        Console.WriteLine("4. Exit");
        Console.Write("Enter choice: ");

        int ch = int.Parse(Console.ReadLine()!);

        if (ch == 1)
        {
            if (top == stack.Length - 1)
                Console.WriteLine("Stack Overflow");
            else
            {
                Console.Write("Enter element: ");
                stack[++top] = int.Parse(Console.ReadLine()!);
            }
        }
        else if (ch == 2)
        {
            if (top == -1)
                Console.WriteLine("Stack Underflow");
            else
                Console.WriteLine("Popped element: " + stack[top--]);
        }
        else if (ch == 3)
        {
            if (top == -1)
                Console.WriteLine("Stack is empty");
            else
            {
                Console.Write("Stack elements: ");
                for (int i = top; i >= 0; i--)
                    Console.Write(stack[i] + " ");
            }
        }
        else if (ch == 4)
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
}











    // 3. Queue using Array
  
  
static void QueueArray()
{
    int[] q = new int[5];      
    int front = 0, rear = -1;  

    while (true)
    {
        
        Console.WriteLine("\n1. Enqueue");
        Console.WriteLine("2. Dequeue");
        Console.WriteLine("3. Display");
        Console.WriteLine("4. Exit");
        Console.Write("Enter choice: ");

        int ch = int.Parse(Console.ReadLine()!);

        // ENQUEUE operation
        if (ch == 1)
        {
            if (rear == q.Length - 1)
            {
                Console.WriteLine("Queue Full");
            }
            else
            {
                Console.Write("Enter element: ");
                q[++rear] = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Element inserted");
            }
        }

        // DEQUEUE operation
        else if (ch == 2)
        {
            if (front > rear)
            {
                Console.WriteLine("Queue Empty");
            }
            else
            {
                Console.WriteLine("Deleted element: " + q[front++]);
            }
        }

        // DISPLAY operation
        else if (ch == 3)
        {
            if (front > rear)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.Write("Queue elements (front to rear): ");
                for (int i = front; i <= rear; i++)
                {
                    Console.Write(q[i] + " ");
                }
            }
        }

        // EXIT
        else if (ch == 4)
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
}








// 4. SinglyLinkedList

static void SinglyLinkedList()
{
    LinkedList<int> list = new LinkedList<int>();

    Console.Write("Enter number of elements: ");
    int n = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Enter element {i + 1}: ");
        int value = int.Parse(Console.ReadLine()!);
        list.AddLast(value);   
    }

    Console.WriteLine("Singly Linked List:");
    foreach (int x in list)
        Console.Write(x + " ");
    Console.WriteLine();
}








// 5 . DoublyLinkedList

static void DoublyLinkedList()
{
    LinkedList<int> list = new LinkedList<int>();

    Console.Write("Enter number of elements: ");
    int n = int.Parse(Console.ReadLine()!);
  
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Enter element {i + 1}: ");
        int value = int.Parse(Console.ReadLine()!);
        list.AddLast(value);   
    }

    Console.WriteLine("Forward traversal:");
    foreach (int x in list)
        Console.Write(x + " ");

    Console.WriteLine("\nBackward traversal:");
    var node = list.Last;
    while (node != null)
    {
        Console.Write(node.Value + " ");
        node = node.Previous;
    }
}










    // 6. Circular Linked List 
class Node
{
    public int data;
    public Node? next;

    public Node(int data)
    {
        this.data = data;
        next = null;
    }
}
static void CircularLinkedList()
{
    Node? head = null;

    Console.Write("Enter number of elements: ");
    int n = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Enter element {i + 1}: ");
        int value = int.Parse(Console.ReadLine()!);

        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            newNode.next = head;   // circular
        }
        else
        {
            Node temp = head;
            while (temp.next != head)
                temp = temp.next;

            temp.next = newNode;
            newNode.next = head;   // circular
        }
    }

    Console.WriteLine("Circular Linked List:");
    if (head != null)
    {
        Node temp = head;
        do
        {
            Console.Write(temp.data + " ");
            temp = temp.next!;
        } while (temp != head);
    }
    Console.WriteLine();
}






    // 7. Doubly Circular Linked List
    static void DoublyCircularLinkedList()
    {
        Console.WriteLine("Doubly Circular Linked List implemented logically (exam concept)");
    }
 







    // 8. Sequential & Binary Search
    static void SearchPrograms()
    {
        int[] a = { 10, 20, 30, 40, 50 };
        Console.Write("Enter key: ");
        int key = int.Parse(Console.ReadLine()!);

       
        bool found = false;
        foreach (int x in a) if (x == key) found = true;
        Console.WriteLine(found ? "Found (Sequential)" : "Not Found");
 

        int l = 0, r = a.Length - 1;
        while (l <= r)
        {
            int m = (l + r) / 2;
            if (a[m] == key) { Console.WriteLine("Found (Binary)"); return; }
            else if (key < a[m]) r = m - 1;
            else l = m + 1;
        }
        Console.WriteLine("Not Found (Binary)");
    }









static void FibonacciSearchProgram()
{
    
    Console.Write("Enter array: ");
    string[] arrInput = Console.ReadLine()!
        .Split(' ', StringSplitOptions.RemoveEmptyEntries); // important
    int[] arr = Array.ConvertAll(arrInput, int.Parse);

  
    Console.Write("Enter key: ");
    int x = int.Parse(Console.ReadLine()!);

    // Fibonacci Search algorithm
    int fib1 = 0, fib2 = 1, fib = fib1 + fib2;

    while (fib < arr.Length)
    {
        fib1 = fib2;
        fib2 = fib;
        fib = fib1 + fib2;
    }

    int offset = -1;
    while (fib > 1)
    {
        int i = Math.Min(offset + fib1, arr.Length - 1);

        if (arr[i] < x)
        {
            fib = fib2;
            fib2 = fib1;
            fib1 = fib - fib2;
            offset = i;
        }
        else if (arr[i] > x)
        {
            fib = fib1;
            fib2 -= fib1;
            fib1 = fib - fib2;
        }
        else
        {
            Console.WriteLine("Found at index " + i);
            return;
        }
    }

    if (fib2 == 1 && offset + 1 < arr.Length && arr[offset + 1] == x)
        Console.WriteLine("Found at index " + (offset + 1));
    else
        Console.WriteLine("Not Found");
}















    // 10. Insertion Sort
  
static void InsertionSort()
{
    Console.Write("Enter how many numbers you want in the array: ");
    int size = int.Parse(Console.ReadLine()!);

    int[] a = new int[size];

    Console.WriteLine($"Enter {size} numbers separated by space:");
    string[] inputs = Console.ReadLine()!.Split(' ');

    if (inputs.Length != size)
    {
        Console.WriteLine("Number of inputs does not match the size!");
        return;
    }

    for (int i = 0; i < size; i++)
    {
        a[i] = int.Parse(inputs[i]);
    }

    Console.WriteLine("\nOriginal array:");
    foreach (int x in a) Console.Write(x + " ");
    Console.WriteLine();

   
    for (int i = 1; i < a.Length; i++)
    {
        int key = a[i];
        int j = i - 1;
        while (j >= 0 && a[j] > key)
        {
            a[j + 1] = a[j];
            j--;
        }
        a[j + 1] = key;
    }

    Console.WriteLine("\nSorted array:");
    foreach (int x in a) Console.Write(x + " ");
    Console.WriteLine();
}








    // 11. Bubble Sort

static void BubbleSort()
{
    Console.Write("Enter how many numbers you want in the array: ");
    int size = int.Parse(Console.ReadLine()!);

    int[] a = new int[size];

    Console.WriteLine($"Enter {size} numbers separated by space:");
    string[] inputs = Console.ReadLine()!.Split(' ');

    if (inputs.Length != size)
    {
        Console.WriteLine("Number of inputs does not match the size!");
        return;
    }

    for (int i = 0; i < size; i++)
    {
        a[i] = int.Parse(inputs[i]);
    }

    Console.WriteLine("\nOriginal array:");
    foreach (int x in a) Console.Write(x + " ");
    Console.WriteLine();

   
    for (int i = 0; i < a.Length - 1; i++)
    {
        for (int j = 0; j < a.Length - i - 1; j++)
        {
            if (a[j] > a[j + 1])
            {
                int t = a[j];
                a[j] = a[j + 1];
                a[j + 1] = t;
            }
        }
    }

    Console.WriteLine("\nSorted array:");
    foreach (int x in a) Console.Write(x + " ");
    Console.WriteLine();
}








    // 12. Hashing
    static void  HashingProgram()
    {
        int[] hash = new int[10];
        Console.Write("Enter number: ");
        int key = int.Parse(Console.ReadLine()!);
        int index = key % 10;
        hash[index] = key;
        Console.WriteLine("Stored at index " + index);
    }
   }
  