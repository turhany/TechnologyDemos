using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new PhotoProcessor();

            //process.Process("photo.jpg");

            var filters = new PhotoFilters();
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            System.Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            process.Process("photo.jpg",filterHandler);

            Console.ReadLine();

        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("RemoveRedEyeFilter");
        }
    }
}
