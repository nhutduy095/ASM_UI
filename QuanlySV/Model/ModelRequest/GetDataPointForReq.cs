using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySV.Model.ModelRequest
{
    internal class GetDataPointForReq:RequestPaging
    {
        public string userId { get; set; }
        public string subjectName { get; set; }
    }
}
