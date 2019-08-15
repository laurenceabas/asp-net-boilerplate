using Abp.Domain.Repositories;
using AspNetBoilerPlate_Demo2.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AspNetBoilerPlate_Demo2.Web.Controllers
{
	public class AuthorController : AspNetBoilerPlate_Demo2ControllerBase
	{
		IRepository<Author, long> _authors;

		public AuthorController(IRepository<Author, long> authorsRepository)
		{
			_authors = authorsRepository;
		}
		public async Task<IActionResult> Index()
		{
			var list = await _authors.GetAllListAsync();
			return View(list);
		}

		public IActionResult NewAuthor(int id)
		{
			if (id < 1)
				return View(new Author());
			else
				return View(_authors.Get(id));
		}

		public async Task<IActionResult> SaveAuthor(Author newAuthor)
		{
			if (!this.ModelState.IsValid)
				throw new Exception("Model is invalid");

			await _authors.InsertOrUpdateAsync(newAuthor);

			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> DeleteAuthor(int id)
		{
			var author = _authors.Get(id);

			await _authors.DeleteAsync(author);

			return RedirectToAction(nameof(Index));
		}
	}
}
