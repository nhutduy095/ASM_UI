using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySV.Model
{
    internal class DataPointDtl
    {
        public int MarkId { get; set; }
        public int MarkDtlId { get; set; }
        public string UserId { get; set; }
        public string TotalCreditPass { get; set; }
        public int NumberOfCredits { get; set; }
        public int TotalFail { get; set; }
        public int TotalNotYet { get; set; }
        public int TotalPass { get; set; }
        public int TotalStuding { get; set; }
        public decimal AveragePointsMst { get; set; }
        public decimal AveragePoints { get; set; }
        public string Teacher { get; set; }
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string TeacherName { get; set; }

    }
}
