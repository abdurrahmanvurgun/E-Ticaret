using E_Ticaret.DataAccessLayer.Abstract;
using E_Ticaret.DataAccessLayer.Concrete;
using E_Ticaret.DataAccessLayer.Repositories;
using E_Ticaret.EntityLayer.Entities;
using E_Ticaret.EntiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.DataAccessLayer.EntityFramework
{
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
    {
        public EfMoneyCaseDal(SignalRContext context) : base(context)
        {
        }

        public decimal TotalMoneyCaseAmount()
        {
            using var context = new SignalRContext();
            return context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
        }
    }
}