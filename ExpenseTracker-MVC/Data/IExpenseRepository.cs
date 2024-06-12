﻿using ExpenseTracker_MVC.Models;
using Google.Protobuf.WellKnownTypes;

namespace ExpenseTracker_MVC.Data
{
    public interface IExpenseRepository
    {
        public IEnumerable<Expense> GetAllExpenses();
        public Expense GetExpense(int id);
        public void UpdateExpense(Expense expense);

        public void InsertExpense(Expense expense);//why doesnt it return an expense
        public IEnumerable<Category> GetCategories();// gets all the catergoies
        Expense AssignCategory();// assigns all the categories to an expense
    }
}
