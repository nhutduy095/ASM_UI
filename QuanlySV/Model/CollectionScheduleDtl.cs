using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySV.Model
{
    public class CollectionScheduleDtl
    {
        public int DtlId { get; set; }
        public string UserId { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public string Day { get; set; }
        public string Shift { get; set; }
        public string RoomId { get; set; }
        public string ClassId { get; set; }
        public string TeacherId { get; set; }
        public string SubjectId { get; set; }
    }
}
