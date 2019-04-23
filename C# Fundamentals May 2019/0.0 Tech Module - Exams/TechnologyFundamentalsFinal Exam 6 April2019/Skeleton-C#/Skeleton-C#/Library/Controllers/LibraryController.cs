using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new BookDbContext())
            {
                var books = db.Books.ToList();
                return this.View(books);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (string.IsNullOrEmpty(book.Title))
            {
                return RedirectToAction("Index");
            }

            using (var db = new BookDbContext())
            {
                Book newBook = new Book()
                {
                    Id = book.Id,
                    Author = book.Author,
                    Price = book.Price,
                    Title = book.Title
                };
                db.Books.Add(newBook);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BookDbContext())
            {
                var bookEdit = db.Books.Find(id);

                return this.View(bookEdit);
            }
            
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            using (var db = new BookDbContext())
            {
                var books = db.Books.Update(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BookDbContext())
            {
                var bookEdit = db.Books.Find(id);

                return this.View(bookEdit);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new BookDbContext())
            {
                var books = db.Books.Remove(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}