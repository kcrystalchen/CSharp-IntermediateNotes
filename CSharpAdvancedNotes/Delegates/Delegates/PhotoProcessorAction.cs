using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
   
    class PhotoProcessorAction
    {
        // this class is using system Action<>, it does not return anything
        // system Func<> returning something 

        public void Process(string path, Action<Photo> photoFilterHandler)
        {
            Photo photo = Photo.Load(path);
            photoFilterHandler(photo);
            photo.Save();
        }

    }
}
