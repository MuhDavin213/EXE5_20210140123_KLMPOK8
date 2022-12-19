using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_5
{
    class Node
    {
        public Node Davin;
        public Node next;
        public Node Maka;
        public string element;

        public Node()
        {
            this.Davin = this.Maka = null;
        }
        public void insert(int element)
        {
            Node baru = new Node();
            if (this.Maka == null)
            {
                this.Davin = this.Maka = baru;
            }
            else
            {
                this.Maka.next = baru;
                this.Maka = baru;
            }
            Console.WriteLine("inserted", element);
        }
        public void delete()
        {
            if (this.Davin == null)
            {
                Console.WriteLine("queue empty");
                return;
            }
            Node temp = this.Davin;
            this.Davin = this.Davin.next;

            if(this.Davin == null)
            {
                this.Maka = null;
            }
            Console.WriteLine("item Deleted");
        }
        public void Display()
        {
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert Operations");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your Choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {

                    }
                }
            }
        }
    }
}
