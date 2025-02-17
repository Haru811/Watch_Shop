using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web.Mvc;
using System.Web.UI;
using WatchShop.DBContext;
using WatchShop.Models;


namespace WatchShop.Controllers
{
    public class ProductsController : Controller
    {
        private BANHANGEntities db = new BANHANGEntities();
        private WatchWebEntities1 db1 = new WatchWebEntities1();
        public ActionResult Index(int? page, bool? dmid)
        {
            //List<sanphamModel1> lst = new List<sanphamModel1>();
            IPagedList lst = null;
            if (page == null)
                page = 1;
            int pagenum = 9;
            lst = (from sp in db1.products
                   where sp.newprod== dmid  
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
                       productname = sp.productname,
                       productprice = sp.productprice,
                       mota = sp.mota,
                       newprice = sp.newprice
                   })).OrderByDescending(s => s.id).ToPagedList(page.Value, pagenum);
            ViewBag.dmid = dmid;
            return View(lst);
        }
        public ActionResult Index1(int? page, bool? dmid)
        {
            //List<sanphamModel1> lst = new List<sanphamModel1>();
            IPagedList lst = null;
            if (page == null)
                page = 1;
            int pagenum = 9;
            lst = (from sp in db1.products
                   where sp.topprod == dmid
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
                   })).OrderByDescending(s => s.id).ToPagedList(page.Value, pagenum);
            ViewBag.dmid = dmid;
            return View(lst);
        }
        public ActionResult Index2(int? page,bool? dmid)
        {
            //List<sanphamModel1> lst = new List<sanphamModel1>();
            IPagedList lst = null;
            if (page == null)
                page = 1;
            int pagenum = 9;
            lst = (from sp in db1.products
                   where sp.discountprod == dmid
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
                   })).OrderByDescending(s => s.id).ToPagedList(page.Value, pagenum);
            ViewBag.dmid = dmid;
            return View(lst);
        }
        public ActionResult AllProduct(int? page,bool? dmid)
        {
            //List<sanphamModel1> lst = new List<sanphamModel1>();
            IPagedList lst = null;
            if(page == null)
                page = 1;
            int pagenum = 9;
            lst = (from sp in db1.products
                  where sp.trangthai == dmid
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
                       matkinh = sp.matkinh,
                       trangthai = sp.trangthai

                   })).OrderByDescending(s => s.id).ToPagedList(page.Value, pagenum);
        ViewBag.dmid = dmid;
            return View(lst);
        }
    }
}