using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WatchShop.DBContext;
using PagedList;
using WatchShop.Models;

namespace WatchShop.Controllers
{
    public class AdminController : Controller
    {
        private WatchWebEntities1 db = new WatchWebEntities1();
        static List<sanphamModel1> lst = new List<sanphamModel1>();
        List<product> list = new List<product>(); 
        // GET: Admin
        public AdminController() 
        {
            list = db.products.ToList();
        }

        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Index(FillterReport fillter)
        {
            var products = db.products.Include(p => p.Brand).Include(p => p.category);

            return View(await products.ToListAsync());
        }

       
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = await db.products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }     
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult Index1(FillterReport fillter,int? page)
        {
            if(page == null)
            {
                lst = (from sp in list where sp.trangthai != null select (new sanphamModel1
                       {
                    id = sp.id,
                    alias = sp.alias,
                    productid = sp.productid,
                    productname = sp.productname,
                    thongtinphu = sp.thongtinphu,
                    thongtinphu1 = sp.thongtinphu1,
                    thongtinphu2 = sp.thongtinphu2,
                    thongtinphu3 = sp.thongtinphu3,
                    brandid = sp.brandid,
                    categoryid = sp.categoryid,
                    chongnuoc = sp.chongnuoc,
                    topprod = sp.topprod,
                    newprod = sp.newprod,
                    newprice = sp.newprice,
                    productprice = sp.productprice,
                    hinhanh3 = sp.hinhanh3,
                    hinhanh4 = sp.hinhanh4,
                    hinhanh5 = sp.hinhanh5,
                    hinhanhnen = sp.hinhanhnen,
                    lday = sp.lday,
                    matkinh = sp.matkinh,
                    mota = sp.mota,
                    tieude = sp.tieude,
                    trangthai = sp.trangthai,
                    discountprod = sp.discountprod,
                    hinhanh1 = sp.hinhanh1,
                    hinhanh2 = sp.hinhanh2,
                        })).ToList();
                
                page = 1;
                Session["fillter"] = fillter;
                if (fillter.topprod != null)
                {
                    lst = lst.Where(s => s.topprod == fillter.topprod).ToList();
                }
                if (fillter.isWatch != null)
                {
                    lst = lst.Where(s => s.isWatch == fillter.isWatch).ToList();
                }
            } else{}
            return View();
        }
        public string checkvalue(bool val)
        {
            if(val==true)
            {
              return "Áp Dụng";
            }
            else 
            {
              return "Không Áp Dụng";
                    
            }
        }
    }
}
