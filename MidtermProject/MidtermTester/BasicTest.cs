using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MidtermProject;

namespace MidtermTester
{
    class BasicTest
    {
        //  Create a functional test for each of the previous 3 functions
        // MidtermBasicFunctions.cs 

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
