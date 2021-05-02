using OPP_Repo.Abstraction.Entities.Concrete;
using OPP_Repo.Abstraction.Repositories.Abstract;
using System;
using System.Windows.Forms;

namespace OPP_Repo.Abstraction.Repositories.Concrete
{
	public class CategoryRepository : BaseCategoryRepository
	{
		Category category;
		public override void CreateCategory(string categoryName, string description)
		{
			category = new Category();
			category.Name = categoryName;
			category.Description = description;
		}

		public override void Eraser(GroupBox groupBox)
		{
			foreach (Control item in groupBox.Controls)
			{
				if (item is TextBox)
				{
					item.Text = String.Empty;
				}
			}
		}

		public override void ListOfCategories(ListView listView)
		{
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = category.id.ToString();
			listViewItem.SubItems.Add(category.Name);
			listViewItem.SubItems.Add(category.Description);
			listViewItem.SubItems.Add(category.Status.ToString());
			listViewItem.SubItems.Add(category.CreateDate.ToString());

			listView.Items.Add(listViewItem);

			listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}
	}
}
