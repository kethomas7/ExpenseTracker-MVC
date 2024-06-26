using Dapper;
using ExpenseTracker_MVC.Models;
using System.Data;

namespace ExpenseTracker_MVC.Data
{
    public class ExpenseRepository:IExpenseRepository
    {
        private readonly IDbConnection _connection;

        public ExpenseRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public Expense AssignCategory()
        {
            var categoryList = GetCategories();
            var expense = new Expense();
            expense.Categories = categoryList;
            return expense;
            
        }

        public IEnumerable<Expense> GetAllExpenses()
        {
            return _connection.Query<Expense>("SELECT ExpenseID, ExpenseName, amount, Date, categories.CategoryID, CategoryName FROM expenses JOIN categories ON expenses.CategoryID = categories.CategoryID Order By Date;");

         
        }

        public IEnumerable<Category> GetCategories()
        {
            return _connection.Query<Category>("SELECT * FROM categories;");
        }
    

        public Expense GetExpense(int id)
        {
            return _connection.QuerySingle<Expense>("SELECT ExpenseID, ExpenseName, amount, Date, categories.CategoryID, CategoryName FROM expenses JOIN categories ON expenses.CategoryID = categories.CategoryID WHERE ExpenseID = @id", new { id });
        }

        public void InsertExpense(Expense expense)
        {
           
                _connection.Execute("INSERT INTO expenses (ExpenseName, Amount, Date,CategoryID) VALUES (@expenseName, @amount, @date, @categoryID);", new { expenseName = expense.ExpenseName, amount = expense.Amount, categoryID = expense.CategoryID, date = expense.Date });
        }

       

        public void UpdateExpense(Expense expense)
        {
            _connection.Execute("UPDATE expenses SET ExpenseName = @expenseName, Amount = @amount, Date = @date WHERE ExpenseID = @id;", new { expenseName = expense.ExpenseName, amount = expense.Amount, date = expense.Date, id = expense.ExpenseID });
        }

        public void DeleteExpense(Expense expense)
        {
            _connection.Execute("DELETE from expenses WHERE ExpenseID = @id;", new {id = expense.ExpenseID});
        }

        public IEnumerable<Expense> SortExpenses(int catId) 
        {

            return _connection.Query<Expense>("SELECT ExpenseID, ExpenseName, amount, Date, categories.CategoryID, CategoryName FROM expenses JOIN categories ON expenses.CategoryID = categories.CategoryID WHERE categories.CategoryID = @catId Order By Date;", new {catId});
        }

        public IEnumerable<Expense> SearchExpenses(string searchString)
        {
            return _connection.Query<Expense>("SELECT ExpenseID, ExpenseName, amount, Date, categories.CategoryID, CategoryName FROM expenses JOIN categories ON expenses.CategoryID = categories.CategoryID WHERE ExpenseName LIKE @name;", new { name = "%" + searchString + "%" });
        }
    }
}
