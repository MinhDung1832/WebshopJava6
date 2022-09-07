using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FPT_POLY_CHSARP5.WebApp.Application.Dtos
{
    public class PageViewModel<T>//Dùng chung cho các đối tượng khác nhau
    {
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }
}
