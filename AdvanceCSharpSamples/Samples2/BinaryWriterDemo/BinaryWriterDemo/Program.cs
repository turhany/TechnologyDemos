using System;
using System.IO;

namespace BinaryWriterDemo {
    class Program {
        static void Main(string[] args) {

            BinaryWriter bw = null;
            BinaryReader br;

            try {
                //bw = new BinaryWriter(new FileStream("C:\\vidobu\\data", FileMode.OpenOrCreate));

                //bw.Write("BinaryWriter ile yazılan data \n");
                //bw.Write(DateTime.Now.ToString());

                br = new BinaryReader(new FileStream("C:\\vidobu\\data", FileMode.Open));

                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadString());                
            }
            catch (Exception ex) {

                throw ex;
            }
            finally {
                if (bw != null) {
                    bw.Close();
                    bw.Dispose();
                }
            }

            Console.ReadKey();
        }
    }
}
