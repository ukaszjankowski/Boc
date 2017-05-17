namespace Boc.Tests.Examples
{
    using Boc.Tests.Models;
    using Xunit;

    public class Examples
    {
        [Fact]
        public void Example1()
        {
            //arrange
            var bocModel = new BocModel<SimpleModel>();

            bocModel
                .Bind(sm => sm.IntProperty)
                .As("bv1");

            bocModel
               .Bind(sm => sm.StringProperty)
               .As("bv2");

            var s1 = new SimpleModel { IntProperty = 2, StringProperty = "Example1" };
            var s2 = new SimpleModel { IntProperty = 3, StringProperty = "Example11" };

            //act

            var result = bocModel.Compare(s1, s2);

            //assert
            Assert.Equal(2, result.Count); //result.Count == 2
        }
    }
}