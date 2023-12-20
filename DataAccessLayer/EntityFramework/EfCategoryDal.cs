using E_Ticaret.DataAccessLayer.Abstract;
using E_Ticaret.DataAccessLayer.Concrete;
using E_Ticaret.DataAccessLayer.Repositories;
using E_Ticaret.EntiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(DBContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context=new DBContext();
            return context.Categories.Where(x => x.Status == true).Count();
        }

        public int CategoryCount()
        {
            using var context = new DBContext();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new DBContext();
            return context.Categories.Where(x => x.Status == false).Count();
        }
    }
}
