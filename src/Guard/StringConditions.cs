using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancsCoder.Guard
{
    public partial class StringConditions : Conditions<string>
    {
        public StringConditions(string objectUnderTest)
            : base (objectUnderTest)
        {
        }
    }
}
