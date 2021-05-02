using OPP_Repo.Abstraction.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Repo.Abstraction.Entities.Abstract
{  // BaseEntity sınıfımı önce "public" daha sonra "abstract" olarak işaretliyoruz.Amacımız sınıfmızı soyutlaştırmak.
	public abstract class BaseEntity
	{
		public abstract Guid id { get; set; }
		private DateTime _createDate = DateTime.Now;
		public DateTime  CreateDate
		{
			get => _createDate;
			set => _createDate= value;
		}
		private Status _status = Status.Active;
		public Status Status
		{
			get => _status;
			set => _status = value;
			
		}
	}
}
