using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gpw.Models;
using PagedList;
using PagedList.Mvc;

namespace gpw.Controllers
{
    public class HomeController : Controller
    {
        private gpwEntities db = new gpwEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        [Authorize]
        public ActionResult Search(string keyword, int? pg)
        {
            int pageSize = 25;
            if (pg == null) pg = 1;
            int pageNumber = (pg ?? 1);
            ViewBag.pg = pg;
            if (keyword == null) keyword = "";
            
            string sql = "SELECT t1.Id as id, ho_ten as ho_ten, dia_chi as dia_chi, hinh_anh as hinh_anh, Email as email, PhoneNumber as phone_number from users t1 join thong_tin_user t2 on t1.Id = t2.user_id";

            if (keyword != null && keyword != "")
            {
                ViewBag.keyword = keyword;
                sql += " where t1.Email like '%" + keyword + "%'" + " or t1.PhoneNumber like '%" + keyword + "%'";
            }

            var data = db.Database.SqlQuery<ListUser>(sql).ToList();

            return View(data.ToPagedList(pageNumber, pageSize));
        }

        [Authorize]
        public ActionResult Profile(string id)        
        {
            var profile = db.thong_tin_user.Where(x => x.user_id == id).Select(x=>x).FirstOrDefault();
            return View(profile);
        }
    }
}