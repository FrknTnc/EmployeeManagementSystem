Employee Management System Automation

📋 Project Overview

This is a desktop-based Employee Management System developed as a Database Management Systems Final Project. The system enables efficient management of employee data, including branches, departments, employees, projects, and salaries within an organization. It supports CRUD operations (Create, Read, Update, Delete) through an intuitive interface and automatically calculates salaries. The system is designed to simplify and automate HR and payroll processes.

🚀 Key Features

Branch, Department, Employee, Project, and Salary Management
User-friendly C# Windows Forms interface with real-time database updates
Automatic salary calculation and bonus distribution via SQL triggers
Data integrity ensured by stored procedures and triggers
Views for simplified data querying across multiple tables
Alerts and confirmations for all database operations
Backup-ready SQL database structure
🏗️ Technologies Used

C# (Windows Forms via Visual Studio)
Microsoft SQL Server (MSSQL)
ERDPlus for ER diagrams
SQL Stored Procedures, Triggers, and Views
📝 Database Design

Relational Schema with 5 tables: Branch, Department, Employee, Project, Salary
Relationships:
Branch → Department via BranchID
Department → Employee via DepartmentID
Employee → Project via EmployeeID
Employee → Salary via EmployeeID
Views:
EMPLOYEE_PROJECT_VIEW for employee-project details
BRANCH_DEPARTMENT_EMPLOYEE_VIEW for overall employee hierarchy
Example SQL Trigger:
CREATE TRIGGER [dbo].[NewYear2023Bonus]
ON [dbo].[SalaryTable]
AFTER INSERT
AS
BEGIN
  UPDATE SalaryTable
  SET Amount = Amount + 5000
  WHERE [dbo].[SalaryTable].[PeriodDate] = '12-2022';
END
💻 Screenshots

Branch, Department, Employee, Project Management Screens
Salary Management Screen with Bonus Calculation
Data Visualization via Views
📂 How to Run

Restore the provided MSSQL database backup.
Open the Visual Studio solution.
Update the database connection string in the app settings.
Build and run the application.
📖 Project Highlights

This project demonstrates the integration of C# desktop applications with SQL databases, applying advanced SQL techniques such as triggers, views, and stored procedures for enterprise-level database management.
