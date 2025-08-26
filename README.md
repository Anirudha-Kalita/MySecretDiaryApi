# MySecretDiaryApi 🔐

A simple but secure ASP.NET Core Web API demonstrating JWT (JSON Web Token) authentication and authorization. This project was built to showcase core security concepts in a modern .NET application.

## ✨ Features

* **JWT Authentication**: Secure login endpoint that generates a signed JWT.
* **Role-Based Authorization**: Protected endpoints that require a specific role (e.g., "Admin") present in the token's claims.
* **Secure Configuration**: Demonstrates the use of `appsettings.json` for general settings and the **User Secrets** tool for sensitive data like the JWT signing key.
* **Swagger/OpenAPI Integration**: Includes a full setup for API testing, including a UI for authorizing requests with a bearer token.

## 🛠️ Technologies Used

* **.NET 8** / C# 12
* **ASP.NET Core Web API**
* **JWT Bearer Authentication**
* **Swagger (Swashbuckle)**

## 🚀 Setup and Installation

Follow these steps to get the project running on your local machine.

### 1. Clone the Repository

```bash
git clone [https://your-repo-url-here.git](https://your-repo-url-here.git)
cd MySecretDiaryApi
