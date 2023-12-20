using Microsoft.EntityFrameworkCore;
using E_Ticaret.DataAccessLayer.Abstract;
using E_Ticaret.DataAccessLayer.Concrete;
using E_Ticaret.DataAccessLayer.Repositories;
using E_Ticaret.EntityLayer.Entities;

namespace E_Ticaret.DataAccessLayer.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(DBContext context) : base(context)
        {
        }

        public List<Basket> GetBasketByMenuTableNumber(int id)
        {
            using var context=new DBContext();
            var values = context.Baskets.Where(x => x.MenuTableID == id).Include(y=>y.Product).ToList();
            return values;
        }
    }
}
