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

      
        [Route("Product")]
        public ActionResult Index()
        {
            /*
                1. tim cach xuat products ra man hinh console de debug
                2. Tim cach ket noi vs redis
             */
            List<ProductModel> products = productCollection.AsQueryable<ProductModel>().ToList();
            
            return View(products);
        }

        // GET: Product/Details/5
        [Route("Product/Details/{id}")]
        public ActionResult Details(string id)
        {
            var productId = new ObjectId(id);
            var product = productCollection.AsQueryable<ProductModel>().SingleOrDefault(x => x.Id == productId);
            return View(product);
        }
        [Route("Product/{loai}")]
        public ActionResult PhanLoaiProduct(string loai)
        {
            var category = productCollection.AsQueryable<ProductModel>().Where(x => (x.Categories.parent.Equals(loai) || x.Categories.path.Equals(loai)));
            return View(category);
        }
        [Route("Product/{loai}/{gioitinh}")]
        public ActionResult PhanLoaiProductvaGioi(string loai, string gioitinh)
        {
            var category = productCollection.AsQueryable<ProductModel>().Where(x => x.Categories.parent.Contains(loai) && x.Categories.path.Contains(gioitinh));
            return View(category);
        }
    }
}
