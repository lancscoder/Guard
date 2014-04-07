using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancsCoder.Guard
{
    public class Guard
    {
        public static Conditions<TObjectUnderTest> For<TObjectUnderTest>(TObjectUnderTest objectUnderTest)
        {
            return new Conditions<TObjectUnderTest>(objectUnderTest);
        }

        public static StringConditions For(string objectUnderTest)
        {
            return new StringConditions(objectUnderTest);
        }
    }
}
