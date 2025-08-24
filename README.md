# TaskFlow – .NET Core Web API + MS SQL

TaskFlow is a simple **task management system** built with **ASP.NET Core (C#)** and **MS SQL Server**.
It provides a REST API to create, read, update, and delete tasks.
The project demonstrates backend development using Entity Framework Core, database integration, and RESTful API design.

---

## 🚀 Features

* Create, Read, Update, and Delete tasks (CRUD operations)
* Built with **.NET Core Web API** and **Entity Framework Core**
* Uses **MS SQL Server** for persistent storage
* RESTful endpoints tested with Postman
* Clean and modular codebase for learning and extension

---

## 🛠️ Tech Stack

* **Backend:** ASP.NET Core Web API (C#)
* **Database:** MS SQL Server, Entity Framework Core
* **Tools:** Visual Studio / VS Code, Postman, Git

---

## 📂 Project Structure

```
TaskFlow/
│-- Controllers/       # API Controllers
│-- Models/            # Task model
│-- Data/              # DB Context & Migrations
│-- Program.cs         # Entry point
│-- appsettings.json   # DB Config
│-- Requirements.txt   # Dependencies
```

---

## ⚡ API Endpoints

| Method | Endpoint          | Description             |
| ------ | ----------------- | ----------------------- |
| POST   | `/api/tasks`      | Create a new task       |
| GET    | `/api/tasks`      | Get all tasks           |
| GET    | `/api/tasks/{id}` | Get task by ID          |
| PUT    | `/api/tasks/{id}` | Update an existing task |
| DELETE | `/api/tasks/{id}` | Delete a task           |

---

## 🖥️ Setup Instructions

1. **Clone the repo**

   ```bash
   git clone https://github.com/your-username/TaskFlow.API.git
   cd TaskFlow.API
   ```

2. **Install Dependencies**

   ```bash
   dotnet add package Microsoft.AspNetCore.OpenApi
   dotnet add package Swashbuckle.AspNetCore
   dotnet add package Microsoft.EntityFrameworkCore
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   dotnet add package Microsoft.EntityFrameworkCore.Tools

   ```

3. **Configure Database**

   * Open `appsettings.json`
   * Update your SQL Server connection string:
   * Since i used it locally YOUR_SERVER was localhost

     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=TaskFlowDB;Trusted_Connection=True;TrustServerCertificate=True;"
     }
     ```

4. **Run Migrations**

   ```bash
   dotnet ef database update
   ```

5. **Run the App**

   ```bash
   dotnet run
   ```

6. **Test with Postman**

   * Import the API endpoints
   * Try creating and managing tasks

---

## 📜 Requirements.txt

```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Swashbuckle.AspNetCore (optional, for Swagger)
```

---

## 📸 Screenshots

<img width="1514" height="811" alt="{87F4AAA7-1E84-403A-AEBE-9B0737BFF4E2}" src="https://github.com/user-attachments/assets/d4b1afeb-4d5e-408a-a422-6ca6ab7cd831" />


---

## 📘 Learning Outcomes

* Built a complete **.NET Core REST API**
* Worked with **Entity Framework Core + MS SQL Server**
* Understood **CRUD operations, migrations, and API testing**
* Practiced clean coding, Git usage, and project documentation

---

## 📎 License

This project is open-source and free to use for learning.
(i made it with AI as well bruv)
