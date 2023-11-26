using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySV.Model
{
    internal class CollectionServiceReg:ModelBase
    {
        public int DtlID { get; set; }
        public string ServiceId { get; set; }
        public string Requester { get; set; }
        public string RequestDate { get; set; }
        public string Confirmby { get; set; }
        public string ConfirmDate { get; set; }
        public string RejectType { get; set; }
        public string Remark { get; set; }
        public string Remark1 { get; set; }
    }
}
