using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicStack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack<string> stack = new Stack<string>(8);
                for (int i = 1; i < 5; i++)
                {
                    stack.Push(i.ToString());
                }
                var head = stack.Pop();
                Console.WriteLine("The last item before extraction is " + head);
                head = stack.Peek();
                Console.WriteLine("The last item after extraction is " + head);
                for (int i = 4; i < 9; i++)
                {
                    stack.Push(i.ToString());
                }
                head = stack.Peek();
                Console.WriteLine("The new last item is " + head);
                stack.Push("9");
                head = stack.Peek();
                Console.WriteLine("The lastest item is " + head);
                stack.Clear();
                head = stack.Peek();
                Console.WriteLine("The lastest item after clear() is " + head + " or null");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
