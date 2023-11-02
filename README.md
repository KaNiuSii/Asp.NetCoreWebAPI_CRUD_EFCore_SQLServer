# ASP.NET Core Web API for CRUD Operations

## Project Description

This project is an ASP.NET Core Web API designed to perform CRUD operations for a User entity. It demonstrates the capabilities of RESTful API design using C#, Entity Framework Core, and SQL Server. The API allows clients to create, read, update, and delete user information, including name, phone, and email.

## Installation

To set up this project locally, follow the steps below:

1. Clone the repository to your local machine using:

git clone https://github.com/KaNiuSii/Asp.NetCoreWebAPI_CRUD_EFCore_SQLServer.git

2. Navigate to the project directory:

cd Asp.NetCoreWebAPI_CRUD_EFCore_SQLServer

3. Restore the necessary packages:

dotnet restore

4. Update the database connection string in `appsettings.json` to match your SQL Server instance.
5. Apply the migrations to your database to create the necessary tables:

dotnet ef database update

## Usage

After installation, you can start the API by running:

dotnet run

Here are some of the endpoints provided by the API:

- `GET /api/users`: Retrieves a list of users.
- `GET /api/users/{id}`: Retrieves a user by their ID.
- `POST /api/users`: Creates a new user.
- `PUT /api/users/{id}`: Updates an existing user's information.
- `DELETE /api/users/{id}`: Deletes a user by ID.
