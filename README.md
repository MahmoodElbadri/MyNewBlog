# MyNewBlog 

MyNewBlog is a **.NET 9-powered blogging platform** that allows users to create, edit, and interact with blogs. It features **user authentication, blog creation, comments, likes, and JWT-based authentication**.

## 🚀 Features
- User registration and authentication ✅
- Blog creation, editing, and deletion ✅
- Commenting system with user interactions ✅
- Like functionality for blog posts ✅
- Secure authentication using JWT ✅
- OpenAPI (Swagger) documentation ✅
- Logging with **Serilog** ✅
- Repository and Unit of Work patterns for database operations ✅

## 🛠️ Tech Stack
- **Backend:** .NET 9, C#
- **Database:** SQL Server (Entity Framework Core)
- **Authentication:** JWT
- **Logging:** Serilog
- **API Documentation:** Swagger

## 🔧 Installation
1. **Clone the repository**
   ```sh
   git clone https://github.com/yourusername/MyNewBlog.git
   cd MyNewBlog
   ```
2. **Set up the database**
   - Update `appsettings.json` with your SQL Server connection string.
   - Apply migrations:
     ```sh
     dotnet ef database update
     ```
3. **Run the application**
   ```sh
   dotnet run
   ```
4. **Access the API**
   - Swagger UI: `https://localhost:7004/swagger`
   - API Base URL: `https://localhost:7004/api`

## 📌 To-Do (Coming Soon)
- Frontend UI (React or Angular) 🎨
- Role-based authentication 🔐
- Improved error handling ⚠️
- Admin panel for user/blog management 🛠️

## 📄 License
This project is open-source under the **MIT License**.

---

💡 **Feel free to contribute!** Fork the repo and submit a pull request. 🤝
