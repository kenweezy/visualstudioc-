using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class oop
    {
        public oop() {

            Console.WriteLine("the constructor");
        }

        double length;
        double width;

        public void initialise() {
            length = 30;
            width = 20;
        }

        public double getarea() {
            return length * width;


        }
        public void display() {

            Console.WriteLine("the length is: {0}", length);
            Console.WriteLine("the width id: {0}", width);
            Console.WriteLine("the area is {0}", getarea());
            Console.ReadLine();
        }
        public void getuserdata() {

            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x is {0}, and y is {1}", x, y);
            Console.ReadKey();

        }

       /* public static void Main(string[] args) {

            oop x = new oop();
            x.initialise();

            x.display();
            x.getuserdata();


        }*/
    }
}
