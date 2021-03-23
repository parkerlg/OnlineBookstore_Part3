using System;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookstore.Models
{
    public class BookstoreDBContext : DbContext
    {
        public BookstoreDBContext(DbContextOptions<BookstoreDBContext> options):base (options)
        {

        }
		public BookstoreDBContext() //Add this change
		{

		}

		public static BookstoreDBContext Create() //Add this change
		{
			return new BookstoreDBContext();
		}

		public DbSet<Book> Books { get; set; }
    }
}
