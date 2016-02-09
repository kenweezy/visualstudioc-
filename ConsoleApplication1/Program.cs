using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;

namespace ConsoleApplication1
{
    class Program
    {

        public Program() {

            Console.WriteLine("these is the construcctor");
        }
         ~Program() {

            Console.WriteLine("these is the destructor");
            Console.ReadKey();

        }

        public void displayMessage() {

            Console.WriteLine("hello world");
            Console.ReadKey();
        }
       /* static void Main(string[] args)
        {

            Program p = new Program();
            oop op = new oop();

            p.displayMessage();
            op.initialise();
            op.getarea();
            op.display();
            op.getuserdata();
        }
        */
    }
}
