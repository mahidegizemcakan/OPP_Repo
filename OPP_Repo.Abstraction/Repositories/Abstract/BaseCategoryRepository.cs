using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPP_Repo.Abstraction.Repositories.Abstract
{
	public abstract class BaseCategoryRepository
	{
		public abstract void CreateCategory(string categoryName, string description);
		public abstract void Eraser(GroupBox groupBox);
		public abstract void ListOfCategories(ListView listView);
	}
}
