using Abp.Domain.Repositories;
using AspNetBoilerPlate_Demo2.Entities;
using AspNetBoilerPlate_Demo2.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetBoilerPlate_Demo2.Web.Controllers
{
	public class BookController : AspNetBoilerPlate_Demo2ControllerBase
	{
		IRepository<Book> _books;
		IRepository<Author, long> _authors;

		public BookController(IRepository<Book> books, IRepository<Author, long> authors)
		{
			_books = books;
			_authors = authors;
		}

        public async Task<IActionResult> Index()
        {
			var list = await _books.GetAllIncluding(x => x.Author).ToListAsync();
            return View(list);
        }

		public IActionResult NewBook(int id)
		{
			var bookViewModel = new BookViewModel();
			bookViewModel.Authors = _authors.GetAllList().AsEnumerable().Select(x => new SelectListItem()
										{
											Text = x.Name,
											Value = x.Id.ToString()
										});

			if (id < 1)
			{
				bookViewModel.Book = new Book();
			}
			else
			{
				bookViewModel.Book = _books.Get(id);
			}
			return View(bookViewModel);
		}

		public async Task<IActionResult> SaveBook(BookViewModel viewModel)
		{
			if (!ModelState.IsValid)
				throw new Exception("The state of the model is invalid");

			viewModel.Book.Author = _authors.Get(viewModel.Book.Author.Id);

			await _books.InsertOrUpdateAsync(viewModel.Book);

			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> DeleteBook(int id)
		{
			var book = _books.Get(id);

			await _books.DeleteAsync(book);

			return RedirectToAction(nameof(Index));
		}
    }
}