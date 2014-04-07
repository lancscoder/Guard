using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancsCoder.Guard
{
    public partial class Conditions<TObjectUnderTest>
    {
        internal readonly TObjectUnderTest _objectUnderTest;

        public Conditions(TObjectUnderTest objectUnderTest)
        {
            _objectUnderTest = objectUnderTest;
        }
    }
}
