using AspNetBoilerPlate_Demo2.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetBoilerPlate_Demo2.Web.ViewModels
{
	public class BookViewModel
	{
		public virtual Book Book { get; set; }

		public virtual IEnumerable<SelectListItem> Authors { get; set; }
	}
}
