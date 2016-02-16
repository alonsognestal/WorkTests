using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Books
{
    public static class BooksDB
    {
        public static List<Book> BooksGenerator()
        {
            var result = new List<Book>();
            result.Add(new Book("Quijote", new DateTime(2016,02,18), "Paco", 1));
            result.Add(new Book("La Dama", new DateTime(2015, 12, 31),"Juan", 40));
            result.Add(new Book("Toy Story", new DateTime(2014, 05, 10), "Alberto", 10));
            result.Add(new Book("La Celestina", new DateTime(1994, 09, 03), "Juanma el Killer", 11));
            result.Add(new Book("La Biblia", new DateTime(1956, 10, 13), "Juanjo", 25));
            result.Add(new Book("Alma", new DateTime(2002, 02, 18), "Miguel Ángel", 60));
            result.Add(new Book("El Principito", new DateTime(1988, 11, 30), "Alonso", 5));
            return result;

        }
    }
}
