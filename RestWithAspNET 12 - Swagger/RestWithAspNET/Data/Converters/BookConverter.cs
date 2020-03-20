using RestWithAspNET.Data.Converter;
using RestWithAspNET.Data.VO;
using RestWithAspNET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspNET.Data.Converters
{
    public class BookConverter : IParse<BookVO, Book>, IParse<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null)
                return new Book();
            return new Book
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate
            };
        }

        public BookVO Parse(Book origin)
        {
            if (origin == null)
                return new BookVO();
            return new BookVO
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate
            };
        }

        public List<Book> ParseList(List<BookVO> origin)
        {
            if (origin == null)
                return new List<Book>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<BookVO> ParseList(List<Book> origin)
        {
            if (origin == null)
                return new List<BookVO>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
