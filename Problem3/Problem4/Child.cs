using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Child : Parent
    {
        public override void SomeMethod();
    {
       Console.Writeline()
    }

    public override void Method2()
    {
        base.Method2();
        Console.WriteLine("Child.Method2");
    }
}
}
