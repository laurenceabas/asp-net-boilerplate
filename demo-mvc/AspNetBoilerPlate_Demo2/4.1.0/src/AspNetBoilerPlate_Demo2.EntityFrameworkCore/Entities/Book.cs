using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;

namespace AspNetBoilerPlate_Demo2.Entities
{
	public class Book : Entity, IHasCreationTime
	{
		public Book()
		{
			CreationTime = Clock.Now;
		}

		public virtual Author Author { get; set; }

		public virtual string Title { get; set; }

		public virtual DateTime PublishedDate { get; set; }

		public DateTime CreationTime { get; set; }
	}
}
