using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Dtos.ContactDtos
{ 
    public class GetContactDto
    {
        public int ContactID { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
<<<<<<< HEAD
        public string FooterDescription { get; set; }
        //public string FooterTitle { get; set; }
        //public string OpenDays { get; set; }
        //public string OpenDaysDescription { get; set; }
        //public string OpenHours { get; set; }
=======
        public string FooterTitle { get; set; }
        public string FooterDescription { get; set; }
        public string OpenDays { get; set; }
        public string OpenDaysDescription { get; set; }
        public string OpenHours { get; set; }
>>>>>>> e32eec035c75a5982a8917914afda64fd3f36143
    }
}
