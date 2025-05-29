#  Fleet Component Tracker

**Fleet Component Tracker** is a Blazor Server application designed to manage railway component data. It allows users to upload csv, view, edit, and analyze components linked to a fleet of vehicles. The solution is built with .NET 9, Entity Framework Core, and SQLite.

---

##  Features

- Upload and validate component data via CSV files
- View, sort, and filter components in a dynamic grid
- CRUD operations on component entries
- Dashboard view with summaries:
  - Total number of vehicles
  - Average vehicle age
  - Average number of components per vehicle
  - Earliest Date into Service
  - Last Date into Service
- Clean, responsive UI using Bootstrap
- Data persisted using SQLite 


##  Architecture

**Layered Architecture with SOLID Principles**

- **UI Layer:** Blazor '.razor' pages (server-side)
- **Service Layer:** Business logic via 'TrainComponentManagement' service
- **Data Access Layer:** `ApplicationDbContext` using EF Core
- **Design Patterns:**  
  - Dependency Injection  
  - Single Responsibility Principle (SRP)  
  - Separation of Concerns (SoC)

---

## Tech Stack

- Blazor Server (.NET 9)
- Entity Framework Core
- SQLite
- Bootstrap for UI

---

##  Getting Started

### Prerequisites
- .NET 9 SDK
- Visual Studio 2022



### Run the project

1. Clone the repository: git clone https://github.com/krishna186/TrainSolution_ServerApp.git
