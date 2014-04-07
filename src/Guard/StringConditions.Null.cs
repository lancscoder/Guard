using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancsCoder.Guard
{
    public partial class StringConditions : Conditions<string>
    {
        public StringConditions IsNotNullOrEmptyWhiteSpace()
        {
            if (String.IsNullOrWhiteSpace(_objectUnderTest))
            {
                throw new NullReferenceException();
            }

            return this;
        }
    }
}
