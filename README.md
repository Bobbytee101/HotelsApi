**HotelsApi**

HotelsApi is a RESTful API built with ASP.NET Core, designed to manage hotel data efficiently. It provides endpoints for creating, reading, updating, and deleting hotel information, making it suitable for hotel management systems, booking platforms, or educational purposes.​

**Features**

CRUD operations for hotel entities

Structured project using ASP.NET Core Web API

Entity Framework Core integration for database interactions

Clean architecture following best practices

Prepared for future enhancements like authentication and advanced querying​

**Getting Started**

**Prerequisites**

.NET 6 SDK or later

SQL Server (or modify for your preferred database)

Visual Studio or any compatible IDE​

**Installation**

**Clone the repository​**

git clone https://github.com/Bobbytee101/HotelsApi.git

**Navigate to the project directory​**

cd HotelsApi

**Restore dependencies​**

dotnet restore

**Update the database connection string​**

Modify the appsettings.json file to include your SQL Server connection details:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=HotelsDb;Trusted_Connection=True;"
}

**Apply migrations and update the database​**

dotnet ef database update

**Run the application​**

dotnet run
The API will be available at https://localhost:5001 or http://localhost:5000.

**API Endpoints**

| Method | Endpoint             | Description               |
|--------|----------------------|---------------------------|
| GET    | `/api/hotels`        | Retrieve all hotels       |
| GET    | `/api/hotels/{id}`   | Retrieve a specific hotel |
| POST   | `/api/hotels`        | Create a new hotel        |
| PUT    | `/api/hotels/{id}`   | Update an existing hotel  |
| DELETE | `/api/hotels/{id}`   | Delete a hotel            |
**Note:** Replace `/api/hotels` with the actual route if different in your implementation.

**Technologies Used**

ASP.NET Core Web API
Entity Framework Core
SQL Server
C#​

**Contributing**

Contributions are welcome! If you'd like to contribute, please fork the repository and use a feature branch. Pull requests are warmly welcome.​

**License**

This project is licensed under the MIT License. See the LICENSE file for details.​

**Contact**

For any inquiries or feedback, please contact soetanyusuf359@gmail.com
