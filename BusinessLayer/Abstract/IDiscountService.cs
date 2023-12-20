using E_Ticaret.EntiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.BusinessLayer.Abstract
{
    public interface IDiscountService : IGenericService<Discount>
	{
		void TChangeStatusToTrue(int id);
		void TChangeStatusToFalse(int id);
		List<Discount> TGetListByStatusTrue();
	}
}
