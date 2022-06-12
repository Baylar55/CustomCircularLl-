using System.Collections;
using System.Collections.Generic;
using System;

namespace Custom_CircularLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<string> ll = new MyLinkedList<string>();

            ll.AddFirst("ali");
            ll.AddFirst("mehmet");
            ll.AddFirst("safak");
            ll.AddFirst("ugur");
            ll.AddFirst("ibrahim");
            ll.AddBefore(ll.Head.Next, "arif");
          
            foreach (var item in ll)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
