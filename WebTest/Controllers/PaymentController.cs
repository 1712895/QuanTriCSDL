using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        PaymentModels pay = new PaymentModels();
        public ActionResult Index()
        {
            return View(pay.layds());
        }

        // GET: Payment/Details/5
        public ActionResult Details(int id)
        {
            return View(pay.lays(id));
        }

        // GET: Payment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Payment/Create
        [HttpPost]
        public ActionResult Create(DonHang n)
        {
                // TODO: Add insert logic here
                pay.them(n);
                return RedirectToAction("Index");
           
        }

        
    }
}
