using E_Ticaret.DataAccessLayer.Abstract;
using E_Ticaret.DataAccessLayer.Concrete;
using E_Ticaret.DataAccessLayer.Repositories;
using E_Ticaret.EntiyLayer.Entities;

namespace E_Ticaret.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(DBContext context) : base(context)
        {
        }
    }
}
