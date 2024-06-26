using ExpenseTracker_MVC.Models;
using Google.Protobuf.WellKnownTypes;

namespace ExpenseTracker_MVC.Data
{
    public interface IExpenseRepository
    {
        public IEnumerable<Expense> GetAllExpenses();
        public Expense GetExpense(int id);
        public void UpdateExpense(Expense expense);

        public void InsertExpense(Expense expense);
        public IEnumerable<Category> GetCategories();
        Expense AssignCategory();

        public void DeleteExpense(Expense expense);

        public IEnumerable<Expense> SortExpenses(int catId);

        public IEnumerable<Expense> SearchExpenses(string searchString);

    }
}
