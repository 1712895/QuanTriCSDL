using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver.Core;
using System.Configuration;
using WebTest.App_Start;
using WebTest.Models;
using MongoDB.Driver;

namespace WebTest.Controllers
{
    public class ProductController : Controller
    {
        private MongoDBContext dbcontext;
        private IMongoCollection<ProductModel> productCollection;

        public ProductController()
        {
            dbcontext = new MongoDBContext();
            productCollection = dbcontext.database.GetCollection<ProductModel>("Products");
        }
        // GET: Product
        public ActionResult Index()
        {
            List<ProductModel> products = productCollection.AsQueryable<ProductModel>().ToList();
            return View(products);
        }

        // GET: Product/Details/5
        public ActionResult Details(string id)
        {
            var productId = new ObjectId(id);
            var product = productCollection.AsQueryable<ProductModel>().SingleOrDefault(x => x.Id == productId);
            return View(product);
        }
    }
}
