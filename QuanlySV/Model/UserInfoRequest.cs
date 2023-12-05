using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySV.Model
{
    internal class UserInfoRequest:ModelBase
    {
        public string UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool Sex { get; set; }
        public string UserType { get; set; }
        public string Birthday { get; set; }
        public string IdClass { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        public string Address { get; set; }
        public string ParentsPhoneNumber { get; set; }
        public string MajorID { get; set;}
    }
}
