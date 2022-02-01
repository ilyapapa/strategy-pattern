using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laborator1;

namespace WoundedDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            RedheadDuck rDuck = new RedheadDuck();
            MallardDuck mDuck = new MallardDuck();

            Duck[] duck = { rDuck, mDuck };

            foreach (Duck Duck in duck)
            {
                Console.WriteLine(Duck.display());
                Console.WriteLine(Duck.quack());
                Console.WriteLine(Duck.swim());
            }

            Console.ReadKey();
        }
    }
}
