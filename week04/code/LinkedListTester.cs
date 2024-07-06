public static class LinkedListTester {
public static void Run() {
    // Sample Test Cases (may not be comprehensive) 
    Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
    var ll1 = new LinkedList();
    ll1.InsertTail(1);
    ll1.InsertHead(2);
    ll1.InsertHead(2);
    ll1.InsertHead(2);
    ll1.InsertHead(3);
    ll1.InsertHead(4);
    ll1.InsertHead(5);
    Console.WriteLine(ll1.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1};
    ll1.InsertTail(0);
    ll1.InsertTail(-1);
    Console.WriteLine(ll1.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1, 0, -1};
    var ll2 = new LinkedList();
    ll2.InsertTail(1);
    Console.WriteLine(ll2.HeadAndTailAreNotNull()); // True
    Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
    ll1.RemoveTail();
    Console.WriteLine(ll1.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1, 0}
    ll1.RemoveTail();
    Console.WriteLine(ll1.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1}
    var ll3 = new LinkedList();
    ll3.RemoveTail();
    Console.WriteLine(ll3.ToString()); // <LinkedList>{}
    ll3.InsertHead(2);
    ll3.RemoveTail();
    Console.WriteLine(ll3.ToString()); // <LinkedList>{}
    Console.WriteLine(ll3.HeadAndTailAreNull()); // True
    Console.WriteLine("\n=========== RemoveTail TESTS ===========");
    var ll4 = new LinkedList();
    ll4.InsertTail(1);
    ll4.InsertTail(2);
    ll4.InsertTail(3);
    Console.WriteLine(ll4.ToString()); // <LinkedList>{1, 2, 3
    ll4.RemoveTail();
    Console.WriteLine(ll4.ToString()); // <LinkedList>{1, 2
    ll4.RemoveTail();
    Console.WriteLine(ll4.ToString()); // <LinkedList>{1
    ll4.RemoveTail();
    Console.WriteLine(ll4.ToString()); // <LinkedList>{}
    Console.WriteLine(ll4.HeadAndTailAreNull()); // True
    Console.WriteLine("\n=========== PROBLEM 3 TESTS ===========");
    ll1.InsertAfter(3, 35);
    ll1.InsertAfter(5, 6);
    Console.WriteLine(ll1.ToString()); // <LinkedList>{5, 6, 4, 3, 35, 2, 2, 2, 1}
    ll1.Remove(3);
    Console.WriteLine(ll1.ToString()); // <LinkedList>{5, 6, 4, 35, 2, 2, 2, 1}
    ll1.Remove(6);
    Console.WriteLine(ll1.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2, 1}
    ll1.Remove(1);
    Console.WriteLine(ll1.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2}
    ll1.Remove(5);
    Console.WriteLine(ll1.ToString()); // <LinkedList>{4, 35, 2, 2, 2}
    ll1.Remove(2);
    Console.WriteLine(ll1.ToString()); // <LinkedList>{4, 35, 2, 2}
    Console.WriteLine("\n=========== Remove TESTS ===========");
    var ll = new LinkedList();
    ll.InsertTail(1);
    ll.InsertTail(2);
    ll.InsertTail(3);
    ll.InsertTail(2);
    ll.InsertTail(4);
    Console.WriteLine(ll.ToString()); // <LinkedList>{1, 2, 3, 2, 4}
    ll.Remove(2);
    Console.WriteLine(ll.ToString()); // <LinkedList>{1, 3, 2, 4}
    ll.Remove(1);
    Console.WriteLine(ll.ToString()); // <LinkedList>{3, 2, 4}
    ll.Remove(4);
    Console.WriteLine(ll.ToString()); // <LinkedList>{3, 2}
    ll.Remove(5); // No change
    Console.WriteLine(ll.ToString()); // <LinkedList>{3, 2}
    var ll5 = new LinkedList();
    ll5.Remove(0);
    Console.WriteLine(ll5.ToString()); // <LinkedList>{}
    ll5.InsertHead(2);
    ll5.Remove(2);
    Console.WriteLine(ll5.ToString()); // <LinkedList>{}
    Console.WriteLine(ll5.HeadAndTailAreNull()); // True
    Console.WriteLine("\n=========== PROBLEM 4 TESTS ===========");
    ll1.Replace(2, 10);
    Console.WriteLine(ll1.ToString()); // <LinkedList>{4, 35, 10, 10}
    ll1.Replace(7, 5);
    Console.WriteLine(ll1.ToString()); // <LinkedList>{4, 35, 10, 10}
    ll1.Replace(4, 100);
    Console.WriteLine(ll1.ToString()); // <LinkedList>{100, 35, 10, 10}
    Console.WriteLine("\n=========== PROBLEM 5 TESTS ===========");
    Console.WriteLine(ll1.Reverse().AsString()); // <IEnumerable>[10, 10, 35, 100}
}