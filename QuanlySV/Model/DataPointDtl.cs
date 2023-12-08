using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySV.Model
{
    internal class DataPointDtl
    {
        public string _Id {  get; set; }
        public int MarkId { get; set; }
        public int MarkDtlId { get; set; }
        public string UserId { get; set; }
        public string TotalCreditPass { get; set; }
        public int NumberOfCredits { get; set; }
        public int TotalFail { get; set; }
        public int TotalNotYet { get; set; }
        public int TotalPass { get; set; }
        public int TotalStuding { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AveragePointsMst { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AveragePoints { get; set; }
        public string Teacher { get; set; }
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string LastName { get; set; }
        public string Season { get; set; }
        public string TeacherName { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PointASM { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PointDiligence { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PointProtect { get; set; }


    }
}
