using System;
using LinqToExcel;
using System.Linq;

namespace LinqToExcelSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToExcelFile = @"C:\Users\turhany-pc\Desktop\Junk\LinqToExcelSample\LinqToExcelSample\Sample.xlsx";

            string sheetName = "Sheet1";

            var excelFile = new ExcelQueryFactory(pathToExcelFile);
            var excelData = from item in excelFile.Worksheet<EmployeeDetail>(sheetName) select item;
            
            foreach (var currentItem in excelData)
            {
                Console.WriteLine(currentItem);
            }
        }
    }

    public class EmployeeDetail
    {
        public int EmployeeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string PostelCode { get; set; }
        public string Email { get; set; }
    }
}
