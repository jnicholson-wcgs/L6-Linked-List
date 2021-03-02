using System;

class MainClass {

  // Node for the linked list
  class Node {
    // Node item can only be set when constructed
    private string _item;             // item in list
    public string item {              // getter
      get => _item;
    }
    private Node _next;             // Next node
    public Node next {              // Setter and getter
      get => _next;
      set => _next = value;
    }
        
    // Node Constructor
   public Node (string s) {
      _item = s;                  	// the item
      _next = null;              	// initialise to null
    }
  };
 
  // LinkedList class
  class LinkedList {
    // Linked list has a Node, to store the head of the list.
    private Node head;
  
    // LinkedList Constructor
    // Create a node for the head - makes the logic for the 
    // empty list easier to code
    public LinkedList () {
      head = new Node ("Head of list - do not use");
    }

    public bool isFull() { return false; }           // Always room 
    public bool isEmpty() {return (head.next == null);}         

    // Append to the end of the list
    // Traverse the next pointer until you get to null
    // Create new node and add to end of list
    public void append (string s) {
      Console.WriteLine ("Append: {0}", s);

      // Starting at head, find the end of the list
      Node n = head;
      while (n.next != null)
        n = n.next;

      // At the end of list - add the new node here.
      // Allocate Node() from the heap
      n.next = new Node(s);
    }

    // Simple debug that traverses the list and print node items
    public void printDebug () {
      Node n = head.next;

      while (n != null) {
        Console.WriteLine ("Node: {0}", n.item);
        n = n.next;
      }
    }

    // You need to implement length()
    // Traverse the list and count the nodes

    public int length() {
      Console.WriteLine ("You need to implement length()");
      return -1;
    }

    // You need to implement pop()
    // Minimum is to implement pop(0) to remove the head of the list

    public string pop(int pos) {
      return "You need to implement pop()";
    }
  
    // You need to implement push()
    // Creat a new node and insert it into the head of the list

    public void push (string item) {
      Console.WriteLine ("You need to implement push()");
    }

    // You need to implment print()
    // Returns a string of the form [item, item, item]
    // Comma separated items. 
    // Empty list is []

    public string print () {
      return "[You need to implement print()]";
    }

    // What other methods can you implement?
    // peek()
    // reverse()
    // remove()
  };
 


  public static void Main (string[] args) {
    LinkedList l = new LinkedList();

    if (l.isEmpty())
      Console.WriteLine ("List is initialised");
    if (!l.isFull())
      Console.WriteLine ("And ready for data");
    l.append ("Hello");
    l.append ("World");

    l.printDebug();        // Crude debug


    // Length of the list
    Console.WriteLine ("List has {0} items", l.length());
    // Pop off the front of the list
    Console.WriteLine ("Popped: {0}", l.pop (0));
    l.push ("New item at head");
    Console.WriteLine ("List is: {0}", l.print());
  }
}
