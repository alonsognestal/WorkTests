using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Books
{
    public class Book : IComparable
    {
        public string title { get; set; }
        public DateTime time { get; set; }
        public string author { get; set; }
        public int price { get; set; }
        
        public Book(string title, DateTime time, string author, int price)
        {
            this.title = title;
            this.time = time;
            this.author = author;
            this.price = price;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", title, time.ToShortDateString(), author, price.ToString());
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Book otherBook = obj as Book;
            if (otherBook != null)
                return this.price.CompareTo(otherBook.price);

            throw new ArgumentException("Object is not a Book");
        }
    }
   
}
