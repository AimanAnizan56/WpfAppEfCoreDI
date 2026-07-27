
# WPF Architecture & Package Exploration

A sandbox Windows Presentation Foundation (WPF) application built to explore modern .NET architecture patterns, dependency management, and Object-Relational Mapping (ORM).

## 🚀 Project Objectives

This project serves as a local testing ground to understand how enterprise-level packages integrate into a desktop application environment.

### 1. Dependency Injection (Microsoft.Extensions.DependencyInjection)
* **Goal**: Learn how to implement loosely coupled, highly modular code.
* **Focus**: Injecting services, view models, and database contexts cleanly across the application.

### 2. ORM & Database Migration (Entity Framework Core)
* **Goal**: Master ORM workflows, database connections, and entities.
* **Current Database**: Microsoft Access.
* **Next Steps**: Introduce a new database type (e.g., SQLite or SQL Server) to test how easily EF Core and DI allow switching database providers without breaking the core logic.
* **Tools Used**: `dotnet ef cli` for managing database migrations.

### 3. Application Lifecycle Host (Microsoft.Extensions.Hosting)
* **Goal**: Leverage a generic host as a central management system.
* **Current Status**: Simplifying application configuration, startup, and service registration.
* **Next Steps**: Explore built-in logging services, background tasks, and repository patterns.

## 🛠️ Main Tech Stack
* **UI Framework**: WPF (.NET)
* **Packages**: 
  * `Microsoft.Extensions.DependencyInjection`
  * `Microsoft.EntityFrameworkCore`
  * `Microsoft.Extensions.Hosting`
