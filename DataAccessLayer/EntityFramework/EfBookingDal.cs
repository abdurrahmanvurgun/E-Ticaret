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
	public class EfBookingDal : GenericRepository<Booking>, IBookingDal
	{
		public EfBookingDal(SignalRContext context) : base(context)
		{
		}

		public void BookingStatusApproved(int id)
		{
			using var context = new SignalRContext();
			var values = context.Bookings.Find(id);
			values.Description = "Rezervasyon Onaylandı";
			context.SaveChanges();
		}

		public void BookingStatusCancelled(int id)
		{
			using var context = new SignalRContext();
			var values = context.Bookings.Find(id);
			values.Description = "Rezervasyon İptal Edildi";
			context.SaveChanges();
		}
	}
}
