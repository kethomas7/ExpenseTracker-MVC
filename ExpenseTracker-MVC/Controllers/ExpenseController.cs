using ExpenseTracker_MVC.Data;
using ExpenseTracker_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker_MVC.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IExpenseRepository repo;  // the transient method allows us that everytime a new Iexpense is made it uses the expense repo instead. making them the same thing

        public ExpenseController(IExpenseRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index() // this adds all the products to the expense home page
        {
            var products = repo.GetAllExpenses();
            return View(products);
        }

        //we went to see a page with all expenses
        public IActionResult GetExpense(int id)
        {
            var expense = repo.GetExpense(id);
            return View(expense);
        }

        public IActionResult UpdateExpense(int id)
        {
            var expense = repo.GetExpense(id);
            return View(expense);
        }
        public IActionResult UpdateExpenseToDatabase(Expense expense) //return us to the page with all expenses the index/home 
        {

            repo.UpdateExpense(expense);
            return RedirectToAction("GetExpense", new { id = expense.ExpenseID });
        }

        public IActionResult AddExpense()
        {

            var expens = repo.AssignCategory();
            return View(expens);
        }

        public IActionResult InsertExpenseToDatabase(Expense expenseToInsert)
        {
            repo.InsertExpense(expenseToInsert);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExpense(Expense expense)
        {
            repo.DeleteExpense(expense);
            return RedirectToAction("Index");
        }

        public IActionResult SortExpenses(int id) 
        {
            var sortedExpenses = repo.SortExpenses(id);
            return View(sortedExpenses);
        }

        public IActionResult SearchExpenses(string searchString)
        {
            var searchResults = repo.SearchExpenses(searchString);
            return View(searchResults);
        }
    }
}
