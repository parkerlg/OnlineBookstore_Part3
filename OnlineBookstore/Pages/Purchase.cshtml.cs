using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineBookstore.Infrastructure;
using OnlineBookstore.Models;

namespace OnlineBookstore.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookstoreRepository repository;

        public PurchaseModel (IBookstoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        //public void OnGet(string returnUrl)
        //{
        //    ReturnUrl = returnUrl ?? "/";
        //    Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        //}

        //public IActionResult OnPost(long bookId, string returnUrl)
        //{
        //    Book book = repository.Books.FirstOrDefault(p => p.BookId == bookId);
        //    Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        //    Cart.AddItem(book, 1);
        //    HttpContext.Session.SetJson("cart", Cart);
        //    return RedirectToPage(new { returnUrl = returnUrl });
        //}
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books
                .FirstOrDefault(p => p.BookId == bookId);
            Cart.AddItem(book, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }


        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveItem(Cart.Lines.FirstOrDefault(cl =>
                cl.Book.BookId == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
