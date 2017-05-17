using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boc.Tests.Models
{
    class EquatableComplexModel : IEquatable<EquatableComplexModel>, IEquatable<object>
    {
        public int IntProp { get; set; }

        public bool Equals(EquatableComplexModel other)
        {
            if (other == null)
                return false;

            return IntProp.Equals(other.IntProp);
        }
    }
}
