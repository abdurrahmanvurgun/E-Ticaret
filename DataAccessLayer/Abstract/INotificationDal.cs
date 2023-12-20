using E_Ticaret.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.DataAccessLayer.Abstract
{
	public interface INotificationDal:IGenericDal<Notification>
	{
		int NotificationCountByStatusFalse();
		List<Notification> GetAllNotificationByFalse();
		void NotificationStatusChangeToTrue(int id);
		void NotificationStatusChangeToFalse(int id);

    }
}
