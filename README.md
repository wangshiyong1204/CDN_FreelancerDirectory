# CDN Freelancer Directory API

## Description

This project is an ASP.NET Core Web API designed to manage a directory of freelancers. It provides endpoints for registering, updating, retrieving, and deleting freelancer information. This API is built with ASP.NET Core and Entity Framework Core, targeting a MySQL database.

## Features

- CRUD operations for freelancer data.
- Integration with Entity Framework Core.
- MySQL database backend.
- Swagger API documentation.

## Prerequisites

Before you begin, ensure you have met the following requirements:
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/)
- An IDE like [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)

## Setting Up

To get a local copy up and running follow these simple steps.

### Installation

1. Clone the repository:  
   ```bash
   git clone https://github.com/yourusername/CDN_FreelancerDirectory.git
   cd CDN_FreelancerDirectory

2. Restore the .NET packages:  
   dotnet restore

3. Update the appsettings.json file with your MySQL connection details:  
   "ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=CDN_FreelancerDirectory;User=root;Password=your_password;"
}

4. Applying Migrations
   Generate the database schema based on the current model:  
   dotnet ef migrations add InitialCreate  
   dotnet ef database update


### Usage
Run the application:  
dotnet run  
Access the Swagger UI to test the API endpoints by navigating to:  
http://localhost:5000/swagger  
change 5000 to the correct port number  
or use other tools such as Postman for testing

### API Endpoints
GET /api/users: Retrieves all users.  
GET /api/users/{id}: Retrieves a user by ID.  
POST /api/users: Adds a new user.  
PUT /api/users/{id}: Updates an existing user.  
DELETE /api/users/{id}: Deletes a user.  
