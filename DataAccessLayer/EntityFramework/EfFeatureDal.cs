using E_Ticaret.DataAccessLayer.Abstract;
using E_Ticaret.DataAccessLayer.Concrete;
using E_Ticaret.DataAccessLayer.Repositories;
using E_Ticaret.EntiyLayer.Entities;
<<<<<<< HEAD

=======
<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> e32eec035c75a5982a8917914afda64fd3f36143
>>>>>>> bc99685aa795c230e50027c02146e58cd1f8de44

namespace E_Ticaret.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(DBContext context) : base(context)
        {
        }
    }
}
