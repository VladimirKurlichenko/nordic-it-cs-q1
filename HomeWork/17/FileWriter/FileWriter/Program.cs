using System;

namespace FileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            byte[] bytes = { 5, 25, 0, 25, 5, 5, 5, 5, 5, 5};
            var file_1 = new FileWriterWithProgress();

            file_1.EventWritingPerformed += File1_EventWritingPerformed;
            file_1.EventWritingCompleted += Fff_EventWritingCompleted;

            file_1.WriteBytes("lol", bytes, (float)0.15);

            Console.ReadKey();
        }

        private static void Fff_EventWritingCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Data recorded.");
        }
        private static void File1_EventWritingPerformed(object sender, WritingPerformed e)
        {
            Console.WriteLine(String.Format("{0:0.##}", e.Percentage) + "%.");
        }
    }
}
