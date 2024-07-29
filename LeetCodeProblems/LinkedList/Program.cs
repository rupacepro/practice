

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
        if(head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Remove(int data)
    {
        if(head == null)
        {
            return;
        }
        if(head.Value == data)
        {
            head = head.Next;
            return;
        }
        Node current = head;
        while(current.Next.Value != data && current.Next != null)
        {
            current = current.Next;
        }
        if(current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    public void PrintList()
    {
        Node current = head;
        while(current != null)
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

        singlyLinkedList.Remove(2);

        singlyLinkedList.PrintList();
    }
}

