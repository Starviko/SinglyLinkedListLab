using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListLab
{
    internal class LinkedList
    {
        public Node Head { get; set; }
        public ulong Count { get; set; }
        public LinkedList() { }
        public void AddFirst(string value)
        {
            //create new node
            Node newNode= new Node();
            //set value of new node
            newNode.Value = value;
            //get the node at the head.
            Node head = this.Head;
            //set the next of new node to node at head
            newNode.Next = head;
            //set the head to the new node
            this.Head = newNode;
            //increment count
            this.Count = this.Count+1;
        }
        public void AddLast(string value)
        {
            
            Node appendNode= new Node();
            appendNode.Value = value;
            if(this.Head == null)
            {
                this.Head = appendNode;
            }
            else
            {
                Node currentNode = this.Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = appendNode;
            }
            this.Count = this.Count+1;
        }
        public void RemoveFirst()
        {
            if(this.Head==null)
            {
                throw new InvalidOperationException("The linked list is empty.");
            }
            this.Head=this.Head.Next;
            this.Count--;
        }
        public void RemoveLast()
        {
            if (this.Head == null)
            {
                throw new InvalidOperationException("The linked list is empty.");
            }

            if (this.Head.Next == null)
            {
                this.Head = null;
            }
            else
            {
                for (Node node = this.Head; node != null; node = node.Next)
                {
                    if(node.Next.Next==null)
                    {
                        node.Next = null;
                    }
                }
            }
            this.Count--;
        }
        public string GetValue(ulong index)
        {
            if (this.Head == null)
            {
                throw new InvalidOperationException("The linked list is empty.");
            }
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("Index is not valid");
            }
            Node node= this.Head;
            for(ulong i = 0;i < index; i++)
            {
                node= node.Next;
            }
            return node.Value;
        }
    }
}
