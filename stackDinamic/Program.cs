using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            DinElement a = new DinElement(3);
            Console.WriteLine(a);

            DinElement b = new DinElement();
            b.Value = 45;
            Console.WriteLine(b);

            DinStack st = new DinStack();
            st.Push(3);
            st.Push(5);
            st.Push(1);

            Console.WriteLine(st);

            Console.WriteLine(st.Peek());
        }
    }
}
