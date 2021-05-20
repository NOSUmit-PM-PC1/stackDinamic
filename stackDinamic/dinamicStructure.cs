using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackDinamic
{
    class DinElement
    {
        int val;
        DinElement adr;

        public int Value 
        {
            get { return val;}
            set { val = value; }
            //set { }
        }

        internal DinElement Adress
        {
            get { return adr; }
            set { adr = value; }
        }

        public DinElement(int a)
        {
            val = a;
            adr = null;
        }

        public DinElement()
        {
            val = 0;
            adr = null;
        }

        public override string ToString()
        {
            return "value = " + val;
        }
    }

    class DinStack
    {
        DinElement top = null;

        public void Push(int value)
        {
            DinElement el = new DinElement(value);
            el.Adress = top;
            top = el;
        }

        public override string ToString()
        {
            string s = "";
            DinElement temp = top;
            while (temp != null)
            {
                s += temp.Value + " ";
                temp = temp.Adress;
            }
            return s;
            //top.Value + " " + top.Adress.Value + " " + top.Adress.Adress.Value;
        }

        public bool isEmpty()
        {
            return top == null;
        }

        public int Peek()
        {
            if (isEmpty())
            {
                throw new Exception("Стек пустой!");
            }
            else
            {
                return top.Value;
            }
        }

        public int Pop()
        {
            if (isEmpty())
            {
                throw new Exception("Стек пустой!");
            }
            else
            {
                int temp = top.Value;
                top = top.Adress;
                return temp;
            }
        }
    }
}
