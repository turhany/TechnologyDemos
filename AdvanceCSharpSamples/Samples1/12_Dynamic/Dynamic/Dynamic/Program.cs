namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";

            //obj.GetHashCode();
            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            //object excelObject = "mosh";
            dynamic excelObject = "mosh"; //dlr
            excelObject.Optimize(); //Optimize diye bir method yok


            dynamic name = "Mosh";
            //name++; //RuntimeBinderException > tip daha int dönüşmeden string iken int methodu kullanmay açalışınca oldu
            name = 10;

            dynamic a = 10;
            dynamic b = 10;
            var c = a + b; //c otomatik olarak dynamic tipinde oldu

            int i = 5;
            dynamic d = i;
            long l = d;

        }
    }
}
