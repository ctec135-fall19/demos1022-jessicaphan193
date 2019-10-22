using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Parent
    {
        //show that a method belonging to the base class is called from a
        //child instance
        public void ParentMethod();
        {
            Console.WriteLine("Parent Method");
        }

    //Demonstrate overriding a base class method by a class
    public virtual void SomeMethod();
    {
       Console.Writeline("Parent's SomeMethod");
    }

    }
}
