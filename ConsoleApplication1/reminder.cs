using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class reminder
    {
        private double length;
        private double width;
        private double area;

        public reminder() {
            Console.WriteLine("constructor");
        }
        ~reminder() {
            Console.WriteLine("destructor");
        }
        public void setWidth(double w) {

            width = w;
        }
        public void setLength(double l)
        {

            length = l;
        }

        public double getLength() {

            return length;
        }

        public double getWidth() {
            return width;
        }

        public double getArea() {

            area = length * width;
            return area;
        }

    }

    class factorial {

        public double fact(int x) {

            if (x == 1 || x == 0)
            {

                return 1;
            }
            else {

                return fact(x - 1) * x;
            }
        }


    }

    class exceptiontest {

        public void division(int x,int y) {
            int result = 0; 

            try
            {

                 result = x / y;
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine("error occured {0}", e);
            }
            finally {

                Console.WriteLine("the answer is {0}", result);
            }

           
        }


    }

    class execute {

        static void Main(string[] args) {

            reminder r = new reminder();
            exceptiontest et = new exceptiontest();
            double l, w;
            Console.WriteLine("enter the height");
            l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the width");
            w = Convert.ToDouble(Console.ReadLine());
            r.setLength(l);
            r.setWidth(w);
            Console.WriteLine("the area is {0}",r.getArea());

            factorial f = new factorial();
            int x;
            Console.WriteLine("enter the value you want to find its factorial");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("factorial of {0} is {1}", x,f.fact(x));

            et.division(4,3);
            Console.ReadKey();


        }


    }
}
