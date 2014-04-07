using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancsCoder.Guard
{
    public partial class Conditions<TObjectUnderTest>
    {
        public Conditions<TObjectUnderTest> IsGreaterThan(IComparable<TObjectUnderTest> lowerLimit)
        {
            return Compare(() => lowerLimit.CompareTo(_objectUnderTest) < 0);
        }

        public Conditions<TObjectUnderTest> IsGreaterThanOrEqualTo(IComparable<TObjectUnderTest> lowerLimit)
        {
            return Compare(() => lowerLimit.CompareTo(_objectUnderTest) <= 0);
        }

        public Conditions<TObjectUnderTest> IsLessThan(IComparable<TObjectUnderTest> upperLimit)
        {
            return Compare(() => upperLimit.CompareTo(_objectUnderTest) > 0);
        }

        public Conditions<TObjectUnderTest> IsLessThanOrEqualTo(IComparable<TObjectUnderTest> upperLimit)
        {
            return Compare(() => upperLimit.CompareTo(_objectUnderTest) >= 0);
        }

        public Conditions<TObjectUnderTest> IsEqualTo(IComparable<TObjectUnderTest> limit)
        {
            return Compare(() => limit.CompareTo(_objectUnderTest) == 0);
        }

        public Conditions<TObjectUnderTest> IsNotEqualTo(IComparable<TObjectUnderTest> limit)
        {
            return Compare(() => limit.CompareTo(_objectUnderTest) != 0);
        }

        private Conditions<TObjectUnderTest> Compare(Func<bool> condictionToCheck)
        {
            if (condictionToCheck())
            {
                return this;
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}
