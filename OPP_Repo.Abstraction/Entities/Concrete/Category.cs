using OPP_Repo.Abstraction.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Repo.Abstraction.Entities.Concrete
{
	public class Category :BaseEntity
	{
	
		public override Guid id { get => Guid.NewGuid(); set { } }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
