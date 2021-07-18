using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCoding.Data.Wrapper;
using LearningCoding.Models;
using LearningCoding.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearningCoding.Controllers
{
    public class BookController : Controller
    {
        IRepositoryWrapper _repositoryWrapper;
        const int ITEMS_PER_PAGE = 10;
        
        [TempData]
        public string Message { get; set; }

        public BookController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IActionResult Index(int currentPage = 1)
        {
            return View(new BooksViewModel()
            {
                _pagingInfoModel = new PagingInfo()
                {
                    CurrentPage = currentPage,
                    ItemsPerPage = ITEMS_PER_PAGE,
                    TotalItems = _repositoryWrapper._repositoryBook.FindAll().Count()
                },
                _books = _repositoryWrapper._repositoryBook.FindAll().OrderBy(e => e.BookTitle).
                Skip(ITEMS_PER_PAGE * (currentPage - 1)).Take(ITEMS_PER_PAGE)
            });
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewData["BookMessage"] = Message;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                _repositoryWrapper._repositoryBook.Create(book);
                Message = $"{book.BookTitle} was successfully added";
                return RedirectToAction("Add", "Book");
            }
            return View();
        }
    }
}
