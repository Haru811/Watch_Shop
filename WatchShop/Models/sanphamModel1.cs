using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WatchShop.DBContext;

namespace WatchShop.Models
{
    public class sanphamModel1
    {
        public int id { get; set; }
        public string productid { get; set; }
        public string productname { get; set; }
        public Nullable<bool> trangthai { get; set; }
        public string tieude { get; set; }
        public Nullable<int> productprice { get; set; }
        public Nullable<int> newprice { get; set; }
        public string alias { get; set; }
        public Nullable<bool> newprod { get; set; }
        public Nullable<bool> topprod { get; set; }
        public Nullable<bool> discountprod { get; set; }
        public int brandid { get; set; }
        public int categoryid { get; set; }
        public string lday { get; set; }
        public string matkinh { get; set; }
        public string chongnuoc { get; set; }
        public string thongtinphu { get; set; }
        public string thongtinphu1 { get; set; }
        public string thongtinphu2 { get; set; }
        public string thongtinphu3 { get; set; }
        public string mota { get; set; }
        public string hinhanhnen { get; set; }
        public string hinhanh1 { get; set; }
        public string hinhanh2 { get; set; }
        public string hinhanh3 { get; set; }
        public string hinhanh4 { get; set; }
        public string hinhanh5 { get; set; }
        public Nullable<bool> isWatch { get; set; }
        public Nullable<bool> isHide { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual category category { get; set; }
    }
}