using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class DeepFormatter
    {
        public static SelectList FormatGenres()
        {
            return new SelectList(MidtermBasicFunctions.GetAllGenres()
            .OrderBy(genre => genre.GenreType)
            .ToDictionary(genre => genre.GenreId, genre => genre.GenreType), "Key", "Value");
        }

        public static SelectList FormatAuthors()
        {
            return new SelectList(MidtermBasicFunctions.GetAllAuthors()
            .OrderBy(author => author.AuthorLast)
            .ToDictionary(author => author.AuthorId, author => author.AuthorLast + ", " + author.AuthorFirst), "Key", "Value");
        }
    }
}
