using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndMembers
{



    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            circle.Draw();
            circle.Copy();
            circle.Select();
            rectangle.Draw();
            rectangle.Copy();
            
        }
    }
}
