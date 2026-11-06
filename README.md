# 🚀 MVCApp

[![.NET Core](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![ASP.NET Core Razor Pages](https://img.shields.io/badge/Framework-Razor%20Pages-blueviolet?style=for-the-badge&logo=framework)](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/)
[![Entity Framework Core](https://img.shields.io/badge/ORM-EF%20Core-green?style=for-the-badge)](https://learn.microsoft.com/en-us/ef/core/)



A robust, enterprise-grade web application built with **ASP.NET Core Model-View-Controller (MVC)** and **Entity Framework Core**. This project demonstrates clean architecture principles, structured data management, and standard Microsoft enterprise development patterns.

---

## 🌟 Key Features

* **MVC Architecture:** Strict separation of concerns dividing business logic (Models), user interface (Views), and request handling (Controllers).
* **CRUD Operations:** Full data lifecycle management with robust server-side processing.
* **Data Persistence:** Integrated with Entity Framework Core for seamless database operations and migrations.
* **Input Validation & Security:** Server-side data annotations and model state validation ensuring data integrity.
* **Responsive UI:** Clean layouts leveraging standard HTML5, CSS3, and Bootstrap templates.

---

## 🛠️ Tech Stack & Architecture

* **Backend Framework:** ASP.NET Core (.NET)
* **Architectural Pattern:** Model-View-Controller (MVC)
* **ORM:** Entity Framework Core (Database Context & Migrations)
* **Frontend:** Razor Views (`.cshtml`), Bootstrap, JavaScript
* **Tooling:** Visual Studio / VS Code / .NET CLI

---

## 📂 Project Structure

The project follows standard ASP.NET Core MVC conventions to maximize maintainability, scalability, and readability:

```text
MVCApp/
│
├── Controllers/     # Handle incoming requests, business logic coordination, and return views
├── Models/          # Domain entities, view models, and business data structures
├── Views/           # Razor view templates (.cshtml) rendering the user interface
├── Data/            # Entity Framework DbContext and database initialization logic
├── Migrations/      # EF Core database migration history and schemas
├── wwwroot/         # Static assets (stylesheets, JavaScript files, lib libraries)
├── Program.cs       # Application entry point, dependency injection (DI) container, and middleware pipeline
└── appsettings.json # Environment and application configurations (connection strings, logging)
```

## ⚙️ Getting Started
Follow these instructions to set up, build, and run the project locally on your machine.

## Prerequisites
- .NET SDK installed on your system.

## Installation & Execution
### 1. Clone the repository:
```bash
git clone https://github.com/jluisvacan/MVCApp.git
cd MVCApp
```

### 2. Restore dependencies:
```bash
dotnet restore
```

### 3. Apply database migrations (if applicable):
```bash
dotnet ef database update
```

### 4. Run the application:
```bash
dotnet run
```

### 5. Access the application:
```text
Open your browser and navigate to https://localhost:5062.
```

## 📈 Engineering Best Practices Highlighted
- **Dependency Injection (DI):** Utilizing the native Microsoft IoC container for loosely coupled and testable services.

- **Asynchronous Programming:** Leveraging async/await patterns across database calls to ensure high application throughput and scalability.

- **Maintainable Codebase:** Clean adherence to DRY (Don't Repeat Yourself) and SOLID principles where applicable.