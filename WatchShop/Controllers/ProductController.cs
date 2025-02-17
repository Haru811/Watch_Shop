using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchShop.DBContext;
using WatchShop.Models;

namespace WatchShop.Controllers
{
    public class ProductController : Controller
    {
        private BANHANGEntities db = new BANHANGEntities();
        private WatchWebEntities1 db1 = new WatchWebEntities1();
        public ActionResult ProductDetails(int? id)
        {
            List<sanphamModel1> lst = new List<sanphamModel1>();
            lst = (from sp in db1.products
                   where sp.id == id
                   select (new sanphamModel1
                   {    
                      
                       alias = sp.alias,
                       hinhanhnen = sp.hinhanhnen,
                       hinhanh1 = sp.hinhanh1,
                       hinhanh2 = sp.hinhanh2,
                       hinhanh3 = sp.hinhanh3,
                       hinhanh4 = sp.hinhanh4,
                       hinhanh5 = sp.hinhanh5,
                       id = sp.id,
                       thongtinphu = sp.thongtinphu,
                       thongtinphu1 = sp.thongtinphu1,
                       thongtinphu2 = sp.thongtinphu2,
                       thongtinphu3 = sp.thongtinphu3,
                       productname = sp.productname,
                       productprice = sp.productprice,
                       mota = sp.mota,
                       newprice = sp.newprice,
                       lday = sp.lday,
                       chongnuoc = sp.chongnuoc,
                       matkinh = sp.matkinh
                   })).ToList();
            ViewBag.dmid = id;
            return View(lst);
        }
    }
}