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
        public string ServiceName { get; set; }
        public string Requester { get; set; }
        public string RequestName { get; set; }
        public string RequestDate { get; set; }
        public string ConfirmBy { get; set; }
        public string ConfirmByName { get; set; }
        public string ConfirmDate { get; set; }
        public string FinishConfirmDate { get; set; }
        public string RejectType { get; set; }
        public string Remark { get; set; }
        public string Remark1 { get; set; }
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string MajorFrom { get; set; }
        public string MajorFromName { get; set; } 
        public string MajorTo { get; set; }
        public string MajorToName { get; set; }
        public string ReciveDate { get; set; }
        public string Status { get; set; }//N:New,A:Approve,W:Wait,R:reject,C:Cancel
    }
}
