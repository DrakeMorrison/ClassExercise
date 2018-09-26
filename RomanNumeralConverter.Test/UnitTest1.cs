using System;
using System.Collections.Generic;
using Xunit;
using RomanNumeralConverter;

namespace RomanNumeralConverter.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(9, "IV")]
        [InlineData(12, "XII")]
        [InlineData(16, "XVI")]
        [InlineData(29, "XXIX")]
        public void convert_a_number_to_a_roman_numeral(int input, string expectedResult)
        {
            //Arrange       
            var converter = new RomanConverter();
            //Act
            var result = converter.IntToRoman(input);
            //Assert
            Assert.Equal(result, expectedResult);
        }
    }
}
