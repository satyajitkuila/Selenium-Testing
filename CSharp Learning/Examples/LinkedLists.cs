using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_Learning.Examples
{
    internal class LinkedLists
    {
        public static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 7, 15 };
            LinkedList<int> list = new LinkedList<int>(num);

            LinkedLists li = new LinkedLists();
            li.node(list);
            int l=li.getlength(list);
            Console.WriteLine("//----Length of the node---//");
            Console.WriteLine(l);
            li.midElement(list);


        }
        //----//
        public void node(LinkedList<int> list1)
        {           
            
            Console.WriteLine("//-----before adding----//");
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }


            // adding a node at the end
            var newNode = list1.AddLast(20);
            // adding a new node after the node added above
            list1.AddAfter(newNode, 30);
            //adding a new node before the node added above
            list1.AddBefore(newNode, 29);
            Console.WriteLine("//-----after adding----//");
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }
            // removing
            list1.Remove(7);
            Console.WriteLine("//----after removing a node---//");
            foreach (var n in list1)
            {
                Console.WriteLine(n);
            }
        }
        //----//
        public int getlength(LinkedList<int> list2)
        {
            int len=list2.Count();
            return len;
        }
        public void midElement(LinkedList<int> list3)
        {
            Console.WriteLine("//--Displaying the Node--//");
            foreach (var n in list3)
            {
                Console.WriteLine(n);
            }

            int l=getlength(list3);
            int mid = (l / 2) - 1;
            Console.WriteLine($"mid loc of the node is {mid}");
            Console.WriteLine("//----Element at the middle of the node---//");
            Console.WriteLine(list3.ElementAt(mid));

        }

    }
}
