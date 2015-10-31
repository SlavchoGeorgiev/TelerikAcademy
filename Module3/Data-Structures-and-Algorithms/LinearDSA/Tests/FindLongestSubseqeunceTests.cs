namespace Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindLongestSubseqeunceTests
    {
        [TestMethod]
        public void FindLongestSubseqeunceWithValidValuesShouldWorksCorrect()
        {
            // Arrange
            var testList = new List<int>() { 6, 4, 4, 3, 3, 3, 3, 3, 6, 6, 6, 6, 6, 6, 8, 8 };
            var expected = new List<int>() { 6, 6, 6, 6, 6, 6 };

            // Act
            var actual = _04.LongestSubsequence.Startup.FindLongestSubseqeunce(testList);

            // Assert
            Assert.AreEqual(actual.Count, expected.Count);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FindLongestSubseqeunceWithNullValueShouldThrow()
        {
            _04.LongestSubsequence.Startup.FindLongestSubseqeunce(null);
        }
    }
}
