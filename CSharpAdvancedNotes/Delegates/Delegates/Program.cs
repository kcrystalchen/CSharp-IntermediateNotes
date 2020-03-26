using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        // design a framework to process the photos
        static void Main(string[] args)
        {
            
            PhotoProcess photoProcess = new PhotoProcess();

            PhotoFilters photoFilters = new PhotoFilters();

            PhotoProcess.PhotoFilterHandler photoFilterHandler0 = photoFilters.ApplyBrightness;
            photoFilterHandler0 += photoFilters.ApplyContrast;
            photoFilterHandler0 += photoFilters.Resize;
            photoFilterHandler0 += RemoveRedEyeFilter; 

            photoProcess.Process("Process Path.jpg", photoFilterHandler0);



            PhotoProcessorAction photoProcessorAction = new PhotoProcessorAction();

            Action<Photo> photoFilterHandler = photoFilters.ApplyContrast;

        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            // Create a filter that is not releasing from the framework

           Console.WriteLine("Apply Remove RedEye");
        }

    }
}
