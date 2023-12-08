using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        //[StringLength(10, ErrorMessage = "Số điện thoại không được quá 10 số")]
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string MailAddress { get; set; }
        public string Address { get; set; }
        [Phone]
        public string ParentsPhoneNumber { get; set; }
        public string MajorID { get; set;}
    }
}
