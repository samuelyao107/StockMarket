# Stock Market Management System

This project is a **Stock Market Management System** built with **ASP.NET Core 8.0** and **Entity Framework Core**. It allows users to manage their stock portfolios, leave comments on specific stocks, and view stock details. The system also includes JWT authentication for secure access.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Database Setup](#database-setup)
- [Running the Application](#running-the-application)
- [API Endpoints](#api-endpoints)
- [Authentication](#authentication)
- [Contributing](#contributing)
- [License](#license)

## Features

- **User Authentication** using JWT tokens with ASP.NET Identity.
- **Portfolio Management**: Users can maintain a list of stocks in their portfolios.
- **Comments**: Users can add comments on specific stocks.
- **Stock Management**: Stock information such as company name, symbol, purchase price, and market capitalization is available.
- **Swagger Integration**: The project uses Swagger for API documentation.
- **CORS Support**: Cross-Origin Resource Sharing is enabled.

## Technologies Used

- **ASP.NET Core 8.0**
- **Entity Framework Core 8.0** with **SQL Server**
- **Microsoft.AspNetCore.Identity**
- **JWT Authentication**
- **Newtonsoft.Json**
- **Swashbuckle.AspNetCore** for Swagger documentation

## Project Structure

The main components of the project are:

- **Models**: Define the data structure for users, portfolios, stocks, and comments.
  - `AppUser`: Inherits from `IdentityUser` and represents the users in the system.
  - `Comment`: Represents user comments on a particular stock.
  - `Portofolio`: Defines the relationship between users and their stock portfolios.
  - `Stock`: Stores stock-related information such as company name, symbol, and market cap.
  
- **Repositories**: Handle data access logic for stocks, portfolios, and comments.
- **Services**: Handle business logic, including JWT token generation.

## Getting Started

### Prerequisites

To run this project, you will need:

- **.NET SDK 8.0 or higher**: [Download here](https://dotnet.microsoft.com/download)
- **SQL Server** for the database
- **Visual Studio** or **VS Code** for development

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/samuelyao107/StockMarket.git
   cd stock-market-management
2. Install dependencies by restoring NuGet packages:
    ```bash
   dotnet restore
### Database Setup
1. Update the appsettings.json file with your SQL Server connection string:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=StockMarketDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
2. Apply the database migrations to set up the necessary tables:
    ```bash
dotnet ef database update
### Running the Application

1. Run the application using the following command:
   dotnet run
2. Open your browser and navigate to https://localhost:5001/swagger to view the Swagger API documentation.

### API Endpoints

Below are the primary API endpoints exposed by the application:

User Authentication
POST /api/auth/login: Authenticate a user and receive a JWT token.
POST /api/auth/register: Register a new user.
Stock Management
GET /api/stocks: Get a list of all stocks.
GET /api/stocks/{id}: Get details of a specific stock.
Portfolio Management
GET /api/portfolios: Get the current user's portfolio.
POST /api/portfolios: Add a stock to the user's portfolio.
DELETE /api/portfolios/{id}: Remove a stock from the portfolio.
Comments
POST /api/comments: Add a comment to a stock.
GET /api/comments: Get all comments for a specific stock.

### Authentication
Authorization: Bearer YOUR_TOKEN
You can get a token by logging in via the /api/auth/login endpoint.

### Contributing
Contributions are welcome! To contribute:

1. Fork the project.
2. Create a new branch for your feature or bugfix.
3. Commit your changes.
4. Submit a pull request.
Please ensure all new code is properly tested.


