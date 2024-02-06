using MidtermProject;
using System;
using System.Linq;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {

        [Fact]
        public void SearchByTitle()
        {
            var result = MidtermBasicFunctions.GetBookByTitle("");
            Assert.True(result.BookTitle == "");
        }

        [Fact]
        public void GetAllBooks()
        {
            var result = MidtermBasicFunctions.GetAllBooks();
            Assert.True(result.Count >= 1);
        }

        [Fact]
        public void SesarchByLN()
        {
            var result = MidtermBasicFunctions.GetByLN("");
            Assert.True(result.All(m => m.Author.AuthorLast == ""));
        }
    }
}
