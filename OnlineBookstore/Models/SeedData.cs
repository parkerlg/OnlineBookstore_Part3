using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
namespace OnlineBookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookstoreDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDBContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        PageNumber = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        PageNumber = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        PageNumber = 832
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. Wright",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        PageNumber = 864
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-081297",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        PageNumber = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-1455586691",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        PageNumber = 288
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-145523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        PageNumber = 304
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-145523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        PageNumber = 240
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        PageNumber = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "Josn Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        PageNumber = 642
                    },

                     new Book
                     {
                         Title = "Atomic Habits",
                         Author = "James Clear",
                         Publisher = "Penguin Random House LLC",
                         ISBN = "9781847941831",
                         Classification = "Non-Fiction",
                         Category = "Self-Help",
                         Price = 12.99,
                         PageNumber = 320
                     },

                      new Book
                      {
                          Title = "Harry Potter and the Goblet of Fire",
                          Author = "JK Rowling",
                          Publisher = "Arthur A. Levine Books",
                          ISBN = "978-1338299175",
                          Classification = "Fiction",
                          Category = "Fantasy",
                          Price = 6.98,
                          PageNumber = 768
                      },

                      new Book
                      {
                          Title = "Millionare Next Door",
                          Author = "Thomas J. Stanley",
                          Publisher = "Taylor Trade Publishing",
                          ISBN = "978-1589795471",
                          Classification = "Non-Fiction",
                          Category = "Self-Help",
                          Price = 10.29,
                          PageNumber = 272
                      }

                    );
                context.SaveChanges();

            }
        }
    }
}
