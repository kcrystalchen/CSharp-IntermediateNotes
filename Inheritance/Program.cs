using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object called text, instance of Text class
            Text text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}
