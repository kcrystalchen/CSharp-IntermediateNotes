using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAStack
{



    public class Stack
    {

        private readonly List<object> _list = new List<Object>();  // readonly because we do not want to reinitalize the List anywhere else in this class  

        public void Push(Object obj)  // stores the given object on top of the stack
        {
            if(obj == null)  // should not save null in the stack
            {
                throw new InvalidOperationException("You can not add a Null object to the stack ");
            } else
            {
                _list.Add(obj); // Add the object to the end of list
               
            }
        }

        public Object Pop() // remove the object on top of the stack and returns it
        {
            if(_list.Count() == 0)
            {
                throw new InvalidOperationException("You can not pop the stack with no value in there");
            } 

                _list.RemoveAt(_list.Count - 1); // remove the last item in the list 
                return _list[_list.Count - 1];
        }

        public void Clear() // removes all the objects from the stack
        {
            _list.Clear();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Clear();
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop());
     

        }
    }
}
