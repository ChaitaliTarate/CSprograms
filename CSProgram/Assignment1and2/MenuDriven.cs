using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class MenuDriven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice!!! 1.Area of Circle 2.Area of Right Angle traingle 3.Area of rectangle 4.circumfereance of circle 5.perimeter of square");
            int ch = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the radius");
            int rad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the side");
            int side = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width");
            int w = Convert.ToInt32(Console.ReadLine());

            float pi = 3.14f;
        
        switch(ch)
            {
                case 1:
                    Console.WriteLine("Area of Circle is:"+(float)(pi*rad*rad));
                    break;


                case 2:
                    Console.WriteLine("Area of Right Angle Traingle is:" + (float)(1/2*l*h));
                    break;

                case 3:
                    Console.WriteLine("Area of Rectangle:" + (float)(w * h));
                    break;

                case 4:
                    Console.WriteLine("circumference of circle:" + (float)(2*pi*rad));
                    break;

                case 5:
                    Console.WriteLine("perimeter of square:" + (float)(4*side));
                    break;

            }
        }
    }
}
