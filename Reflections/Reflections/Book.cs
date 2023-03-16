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
        [ReportItem(1)]
        public string Title { get; set; }
        [ReportItem(2)]
        public string Author { get; set; }
        [ReportItem(3, Heading = "Date of Publication", Format = "dd-MM-yyyy") ]
        public DateTime DateOfPublication { get; set; }
        [ReportItem(4)]
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
