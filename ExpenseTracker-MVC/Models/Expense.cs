namespace ExpenseTracker_MVC.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public string ExpenseName { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public IEnumerable<Category> Categories { get; set;}
    }
}
