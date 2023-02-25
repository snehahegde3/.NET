using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    public enum Rating { Excellent, Good, Okay, Bad, Rubbish};
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DateOfPublication { get; set; }
        public Rating Rating { get; set; }



    }
    public static class BookData
    {
        public static IEnumerable<Book> Books = new Book[]
        {
            new () {Title = "Kafka on the shore", Author="Murakami", DateOfPublication = new DateTime(2015, 10, 10), Rating=Rating.Good},
            new () {Title = "The Bell Jar", Author="Silvia Plath", DateOfPublication=new DateTime(2016, 12, 5), Rating=Rating.Okay},
        };
     }
}
