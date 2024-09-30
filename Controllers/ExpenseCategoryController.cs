using ExpenseManagement.DataLayer;
using ExpenseManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagement.Controllers
{
    public class ExpenseCategoryController : Controller
    {
        public readonly DbContextExpMgt _context;

        public ExpenseCategoryController(DbContextExpMgt context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<ExpenseCategoryEntity> ExpenseCategories = _context.ExpenseCategory.ToList();
            return View(ExpenseCategories);
          
        }

        public IActionResult Create(ExpenseCategoryEntity expenseDetails)
        {
            if (ModelState.IsValid)
            {
                _context.ExpenseCategory.Add(expenseDetails);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }


        public IActionResult GetExpCatDetailsForUpdate(int? Id)
        {
            var _ExpenseCatDetails = _context.ExpenseCategory.Find(Id);
            if (_ExpenseCatDetails == null)
            {

                return NotFound();

            }
            return View(_ExpenseCatDetails);
        }

        [HttpPost]
        public IActionResult Update(ExpenseCategoryEntity _ExpenseCatDetails)
        {
            if (ModelState.IsValid)
            {
                _context.ExpenseCategory.Update(_ExpenseCatDetails);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();

        }

        public IActionResult GetExpCatDetailsForDelete(int? Id)
        {
            var _ExpenseCatDetails = _context.ExpenseCategory.Find(Id);
            if (_ExpenseCatDetails == null)
            {

                return NotFound();

            }
            return View(_ExpenseCatDetails);
        }

        public IActionResult Delete(int? ExpenseCategoryId)
        {
            var _ExpenseCatDetails = _context.ExpenseCategory.Find(ExpenseCategoryId);
            if (_ExpenseCatDetails == null)
            {

                return NotFound();

            }
            _context.ExpenseCategory.Remove(_ExpenseCatDetails);
            _context.SaveChanges();
            return RedirectToAction("Index");


        }







    }
}
