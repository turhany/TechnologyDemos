using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<DateTime> date = null;
            //DateTime? date = null;

            //Console.WriteLine("GetValueOrDefault :" + date.GetValueOrDefault());
            //Console.WriteLine("HasValue :" + date.HasValue);
            //Console.WriteLine("Value :" + date.Value);

            //Console.ReadLine();


            //DateTime? date = new DateTime(2014,1,1);
            //DateTime date2 = date.GetValueOrDefault();
            //DateTime? date3 = date2;

            //Console.WriteLine(date3);

            //Console.ReadLine();

            //Null Coalescing Operator
            DateTime? date = null;

            //DateTime date2;
            //if (date != null)
            //    date2 = date.GetValueOrDefault();
            //else
            //    date2 = DateTime.Today;

            //DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            DateTime date2 = date ?? DateTime.Today;

            Console.WriteLine(date2);

            Console.ReadLine();
        }
    }
}
