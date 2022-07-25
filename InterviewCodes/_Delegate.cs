using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodes
{
    class _Delegate
    {
        public _Delegate()
        {

        }

        /**
         * A delegate is a reference type which holds reference to a method.
         * Mostly used in designing frameworks.
         */

        //delegate - type - delegateName (params)
        delegate void Mydelegate(int a); //declaration

        public void Start()
        {
            //as long as a method match the return type and parameters of a delegate, we can make a reference to it.
            Mydelegate _mydelegate = Foo;
            _mydelegate.Invoke(5);

        }


        //delegate pattern match - return type + parameters
        public void Foo(int a)
        {
            Console.WriteLine(a);
        }

        //delegate pattern match - return type + parameters
        void Bar(int a)
        {
            //do something
        }

    }

    /**
     * Let's consider we are developing a image processing framework using the code below
     * What if some other developer wants to use this  framework and add another filter?
     * In such case we need to add that filter manually in PhotoFilters class and
     * rebuild our framework.
     *
     * See main function how we created a new filter without  modifying this one.
     * 
     */

    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {

        }
    }

    public class PhotoProcessor
    {
        /**
         * So, to solve this problem we create a delegate. 
         */
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path)
        {
            var photo = Photo.Load(path);

            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }

        //instead of above method, we use the below.
        public void Process(string path, PhotoFilterHandler handler)
        {
            var photo = Photo.Load(path);
            handler(photo);
        }
    }

    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply Contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Photo resized");
        }
    }
}
