using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sitech.common
{
    public class Pagination<T> where T : class
    {
        //clase generica para paginacion
        public int CurrentPage { get; set; }
        public int RecordPerPage { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPage { get; set; }

        public string Search { get; set; }
        public IEnumerable<T> Result { get; set; }
        public string Tasks { get; set; }
        public List<T> State { get; set; }
    }
}
