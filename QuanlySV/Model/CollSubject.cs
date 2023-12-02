using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySV.Model
{
    public class CollSubject : ModelBase
    {
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int NumberOfCredits { get; set; }
    }
}
