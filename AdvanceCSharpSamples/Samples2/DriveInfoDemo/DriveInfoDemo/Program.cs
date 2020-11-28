using System;
using System.IO;

namespace DriveInfoDemo {
    class Program {
        static void Main(string[] args) {
            foreach (var driveInfo in DriveInfo.GetDrives()) {
                Console.WriteLine("----------------------------------");

                Console.WriteLine("DriveType: " + driveInfo.DriveType);

                if (driveInfo.IsReady) {
                    Console.WriteLine("Name:" + driveInfo.Name);
                    Console.WriteLine("RootDirectory: " + driveInfo.RootDirectory);
                    Console.WriteLine("TotalFreeSpace: " + (driveInfo.TotalFreeSpace/1024/1024/1024) + "GB");
                }
            }

            Console.ReadKey();
        }
    }
}
