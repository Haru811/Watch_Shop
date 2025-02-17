using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WatchShop.DBContext;
using WatchShop.Models;

namespace WatchShop.Controllers
{
    public class PartialViewController : Controller
    {
        BANHANGEntities db = new BANHANGEntities();
        private WatchWebEntities1 db1 = new WatchWebEntities1();

        public ActionResult TopSeller()
        {
            List<sanphamModel1> lst = new List<sanphamModel1>();
            lst = (from sp in db1.products
                   where sp.topprod == true
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
                       newprice = sp.newprice
                   })).ToList();
            return PartialView(lst);
        }
        public ActionResult TopNew()
        {
            List<sanphamModel1> lst = new List<sanphamModel1>();
            lst = (from sp in db1.products
                   where sp.newprod == true
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
                       newprice = sp.newprice
                   })).ToList();
            return PartialView(lst);
        }
        public ActionResult TopDiscount()
        {
            List<sanphamModel1> lst = new List<sanphamModel1>();
            lst = (from sp in db1.products
                   where sp.discountprod == true 
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
                       newprice = sp.newprice
                   })).ToList();
            return PartialView(lst);
        }

        public ActionResult ProductWidget()
        {
            List<sanphamModel1> lst = new List<sanphamModel1>();
            lst = (from sp in db1.products
                   where sp.newprod== true
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
                       lday = sp.lday,
                       chongnuoc = sp.chongnuoc,
                       matkinh = sp.matkinh,
                       newprice = sp.newprice
                   })).Take(4).ToList();
            return PartialView(lst);
        }
        public ActionResult ProductWidgetNew()
        {
            List<sanphamModel1> lst = new List<sanphamModel1>();
             
            lst = (from sp in db1.products
                   where sp.newprod == true
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
                       lday = sp.lday,
                       chongnuoc = sp.chongnuoc,
                       matkinh = sp.matkinh,
                       newprice = sp.newprice
                   })).OrderBy(s=>s.id).Take(4).ToList();
            return PartialView(lst);
        }
        public ActionResult ProductWidgetDiscount()
        {
            List<sanphamModel1> lst = new List<sanphamModel1>();

            lst = (from sp in db1.products
                   where sp.discountprod == true
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
                       lday = sp.lday,
                       chongnuoc = sp.chongnuoc,
                       matkinh = sp.matkinh,
                       newprice = sp.newprice
                   })).OrderBy(s => s.id).Take(4).ToList();
            return PartialView(lst);
        }

        public ActionResult TopDanhMuc()
        {
            List<danhmucModel1> lst = new List<danhmucModel1>();
            lst = (from sp in db1.TOPDANHMUCs
                   where sp.topp == true
                   select (new danhmucModel1
                   {
                       alias = sp.alias,
                       hinhanh = sp.hinhanh,
                       id = sp.id,
                       tendanhmuc = sp.tendanhmuc
                   })).ToList();
            return PartialView(lst);
        }


    }
}