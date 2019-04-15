using OpenCvSharp;
using System;

namespace OpenCV_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mat m = new Mat(@"C:\Users\Administrator\Desktop\头像\a.jpg", ImreadModes.Color);
            Cv2.ImShow("Demo",m);
            Cv2.WaitKey(0);
            Console.ReadKey();
        }
    }
}
