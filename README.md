# Employee Management System

A comprehensive Windows Forms-based desktop application for managing employee records, built with C# and .NET Framework 4.7.2.

## 📋 Table of Contents
- [Overview](#overview)
- [Features](#features)
- [System Requirements](#system-requirements)
- [Technology Stack](#technology-stack)
- [Installation](#installation)
- [Project Structure](#project-structure)
- [Database Setup](#database-setup)
- [Usage](#usage)
- [Screenshots](#screenshots)
- [Getting Started](#getting-started)
- [License](#license)

## 🎯 Overview

The Employee Management System is a desktop application designed to streamline employee data management. It provides a user-friendly interface for managing employee information, including personal details, employment information, and department assignments. The system includes authentication functionality to ensure secure access to the application.

## ✨ Features

- **User Authentication**: Secure login system with username and password validation
- **Employee Management**: Add, update, and retrieve employee records
- **Employee Information Tracking**:
  - Personal Details (Name, Date of Birth, Gender, Address)
  - Contact Information (Email, Mobile Phone, Home Phone)
  - Employment Details (Employee Number, Department, Designation, Employment Type)
- **Database Integration**: SQL Server backend for data persistence
- **Windows Forms GUI**: Intuitive user interface for easy navigation

## 🖥️ System Requirements

- **Operating System**: Windows 10 or higher
- **.NET Framework**: .NET Framework 4.7.2 or higher
- **Database**: Microsoft SQL Server 2016 or higher
- **RAM**: Minimum 2GB RAM
- **Storage**: Minimum 100MB free disk space

## 🛠️ Technology Stack

| Component | Technology |
|-----------|-----------|
| **Language** | C# |
| **Framework** | .NET Framework 4.7.2 |
| **UI Framework** | Windows Forms |
| **Database** | SQL Server 2016+ |
| **IDE** | Visual Studio 2017+ |

## 📦 Installation

### Prerequisites
1. Install Visual Studio 2017 or later
2. Install .NET Framework 4.7.2 (if not already included with Visual Studio)
3. Install SQL Server 2016 or higher
4. Ensure SQL Server Management Studio is available for database setup

### Steps

1. **Clone the Repository**
   ```bash
   git clone https://github.com/it22318466/EmployeeManagementSystem.git
   cd EmployeeManagementSystem
   ```

2. **Open the Solution**
   - Open `EmployeeManagementSystem.sln` in Visual Studio

3. **Set Up Database**
   - Open SQL Server Management Studio
   - Execute the SQL script: `SQL Queries EMS_Database.sql`
   - This will create the database and required tables

4. **Build the Solution**
   - In Visual Studio, go to Build → Build Solution
   - Ensure there are no compilation errors

5. **Run the Application**
   - Press F5 or click Start to run the application
   - Default login credentials:
     - Username: `admin`
     - Password: `admin123`

## 📁 Project Structure

```
EmployeeManagementSystem/
├── EmployeeManagementSystem/              # Main project folder
│   ├── EmployeeManagementSystem.csproj   # Project file
│   ├── Form1Login.cs                     # Login form
│   ├── Form1Login.Designer.cs            # Login form designer
│   ├── Form2MainMenu.cs                  # Main menu form
│   ├── Form2MainMenu.Designer.cs         # Main menu designer
│   ├── Program.cs                        # Application entry point
│   ├── App.config                        # Application configuration
│   └── Properties/                       # Project properties
├── EmployeeManagementSystem.sln          # Visual Studio solution file
├── SQL Queries EMS_Database.sql          # Database initialization script
├── .gitignore                            # Git ignore rules
└── README.md                             # This file
```

## 🗄️ Database Setup

The application uses SQL Server to store employee data. The database is initialized with the following schema:

### Database Structure

**Login Table**
```sql
CREATE TABLE Login (
    loginID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(100) NOT NULL
);
```

**Employee Table**
```sql
CREATE TABLE Employee (
    EmpNo INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DOB DATE NOT NULL,
    Gender VARCHAR(10),
    Address VARCHAR(200),
    Email VARCHAR(100) UNIQUE,
    Mobile VARCHAR(15),
    HomePhone VARCHAR(15),
    DeptName VARCHAR(50),
    Designation VARCHAR(50),
    EmpType VARCHAR(30)
);
```

**Initial Login Credentials**
- Username: `admin`
- Password: `admin123`

## 🚀 Usage

### Starting the Application
1. Run the executable or launch from Visual Studio
2. The login form will appear
3. Enter your credentials and click Login
4. The main menu will display after successful authentication

### Main Features
- **Add Employee**: Create new employee records with all required information
- **Update Employee**: Modify existing employee details
- **View Employee**: Search and display employee information
- **Delete Employee**: Remove employee records (if authorized)
- **Generate Reports**: Export employee data (if configured)

## 📸 Screenshots

![Login Screen](EmployeeManagementSystem/Resources/Screenshot%202024-03-24%20110522.png)

## 🎓 Getting Started for Developers

### Building the Project
```bash
# Open the solution in Visual Studio or use command line
dotnet build EmployeeManagementSystem.sln
```

### Debugging
- Set breakpoints in the code
- Press F5 to start debugging
- Use the Debug menu for step-through debugging

### Database Connection
The application connects to SQL Server using connection strings defined in `App.config`. Ensure your SQL Server instance is running before launching the application.

## 📝 Project Information

- **Repository**: [GitHub - it22318466/EmployeeManagementSystem](https://github.com/it22318466/EmployeeManagementSystem)
- **Created**: January 26, 2026
- **Language**: C# (100%)
- **Status**: Active Development
- **Stars**: 22

## 🤝 Contributing

Contributions are welcome! To contribute:
1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 📧 Contact

For questions, suggestions, or support, please reach out to the project maintainer:
- GitHub: [@it22318466](https://github.com/it22318466)

## 🔗 Useful Links

- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Windows Forms Documentation](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
- [SQL Server Documentation](https://docs.microsoft.com/en-us/sql/sql-server/)
- [Visual Studio Documentation](https://docs.microsoft.com/en-us/visualstudio/)

---

**Last Updated**: July 9, 2026

For the latest updates and information, visit the [GitHub repository](https://github.com/it22318466/EmployeeManagementSystem).
