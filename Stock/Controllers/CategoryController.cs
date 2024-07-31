using Microsoft.AspNetCore.Mvc;
using Stock.DataAcess.Data;
using Stock.DataAcess.Repository.IRepository;
using Stock.Models;

namespace StockWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _catagoryRepo;
        public CategoryController(ICategoryRepository db)
        {
            _catagoryRepo = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _catagoryRepo.GetAll().ToList();
            //ViewBag.ClientCount = objClientList.Count;
            //ViewBag.Total = objClientList.Count * 120;
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _catagoryRepo.Add(obj);
                _catagoryRepo.Save();
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _catagoryRepo.Get(u=>u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _catagoryRepo.Update(obj);
                _catagoryRepo.Save();
                TempData["success"] = "Category Update Successfully";
                return RedirectToAction("Index", "Category");
            }
            return View();

        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _catagoryRepo.Get(u => u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {

            Category? obj = _catagoryRepo.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _catagoryRepo.Remove(obj);
            _catagoryRepo.Save();
            TempData["success"] = "Category Delete Successfully";
            return RedirectToAction("Index", "Category");
        }
    }
}
