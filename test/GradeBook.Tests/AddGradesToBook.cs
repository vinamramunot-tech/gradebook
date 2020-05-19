using System;
using Xunit;

namespace GradeBook.Tests
{
    public class AddGradesToBook
    {
        // Fact is an attribute
        [Fact]
        public void AddGradeOverLimitTest()
        {
            // arrange
            var book1 = new Book("Adding Book Test");
            book1.AddGrade(105.5);

            Assert.Single(book1._grades);
        }
    }
}
