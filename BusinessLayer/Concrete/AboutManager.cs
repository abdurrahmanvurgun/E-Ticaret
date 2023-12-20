﻿using E_Ticaret.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Ticaret.BusinessLayer.Abstract;
using E_Ticaret.DataAccessLayer.Abstract;

namespace E_Ticaret.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void TAdd(About entity)
        {
            _aboutDal.Add(entity);
        }

        public void TDelete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public About TGetByID(int id)
        {
           return _aboutDal.GetByID(id);
        }

        public List<About> TGetListAll()
        {
           return _aboutDal.GetListAll();
        }

        public void TUpdate(About entity)
        {
           _aboutDal.Update(entity);
        }
    }
}
