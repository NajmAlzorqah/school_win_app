-- Create Database
CREATE DATABASE SchoolDB;
GO

-- Use the newly created database
USE SchoolDB;
GO

-- Create Roles Table
CREATE TABLE Roles (
    RoleID INT IDENTITY(1,1) PRIMARY KEY,
    RoleName VARCHAR(20) NOT NULL UNIQUE -- 'Student', 'Teacher', 'Admin'
);

-- Create Users Table
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARBINARY(64) NOT NULL,
    RoleID INT NOT NULL,  -- Foreign key to Roles
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID) ON DELETE CASCADE
);





-- Create Teachers Table
CREATE TABLE Teachers (
    TeacherID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE -- Ensuring unique email for teachers
);

-- Create Students Table
CREATE TABLE Students (
    StudentID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE -- Ensuring unique email for students
);

-- Create Contacts Table for Students
CREATE TABLE Contacts (
    ContactID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID) ON DELETE CASCADE
);

-- Create Classes Table
CREATE TABLE Classes (
    ClassID INT IDENTITY(1,1) PRIMARY KEY,
    ClassName VARCHAR(100) NOT NULL,
    GradeLevel INT NOT NULL,  -- Grade level of the class (e.g., 1, 2, 3, etc.)
    TeacherID INT NOT NULL,   -- Foreign key to Teachers
    FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID) ON DELETE CASCADE
);

-- Create Subjects Table
CREATE TABLE Subjects (
    SubjectID INT IDENTITY(1,1) PRIMARY KEY,
    SubjectName VARCHAR(100) NOT NULL
);

-- Create ClassSubjects Table (Intermediate table for Classes and Subjects)
CREATE TABLE ClassSubjects (
    ClassSubjectID INT IDENTITY(1,1) PRIMARY KEY,
    ClassID INT NOT NULL,
    SubjectID INT NOT NULL,
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID) ON DELETE NO ACTION,  -- Prevents cascading on delete
    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID) ON DELETE NO ACTION  -- Prevents cascading on delete
);

-- Create Enrollments Table
CREATE TABLE Enrollments (
    EnrollmentID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT NOT NULL,
    ClassID INT NOT NULL,
    EnrollmentDate DATE NOT NULL,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID) ON DELETE CASCADE,
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID) ON DELETE CASCADE
);

-- Create Grades Table
CREATE TABLE Grades (
    GradeID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT NOT NULL,
    ClassSubjectID INT NOT NULL,  -- Referencing the specific subject for that class
    Grade FLOAT CHECK (Grade >= 0 AND Grade <= 100), -- Assuming grades are out of 100
    GradeDate DATE NOT NULL,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID) ON DELETE CASCADE,
    FOREIGN KEY (ClassSubjectID) REFERENCES ClassSubjects(ClassSubjectID) ON DELETE CASCADE
);

-- If something happened, use these 
--=========================================================

-- Drop Grades Table
DROP TABLE IF EXISTS Grades;

-- Drop Enrollments Table
DROP TABLE IF EXISTS Enrollments;

-- Drop ClassSubjects Table (Intermediate table between Classes and Subjects)
DROP TABLE IF EXISTS ClassSubjects;

-- Drop Subjects Table
DROP TABLE IF EXISTS Subjects;

-- Drop Contacts Table
DROP TABLE IF EXISTS Contacts;

-- Drop Students Table
DROP TABLE IF EXISTS Students;

-- Drop Classes Table
DROP TABLE IF EXISTS Classes;

-- Drop Teachers Table
DROP TABLE IF EXISTS Teachers;

-- Drop Users Table
DROP TABLE IF EXISTS Users;

-- Drop Roles Table
DROP TABLE IF EXISTS Roles;

-- Finally, drop the SchoolDB database
DROP DATABASE IF EXISTS SchoolDB;
