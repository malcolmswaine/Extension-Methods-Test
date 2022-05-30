using ATEA_Test.Infrastructure;
using System;
using Xunit;

namespace ATEA_Test_Unit
{
    public class UnitTest1
    {

        [Fact]
        public void Input2Strings_Expect_StringsToBeConcatenated()
        {
            var expected = "hello there";
            var newString = "hello".AppendString(" there");
            Assert.Equal(newString, expected);
        }


        [Fact]
        public void Input1StringAndOneNullString_Expect_ExceptiontoBeThrown()
        {
            Assert.Throws<ArgumentNullException>(() => "hello".AppendString(null));
        }
    }
}