# BookStore API

This is a simple BookStore API built with **.NET 8 Web API**. I created this project to practice building RESTful APIs, working with controllers and models, and implementing basic CRUD operations. The API also includes Swagger for easy testing and documentation.

## Features

- List all books (GET /api/books)

- Get a single book by ID (GET /api/books/{id})

- Add a new book (POST /api/books)

- Update an existing book (PUT /api/books/{id})

- Delete a book (DELETE /api/books/{id})

- In-memory data storage for simplicity

- Swagger UI for interactive testing

## Project Structure

BookStoreApi/
├── Controllers/       # API controllers
│   └── BooksController.cs
├── Models/            # Book model
│   └── Book.cs
├── Program.cs         # Main entry point
├── BookStoreApi.csproj
├── appsettings.json

## How to Run Locally

1. **Clone the repository:**

   git **clone** https://github.com/shruya/BookStoreApi.git
   **cd** BookStoreApi

2. **Restore dependencies:**

   dotnet restore

3. **Run the API:**

   dotnet run

4. **Open in browser or Postman:**

 - Swagger UI: 
   http://localhost:5106/swagger

 - GET all books: 
   http://localhost:5106/api/books

## Sample JSON for Testing**

POST /api/books – Add a new book:

{
  "title": "My First .NET API Project",
  "author": "Shruti Yadav",
  "price": 499
}

PUT /api/books/1 – Update book with ID 1:

{
  "title": "C# Basics Updated",
  "author": "John Doe",
  "price": 350
}

## Notes

- The API uses in-memory storage, so data resets when the app stops.

- IDs are automatically generated for new books.

- This project is a learning exercise for .NET Web API, controllers, models, and CRUD operations.


## Future Improvements

Connect the API to a real database like SQLite or SQL Server for persistent storage.

Add authentication and authorization for secured access.

Implement search, filtering, and pagination for books.

Add unit tests to ensure API reliability.

## About Me

This project is part of my practice to strengthen my skills in .NET Web API development. It demonstrates how to build a simple, functional API with CRUD operations, Swagger integration, and clean code structure.
