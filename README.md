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

📂 How to Run

Restore the provided MSSQL database backup.
Open the Visual Studio solution.
Update the database connection string in the app settings.
Build and run the application.

🎥 Project Video Demo
https://youtu.be/yv_42glGGzI
