using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySV.Model.ModelRequest
{
    internal class RequestPaging
    {
        public int? Page { get; set; }

        /// <summary>
        /// Count records of a page.
        /// </summary>
        public int? PerPage { get; set; }
    }
}
