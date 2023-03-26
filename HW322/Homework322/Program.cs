using Homework322.Models;


//Book book = new Book();
//{
//    book.Title = "Madam Bovary";
//    book.Author = "Gustave Flaubert";

//};

BookDataContext database = new BookDataContext();
//database.Books.Add(book);
//database.SaveChanges();



//List<Book> books = database.Books.ToList();

//foreach (Book book in books)
//{
//    Console.WriteLine($"Title : {book.Title} Author : {book.Author}");
//}


//var book = database.Books.Where(a => a.Id == 2).FirstOrDefault();
//if (book != null)
//{
//    Console.WriteLine($"Title : {book.Title} Author : {book.Author}");
//}
//else
//{
//    Console.WriteLine("not found!");
//}


var book = database.Books.Where(n => n.Author == "Gustave Flaubert").FirstOrDefault();
book.Author = "Furkan Bayazit";
database.SaveChanges();