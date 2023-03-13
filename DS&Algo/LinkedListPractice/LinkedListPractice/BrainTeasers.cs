using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    public class BrainTeasers
    {
        class Base
        {
            public virtual void Foo(int x)
            {
                Console.WriteLine("Base.Foo(int)");
            }
        }

        class Derived : Base
        {
            public override void Foo(int x)
            {
                Console.WriteLine("Derived.Foo(int)");
            }

            public void Foo(object o)
            {
                Console.WriteLine("Derived.Foo(object)");
            }
        }

        class Test
        {
            static void Method()
            {
                Derived d = new Derived();
                int i = 10;
                d.Foo(i);

                //Output will be Derived.Foo(object) as it will always choose the compatible method in case of overloading even if overriding is done.
            }
        }
    }
}
