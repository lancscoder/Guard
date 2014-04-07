using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancsCoder.Guard
{
    public partial class Conditions<TObjectUnderTest>
    {
        public Conditions<TObjectUnderTest> IsNotNull()
        {
            if (_objectUnderTest == null)
            {
                throw new NullReferenceException();
            }

            return this;
        }
    }
}
