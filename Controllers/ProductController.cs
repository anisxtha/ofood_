using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using restraunt.Data;
using restraunt.Models;

namespace restraunt.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db){
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ProductModel> objcategory = _db.products;
            return View(objcategory);
        }
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductModel obj){
            if(ModelState.IsValid){
                _db.products.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");    

            }
            return View();
        }

        public IActionResult Delete(int? id){
            if(id==null || id==0){
                return NotFound();
            }
            var product= _db.products.Find(id);

            if(product==null){
                return NotFound();
            }

            return View(product);
        }

         [HttpPost]
         [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int? id){
            
            var product = _db.products.FirstOrDefault(p => p.Id == id);
           
            if (product != null)
            {
            _db.products.Remove(product);
            _db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id){
            if(id==null || id==0){
                return NotFound();
            }
            var product= _db.products.Find(id);

            if(product==null){
                return NotFound();
            }

            return View(product);
        }

         [HttpPost]
         [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductModel product){
            if(ModelState.IsValid){
                _db.products.Update(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
            
            }

        }
    }
