using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WatchShop.Models
{
    public class sanphamModel
    {
        public int id { get; set; }
        public string tensanpham { get; set; }
        public Nullable<int> giaban { get; set; }
        public Nullable<int> giakm {  get; set; }
        public string hinhanh { get; set; }
        public string alias { get; set; }
        public string mota { get; set; }
    }
}