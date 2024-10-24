create database Staffs;

use Staffs;

CREATE TABLE Gender (
    GenderID INT PRIMARY KEY,
    GenderDescription VARCHAR(50) NOT NULL
);

CREATE TABLE Department (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL
);

CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    DateOfBirth DATE NOT NULL,
    GenderID INT,
    DepartmentID INT,
    FOREIGN KEY (GenderID) REFERENCES Gender(GenderID),
    FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID)
);

INSERT INTO Department (DepartmentID, DepartmentName) VALUES 
(1, 'IT'),
(2, 'HR'),
(3, 'SE');

INSERT INTO Gender (GenderID, GenderDescription) VALUES 
(1, 'Male'),
(2, 'Female');

INSERT INTO Employee (EmployeeID, FirstName, LastName, Email, DateOfBirth, GenderID, DepartmentID) VALUES 
(1, 'John', 'Doe', 'john.doe@example.com', '1990-05-15', 1, 1),
(2, 'Jane', 'Smith', 'jane.smith@example.com', '1988-11-22', 2, 2),
(3, 'Alice', 'Johnson', 'alice.johnson@example.com', '1995-03-30', 2, 1),
(4, 'Bob', 'Williams', 'bob.williams@example.com', '1985-07-08', 1, 3);


