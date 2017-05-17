namespace Boc.Tests
{
    using Boc.Tests.Models;
    using Xunit;

    public class ModelBindingTests
    {
        [Fact]
        public void ToProperty_GivenFuncWithValueType_ReturnsNewBinding()
        {
            //arrange
            var sut = new BocModel<SimpleModel>();

            //act
            var result = sut.Bind(o => o.IntProperty).As(1);

            //assert
            Assert.NotNull(result);
        }

        [Fact]
        public void ToProperty_GivenEquatableComplexType_ReturnsNewBinding()
        {
            //arrange
            var sut = new BocModel<EquatableComplexModel>();

            //act
            var result = sut.Bind(o => { return o; }).As("key");

            //assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Compare_ReturnsEmptyCollection_OnTwoObjectWithEqualsBV1()
        {
            //arrange
            var sut = new BocModel<SimpleModel>();

            sut.Bind(sm => sm.IntProperty).As(1);

            var s1 = new SimpleModel { IntProperty = 1 };
            var s2 = new SimpleModel { IntProperty = 1 };

            //act

            var result = sut.Compare(s1, s2);

            //assert
            Assert.Empty(result);
        }

        [Fact]
        public void Compare_ReturnsEmptyCollection_OnTwoObjectWithEqualsBV2()
        {
            //arrange
            var sut = new BocModel<SimpleModel>();

            sut.Bind(sm => sm.IntProperty).As(1);

            var s1 = new SimpleModel { IntProperty = 1, StringProperty = "abc" };
            var s2 = new SimpleModel { IntProperty = 1, StringProperty = "def" };

            //act

            var result = sut.Compare(s1, s2);

            //assert
            Assert.Empty(result);
        }
    }
}