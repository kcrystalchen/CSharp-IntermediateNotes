namespace Delegates
{
    public class PhotoProcess
    {
        // delegate is a pointer for the method
        public delegate void PhotoFilterHandler(Photo photo); // delegate method


        public void Process(string path, PhotoFilterHandler photofilterHandler0)
        {
            Photo photo = Photo.Load(path);  // invoke the Photo.Load method passed in path

            photofilterHandler0(photo);

            //PhotoFilters photoFilters = new PhotoFilters();
            //photoFilters.ApplyBrightness(photo);
            //photoFilters.ApplyContrast(photo);
            //photoFilters.Resize(photo);

            photo.Save();
             
        }
    }
}
