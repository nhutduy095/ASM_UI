using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySV.Model
{
    public class InputPointRequest
    {
        public string _Id { get; set; }
        public int MarkId { get; set; }
        public int MarkDtlId { get; set; }
        public string StudentId { get; set; }
        public string SubjectId { get; set; }
        public string MajorId { get; set; }
        public string DeptId { get; set; }
        public decimal PointDiligence { get; set; } = 0;    
        public decimal PointASM { get; set; } = 0;
        public decimal PointProtect { get; set; } = 0;
        public decimal AveragePoints { get; set; } = 0;
        public string Season { get; set; }

    }
}
