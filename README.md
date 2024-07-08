
  
  

# ExpenseMate

**ExpenseMate** is a web application that allows users to comprehensively track their expenses. Users can view all their expenses, add new ones, update existing entries, delete unnecessary expenses, sort them by category, and search for specific expenses using keywords. The project is built using the ASP.NET MVC framework, leveraging C# for backend logic and SQL for database operations. It connects to a MySQL database using Dapper ORM for efficient data access, and the frontend is styled with HTML and CSS.
  

## This project demonstrates proficiency in

  * Web development with ASP.NET Core MVC
* C# programming
* SQL database management
* Object-Relational Mapping (ORM) with Dapper
* Building user-friendly web applications

 ### **Features**

  

* **Create:** Add a new expense to the tracker database, enter the expense name, amount, date, and category.
* **Read:** View all expenses in the database.
* **Update:** Edit an existing expense.
* **Delete:** Remove an expense from the database.
* **Sort:** Group  and view expenses by category.
* **Search:**  Look up specific expenses by entering a keyword

### Technologies

* ASP.NET MVC: Framework for building web applications.
* C#: Programming language used for backend development.
* SQL: Language used for database operations.
* MySQL: Database management system used for storing all expenses.
* Dapper ORM: Object-Relational Mapping (ORM) tool for database access.
* HTML: Markup language for creating web pages.
* CSS: Style sheet language for designing the web application.

  




  

## How to Use

  

1.  Clone this repository.
2.  Download and run this mock database setup file in MySQL:  [CreateExpenseTrackerDB](https://drive.google.com/file/d/1N-Roo6LoTOOyummie1Q_jpITpcTHXhug/view?usp=sharing).
3.  Create an appsettings.json file in the project with this format:

```

{
  "ConnectionStrings": {
  "expensetracker": "Server=probablyLocalhost;Database=expensetracker;uid=probablyRoot;Pwd=yourPasswordHere;Port=3306;"
  },
  "Logging": {
  "LogLevel": {
      "Default": "Warning"
  }
  },
  "AllowedHosts": "*"
}

```

  4.  Configure the connection string in  `appsettings.json`  to point to your MySQL instance of the database.
5.  Build and run the application.



  

## Contact

  

* Email:  [kaitlynthomas2416@gmail.com](mailto:kaitlynthomas2416@gmail.com)
* GitHub:  [Kaitlyn Thomas](https://github.com/kethomas7)
* LinkedIn:  [Kaitlyn Thomas](www.linkedin.com/in/kaitlyn-thomas-)



  
