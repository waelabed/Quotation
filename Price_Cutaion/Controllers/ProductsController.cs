using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Price_Cutaion;
using Price_Cutaion.Models;
namespace Price_Cutaion.Controllers
{
    public class ProductsController : Controller
    {
        ApplicationDbContext _Context = new ApplicationDbContext();

        // GET: Products
        
        public ActionResult Index()
        {
            var products = _Context.Products.ToList();

            return View(products);
        }
        [HttpGet]
        public  ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  ActionResult Create(ProductVM product)
        {
    
                
            if (ModelState.IsValid)
            {
              
                _Context.Products.Add(parsProduct(product));
             var val=   _Context.SaveChanges();
         
                product.productAttachImg.SaveAs(Server.MapPath(@"..\images\Products\" + product.productAttachImg.FileName));
                return RedirectToAction("Index");
            }
            return View();
        }

 [HttpGet]
        public ActionResult Edit(Int32 Id)
        {

            var varproducts = _Context.Products.Find(Id);

            return View(parsProductVm(varproducts));
        }

        [HttpPost]
        public  ActionResult Edit(Int32 Id,ProductVM product)
        {
            ModelState.Remove("productAttachImg");
            if(ModelState.IsValid)
            {
                var varproducts = _Context.Products.Find(Id );
                varproducts.producId = Id ;
                varproducts.productName = product.productName;
                varproducts.productPrice = product.productPrice;
                if (product.productAttachImg.FileName!="")
                {

                varproducts.productUrlImg = product.productAttachImg.FileName;

                product.productAttachImg.SaveAs(Server.MapPath(@"~\images\Products\" + product.productAttachImg.FileName));

               
                }
         
               var val= _Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Details(int Id )
        {
      var products = _Context.Products.Find(Id);
            return View(parsProductVm(products));
        }
   
       public ActionResult   Delete(int Id)
        {
            var products = _Context.Products.Find(Id);
            return View(parsProductVm(products));
        }
        [HttpPost]
        public ActionResult Delete(int Id , Product product)
        {
             product = _Context.Products.Find(Id);
            _Context.Products.Remove (product);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
     Product parsProduct(ProductVM product)
        {
            Product Details = new Product()
            {
                producId=product.producId,
                productName = product.productName,
                productPrice =product.productPrice,
                productUrlImg =product.productAttachImg.FileName
            };
            return Details;

        }
        ProductVM parsProductVm(Product product)
        {
            ProductVM Details = new ProductVM()
            {  producId=product.producId,
                productName = product.productName,
                productUrlImg = product.productUrlImg,

                productPrice = product.productPrice,
        };
            return Details;
        }
    }
}