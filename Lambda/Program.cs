using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Books;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> list = BooksDB.BooksGenerator();

            ////Ordenados por precio
            List<Book> listOrdered = list.OrderBy(x => x.price).ToList();
            Console.WriteLine("Libros ordenados por precio");
            WriteList(listOrdered);

            ////Libros con año menor al 2000
            //List<Book> listYear2000 = list.Where(x => x.time.Year < 2000).OrderBy(x => x.time).ToList();
            //Console.WriteLine("Libros con año menor que el 2000");
            //WriteList(listYear2000);

            ////Libro más antiguo y menor del 2000
            //Book bookYearFirst = list.Where(x => x.time.Year < 2000).OrderBy(x => x.time).First();
            //Console.WriteLine("Libro más antiguo");
            //Console.WriteLine(bookYearFirst);
            //Console.ReadLine();

            ////Coger los 4 primeros resultados de la lista
            //List<Book> listFirstTwo = list.Where(x => x.time.Year > 2000).OrderByDescending(x => x.time).Take(2).ToList();
            //Console.WriteLine("Los dos libros más nuevos");
            //WriteList(listFirstTwo);

            ////Descartar los 3 libros más antiguos
            //List<Book> listRemoveThree = list.OrderBy(x => x.time).Skip(3).ToList();
            //Console.WriteLine("Eliminando los 3 libros más antiguos");
            //WriteList(listRemoveThree);

            //El más caro de todos
            //Book bookMoreExpensive = list.Max();
            //Console.WriteLine("Libro más caro");
            //Console.WriteLine(bookMoreExpensive);
            //Console.ReadLine();

            ////El más barato de todos
            //Book bookCheaper = list.Min();
            //Console.WriteLine("Libro más barato");
            //Console.WriteLine(bookCheaper);
            //Console.ReadLine();

            //Comparar si existe un libro
           // AuthorsChecker(list);
            
            //Suma de precios de los libros

            int Addition = list.Sum(x => x.price);
            Console.WriteLine("Suma de los precios de todos los libros");
            Console.WriteLine(Addition);
            Console.ReadLine();

            double average = list.Average(x => x.price);
            
            Console.WriteLine("Media de los precios de los libros");
            Console.WriteLine(average.ToString("0.##"));
            Console.ReadLine();
          



            //Book firstBook = list.First();
            //Book lastBook = list.Last();

            //int result = firstBook.CompareTo(lastBook);
            //El más barato de todos
        }

        private static void AuthorsChecker(List<Book> list)
        {
            string input = Console.ReadLine();
            if (input == "exit")
                return;

            bool exists = list.Any(x => x.author.ToUpper() == input.ToUpper());
            Console.WriteLine(exists);

            AuthorsChecker(list);
        }

        public static void WriteList(List<Book> list)
        {
            foreach (Book item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
