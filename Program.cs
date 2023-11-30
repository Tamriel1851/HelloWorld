using System.Drawing;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args) { }

        //{
        //   //Task 1.1
        //    internal class Program
        //    {
        //        public int index = 0;
        //        static void Main(string[] args)
        //        {
        //            Program listing1 = new Program();
        //            listing1.Method1();
        //            listing1.Method2();
        //        }




        //        void Method1()
        //        {
        //            Console.WriteLine($"Method {index} called!");
        //        }

        //        void Method2()
        //        {
        //            index = index + 1;
        //            Console.WriteLine($"Method {index} called!");
        //        }
        //    }
        //Task 1.2


        class Rectangle

        {
            float height = 5.5f;
            float width = 3.0f;

            float CalculateArea()
            {
                return height * width;
            }
        }
    }
}