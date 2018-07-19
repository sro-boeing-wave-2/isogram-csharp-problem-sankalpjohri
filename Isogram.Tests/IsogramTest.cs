using System;
using Xunit;

namespace Isogram.Tests
{
    public class IsogramTest
    {
        [Fact]
        public void TrueForEmptyString()
        {
            Check check = new Check();
            bool actual = check.CheckIsogram("");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void TrueForWordWithLowerCaseChars()
        {
            Check check = new Check();
            bool actual = check.CheckIsogram("isogram");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void FalseForWordWithLowerCaseCharacters()
        {
            Check check = new Check();
            bool actual = check.CheckIsogram("eleven");
            bool expected = false;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void TrueForLongWord()
        {
            Check check = new Check();
            bool actual = check.CheckIsogram("subdermatoglyphic");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void TrueForWordsInMixedCase()
        {
            Check check = new Check();
            bool actual = check.CheckIsogram("Alphabet");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void TrueForWordWithhyphen()
        {
            Check check = new Check();
            bool actual = check.CheckIsogram("thumbscrew-japingly");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void TrueForWordWithDuplicatedHyphen()
        {
            Check check = new Check();
            bool actual = check.CheckIsogram("six-year-old");
            bool expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void TrueForNameSeparatedBySpace()
        {
            Check check = new Check();
            bool actual = check.CheckIsogram("Rahul Verma");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
    }
}
