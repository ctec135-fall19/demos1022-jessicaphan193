using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class GrandChild : Child
    {
        public override void SomeMethod();
    {
       Console.WriteLine{"GrandChild's SomeMethod");
    }

    public override void Method2()
    {
        base.Method2();
        Console.WriteLine("GrandChild.Method2");
    }

    public void SpecializedMethod()
    {
        Console.WriteLine("SpecializedMethod");
    }
}
}
