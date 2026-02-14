using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using System.Linq;
using Library_management_system.Models;

namespace LibraryManagementSystem.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _context;

        public BooksController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Books.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        public IActionResult Edit(int id)
        {
            var book = _context.Books.Find(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var book = _context.Books.Find(id);
            _context.Books.Remove(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Search(int id)
        {
            var book = _context.Books.Find(id);
            return View(book);

        public IActionResult Issue(int id)
        {
            var book = _context.Books.Find(id);
            book.IsIssued = true;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Return(int id)
        {
            var book = _context.Books.Find(id);
            book.IsIssued = false;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}


