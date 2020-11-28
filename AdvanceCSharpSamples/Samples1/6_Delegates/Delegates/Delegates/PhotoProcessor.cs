using System;

namespace Delegates
{
    //public class PhotoProcessor
    //{
    //    public delegate void PhotoFilterHandler(Photo photo);
    //    public void Process(string path, PhotoFilterHandler filterHandler)
    //    {
    //        //System.Action<> //void dönen delegate için
    //        //System.Func<>  //değer dönen delegate için

    //        var photo = Photo.Load(path);

    //        filterHandler(photo);

    //        //var filters = new PhotoFilters();
    //        //filters.ApplyBrightness(photo);
    //        //filters.ApplyContrast(photo);
    //        //filters.Resize(photo);

    //        photo.Save();
    //    }
    //}


    public class PhotoProcessor
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            //System.Action<> //void dönen delegate için
            //System.Func<>  //değer dönen delegate için

            var photo = Photo.Load(path);

            filterHandler(photo);

            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            photo.Save();
        }
    }
}
