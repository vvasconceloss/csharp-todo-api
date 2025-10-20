# Todo List API

A minimal RESTful API built with **C# .NET**, **Entity Framework Core**, and **SQLite**.

## Overview

This project is a learning exercise to understand how to build APIs in C# .NET using EF Core and authentication.

## Goals

Skills developed in this project:

* User authentication
* Schema design and databases
* RESTful API design
* CRUD operations
* Error handling
* Security

## Requirements

The API includes the following features:

* **User registration** to create a new user
* **Login endpoint** to authenticate the user and generate a token
* **CRUD operations** for managing the to-do list
* **User authentication** for protected routes
* **Error handling** and **security measures**
* **Database persistence** using EF Core with SQLite
* **Data validation**
* **Pagination and filtering** for the to-do list

## Tech Stack

* .NET 9
* Entity Framework Core
* SQLite
* JWT Authentication
* Swagger for API testing

## Project Structure

```
TodoListApi/
├── Context/
│   └── AppDbContext.cs
├── Controllers/
│   ├── AuthController.cs
│   └── TodosController.cs
├── DTOs/
│   └── UserDTO.cs
├── Exceptions/
│   ├── BadRequestException.cs
│   ├── BaseException.cs
│   ├── ConflictException.cs
│   ├── NotFoundException.cs
│   └── UnauthorizedException.cs
├── Interfaces/
│   ├── Repoitories
│   │   └── IAuthRepository.cs
│   └── Services
│   │   └── IAuthService.cs
├── Middlewares/
│   └── ExceptionHandlingMiddleware.cs
├── Models/
│   ├── User.cs
│   └── Todo.cs
├── Repositories/
│   └── AuthRepository.cs
├── Services/
│   └── AuthService.cs
├── Validations/
│   └── UserCreateDTOValidator.cs
├── Program.cs
└── appsettings.json
```

## Main Endpoints

| Method | Endpoint        | Description                        |
| ------ | --------------- | ---------------------------------- |
| POST   | user/register   | Register a new user                |
| POST   | user/login      | Authenticate user and return token |
| GET    | /todos          | Get paginated list of todos        |
| POST   | /todos          | Create new todo                    |
| PUT    | /todos/{id}     | Update existing todo               |
| DELETE | /todos/{id}     | Delete existing todo               |

## Run Instructions

```bash
dotnet restore
dotnet ef database update
dotnet run
```

API available at: `http://localhost:5153`

## Notes

* Passwords are hashed before being stored.
* JWT tokens are used for authentication.
* This project is for educational purposes only.
