CREATE DATABASE EmployeeManagementSystem;

USE EmployeeManagementSystem;

CREATE TABLE Login (
	loginID INT IDENTITY(1,1) PRIMARY KEY,
	Username VARCHAR(50) NOT NULL UNIQUE,
	Password VARCHAR(100) NOT NULL 
);

INSERT INTO Login (Username, Password)
VALUES ('admin', 'admin123');

CREATE TABLE Employee (
    EmpNo INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DOB DATE NOT NULL,
    Gender VARCHAR(10) CHECK (gender IN ('Male','Female')),
    Address VARCHAR(200),
    Email VARCHAR(100) UNIQUE,
    Mobile VARCHAR(15),
    HomePhone VARCHAR(15),
    DeptName VARCHAR(50),
    Designation VARCHAR(50),
    EmpType VARCHAR(30),
);
