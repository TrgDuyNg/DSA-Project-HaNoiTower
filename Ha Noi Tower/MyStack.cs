using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ha_Noi_Tower
{
    class Node
    {
        public PictureBox picdata;
        public Node Next;

        public Node(PictureBox picdata)
        {
            this.picdata = picdata;
            Next = null;
        }
    }

    class MyStack
    {
        private Node top;
        public int Count { get; private set; }

        public MyStack()
        {
            top = null;
            Count = 0;
        }

        public void Push(PictureBox picdata)
        {
            Node newNode = new Node(picdata);
            newNode.Next = top;
            top = newNode;
            Count++;
        }

        public PictureBox Pop()
        {
            if (top == null)
            {
                MessageBox.Show("Stack rỗng, không thể lấy phần tử");
                return null;
            }

            PictureBox picdata = top.picdata;
            top = top.Next;
            Count--;
            return picdata;
        }

        public PictureBox Peek()
        {
            if (top == null)
            {
                MessageBox.Show("Stack rỗng, không có phần tử để xem");
                return null;
            }

            return top.picdata;
        }

        public void Clear()
        {
            while (!IsEmpty())
            {
                Pop();
            }
        }

        public bool Contains(PictureBox picdata)
        {
            Node current = top;
            while (current != null)
            {
                if (current.picdata == picdata)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
