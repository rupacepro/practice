

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

public class SinglyLinkedList
{
    private Node head;
    public SinglyLinkedList()
    {
        head = null;
    }

    public void AddLast(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Remove(int data)
    {
        if (head == null)
        {
            return;
        }
        if (head.Value == data)
        {
            head = head.Next;
            return;
        }
        Node current = head;
        while (current.Next.Value != data && current.Next != null)
        {
            current = current.Next;
        }
        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }


    public void deleteMiddleNode()
    {
        if (head == null && head.Next == null)
        {
            return;
        }

        Node current = head;
        int length = 0;
        while (current != null)
        {
            current = current.Next;
            length++;
        }

        int middleNode = length / 2;
        Node prev = null;
        current = head;
        for (int i = 0; i < middleNode; i++)
        {
            prev = current;
            current = current.Next;
        }
        if (prev != null && current != null)
        {
            prev.Next = current.Next;
        }
    }

    public void Reverse()
    {
        Node current = head;
        Node reverse = current.Next;
        Node temp;

        while (reverse != null)
        {
            reverse.Next = current;
            temp = reverse;
            reverse = current.Next.Next;
            current = temp;
        }

        head = current;
    }

    public void PrintList()
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
        Console.WriteLine("Null");
    }

    static void Main(string[] args)
    {
        SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
        singlyLinkedList.AddLast(1);
        singlyLinkedList.AddLast(2);
        singlyLinkedList.AddLast(3);
        singlyLinkedList.PrintList();

        singlyLinkedList.deleteMiddleNode();

        singlyLinkedList.PrintList();


        singlyLinkedList.Reverse();
        singlyLinkedList.PrintList();
    }
}

