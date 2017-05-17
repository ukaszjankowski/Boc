namespace Boc.Tests.Models
{
    using System.Collections.Generic;

    internal class ComplexModel
    {
        public int IntProp { get; set; }
        public string StringProp { get; set; }
        public SimpleModel SimpleModelProp { get; set; }
        public SimpleModel AnotherOneSimpleModelProp { get; set; }
        public List<int> ListOfIntegers { get; set; }
        public List<SimpleModel> ListOfSimpleModelObjects { get; set; }
    }
}