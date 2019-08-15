using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetBoilerPlate_Demo2.Entities
{
	public class Author : Entity<long>, IHasCreationTime
	{
		public virtual string Name { get; set; }

		public virtual DateTime DateOfBirth { get; set; }

		public DateTime CreationTime { get; set; }

		public Author()
		{
			CreationTime = Clock.Now;
		}
	}
}
