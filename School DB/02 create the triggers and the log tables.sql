

-- Create log table for Users
CREATE TABLE UsersLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT,
    ChangeType VARCHAR(10),  -- 'INSERT', 'UPDATE', 'DELETE'
    ChangedBy VARCHAR(50),    -- Who made the change
    ChangeDate DATETIME DEFAULT GETDATE(),
    OldUsername VARCHAR(50),
    NewUsername VARCHAR(50),
    OldPasswordHash VARBINARY(64),
    NewPasswordHash VARBINARY(64),
    OldRoleID INT,
    NewRoleID INT
);

-- Create log table for Teachers
CREATE TABLE TeachersLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    TeacherID INT,
    ChangeType VARCHAR(10),
    ChangedBy VARCHAR(50),
    ChangeDate DATETIME DEFAULT GETDATE(),
    OldFirstName VARCHAR(50),
    NewFirstName VARCHAR(50),
    OldLastName VARCHAR(50),
    NewLastName VARCHAR(50),
    OldEmail VARCHAR(100),
    NewEmail VARCHAR(100)
);

-- Create log table for Students
CREATE TABLE StudentsLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    ChangeType VARCHAR(10),
    ChangedBy VARCHAR(50),
    ChangeDate DATETIME DEFAULT GETDATE(),
    OldFirstName VARCHAR(50),
    NewFirstName VARCHAR(50),
    OldLastName VARCHAR(50),
    NewLastName VARCHAR(50),
    OldDateOfBirth DATE,
    NewDateOfBirth DATE,
    OldEmail VARCHAR(100),
    NewEmail VARCHAR(100)
);

-- Create log table for Contacts
CREATE TABLE ContactsLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    ContactID INT,
    ChangeType VARCHAR(10),
    ChangedBy VARCHAR(50),
    ChangeDate DATETIME DEFAULT GETDATE(),
    OldPhone VARCHAR(15),
    NewPhone VARCHAR(15)
);

-- Create log table for Classes
CREATE TABLE ClassesLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    ClassID INT,
    ChangeType VARCHAR(10),
    ChangedBy VARCHAR(50),
    ChangeDate DATETIME DEFAULT GETDATE(),
    OldClassName VARCHAR(100),
    NewClassName VARCHAR(100),
    OldGradeLevel INT,
    NewGradeLevel INT,
    OldTeacherID INT,
    NewTeacherID INT
);

-- Create log table for Subjects
CREATE TABLE SubjectsLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    SubjectID INT,
    ChangeType VARCHAR(10),
    ChangedBy VARCHAR(50),
    ChangeDate DATETIME DEFAULT GETDATE(),
    OldSubjectName VARCHAR(100),
    NewSubjectName VARCHAR(100)
);

-- Create log table for Enrollments
CREATE TABLE EnrollmentsLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    EnrollmentID INT,
    ChangeType VARCHAR(10),
    ChangedBy VARCHAR(50),
    ChangeDate DATETIME DEFAULT GETDATE(),
    OldStudentID INT,
    NewStudentID INT,
    OldClassID INT,
    NewClassID INT,
    OldEnrollmentDate DATE,
    NewEnrollmentDate DATE
);

-- Create log table for Grades
CREATE TABLE GradesLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    GradeID INT,
    ChangeType VARCHAR(10),
    ChangedBy VARCHAR(50),
    ChangeDate DATETIME DEFAULT GETDATE(),
    OldGrade FLOAT,
    NewGrade FLOAT,
    OldGradeDate DATE,
    NewGradeDate DATE
);



--==============================================================================


-- Trigger for Users
CREATE TRIGGER trg_Users_Audit
ON Users
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @ChangedBy VARCHAR(50) = SYSTEM_USER;
    
    -- Insert log for INSERT
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        INSERT INTO UsersLog (UserID, ChangeType, ChangedBy, OldUsername, NewUsername, OldPasswordHash, NewPasswordHash, OldRoleID, NewRoleID)
        SELECT 
            i.UserID,
            'INSERT',
            @ChangedBy,
            NULL,
            i.Username,
            NULL,
            i.PasswordHash,
            NULL,
            i.RoleID
        FROM inserted i;
    END
    
    -- Insert log for UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO UsersLog (UserID, ChangeType, ChangedBy, OldUsername, NewUsername, OldPasswordHash, NewPasswordHash, OldRoleID, NewRoleID)
        SELECT 
            d.UserID,
            'UPDATE',
            @ChangedBy,
            d.Username,
            i.Username,
            d.PasswordHash,
            i.PasswordHash,
            d.RoleID,
            i.RoleID
        FROM inserted i
        INNER JOIN deleted d ON i.UserID = d.UserID;
    END
    
    -- Insert log for DELETE
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO UsersLog (UserID, ChangeType, ChangedBy, OldUsername, NewUsername, OldPasswordHash, NewPasswordHash, OldRoleID, NewRoleID)
        SELECT 
            d.UserID,
            'DELETE',
            @ChangedBy,
            d.Username,
            NULL,
            d.PasswordHash,
            NULL,
            d.RoleID,
            NULL
        FROM deleted d;
    END
END;

--===============================
-- Trigger for Teachers
CREATE TRIGGER trg_Teachers_Audit
ON Teachers
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @ChangedBy VARCHAR(50) = SYSTEM_USER;

    -- Insert log for INSERT
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        INSERT INTO TeachersLog (TeacherID, ChangeType, ChangedBy, OldFirstName, NewFirstName, OldLastName, NewLastName, OldEmail, NewEmail)
        SELECT 
            i.TeacherID,
            'INSERT',
            @ChangedBy,
            NULL,
            i.FirstName,
            NULL,
            i.LastName,
            NULL,
            i.Email
        FROM inserted i;
    END

    -- Insert log for UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO TeachersLog (TeacherID, ChangeType, ChangedBy, OldFirstName, NewFirstName, OldLastName, NewLastName, OldEmail, NewEmail)
        SELECT 
            d.TeacherID,
            'UPDATE',
            @ChangedBy,
            d.FirstName,
            i.FirstName,
            d.LastName,
            i.LastName,
            d.Email,
            i.Email
        FROM inserted i
        INNER JOIN deleted d ON i.TeacherID = d.TeacherID;
    END

    -- Insert log for DELETE
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO TeachersLog (TeacherID, ChangeType, ChangedBy, OldFirstName, NewFirstName, OldLastName, NewLastName, OldEmail, NewEmail)
        SELECT 
            d.TeacherID,
            'DELETE',
            @ChangedBy,
            d.FirstName,
            NULL,
            d.LastName,
            NULL,
            d.Email,
            NULL
        FROM deleted d;
    END
END;

--===============================

-- Trigger for Students
CREATE TRIGGER trg_Students_Audit
ON Students
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @ChangedBy VARCHAR(50) = SYSTEM_USER;

    -- Insert log for INSERT
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        INSERT INTO StudentsLog (StudentID, ChangeType, ChangedBy, OldFirstName, NewFirstName, OldLastName, NewLastName, OldDateOfBirth, NewDateOfBirth, OldEmail, NewEmail)
        SELECT 
            i.StudentID,
            'INSERT',
            @ChangedBy,
            NULL,
            i.FirstName,
            NULL,
            i.LastName,
            NULL,
            i.DateOfBirth,
            NULL,
            i.Email
        FROM inserted i;
    END

    -- Insert log for UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO StudentsLog (StudentID, ChangeType, ChangedBy, OldFirstName, NewFirstName, OldLastName, NewLastName, OldDateOfBirth, NewDateOfBirth, OldEmail, NewEmail)
        SELECT 
            d.StudentID,
            'UPDATE',
            @ChangedBy,
            d.FirstName,
            i.FirstName,
            d.LastName,
            i.LastName,
            d.DateOfBirth,
            i.DateOfBirth,
            d.Email,
            i.Email
        FROM inserted i
        INNER JOIN deleted d ON i.StudentID = d.StudentID;
    END

    -- Insert log for DELETE
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO StudentsLog (StudentID, ChangeType, ChangedBy, OldFirstName, NewFirstName, OldLastName, NewLastName, OldDateOfBirth, NewDateOfBirth, OldEmail, NewEmail)
        SELECT 
            d.StudentID,
            'DELETE',
            @ChangedBy,
            d.FirstName,
            NULL,
            d.LastName,
            NULL,
            d.DateOfBirth,
            NULL,
            d.Email,
            NULL
        FROM deleted d;
    END
END;

--===============================
-- Trigger for Contacts
CREATE TRIGGER trg_Contacts_Audit
ON Contacts
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @ChangedBy VARCHAR(50) = SYSTEM_USER;

    -- Insert log for INSERT
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        INSERT INTO ContactsLog (ContactID, ChangeType, ChangedBy, OldPhone, NewPhone)
        SELECT 
            i.ContactID,
            'INSERT',
            @ChangedBy,
            NULL,
            i.Phone
        FROM inserted i;
    END

    -- Insert log for UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO ContactsLog (ContactID, ChangeType, ChangedBy, OldPhone, NewPhone)
        SELECT 
            d.ContactID,
            'UPDATE',
            @ChangedBy,
            d.Phone,
            i.Phone
        FROM inserted i
        INNER JOIN deleted d ON i.ContactID = d.ContactID;
    END

    -- Insert log for DELETE
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO ContactsLog (ContactID, ChangeType, ChangedBy, OldPhone, NewPhone)
        SELECT 
            d.ContactID,
            'DELETE',
            @ChangedBy,
            d.Phone,
            NULL
        FROM deleted d;
    END
END;

--===============================

-- Trigger for Classes
CREATE TRIGGER trg_Classes_Audit
ON Classes
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @ChangedBy VARCHAR(50) = SYSTEM_USER;

    -- Insert log for INSERT
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        INSERT INTO ClassesLog (ClassID, ChangeType, ChangedBy, OldClassName, NewClassName, OldGradeLevel, NewGradeLevel, OldTeacherID, NewTeacherID)
        SELECT 
            i.ClassID,
            'INSERT',
            @ChangedBy,
            NULL,
            i.ClassName,
            NULL,
            i.GradeLevel,
            NULL,
            i.TeacherID
        FROM inserted i;
    END

    -- Insert log for UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO ClassesLog (ClassID, ChangeType, ChangedBy, OldClassName, NewClassName, OldGradeLevel, NewGradeLevel, OldTeacherID, NewTeacherID)
        SELECT 
            d.ClassID,
            'UPDATE',
            @ChangedBy,
            d.ClassName,
            i.ClassName,
            d.GradeLevel,
            i.GradeLevel,
            d.TeacherID,
            i.TeacherID
        FROM inserted i
        INNER JOIN deleted d ON i.ClassID = d.ClassID;
    END

    -- Insert log for DELETE
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO ClassesLog (ClassID, ChangeType, ChangedBy, OldClassName, NewClassName, OldGradeLevel, NewGradeLevel, OldTeacherID, NewTeacherID)
        SELECT 
            d.ClassID,
            'DELETE',
            @ChangedBy,
            d.ClassName,
            NULL,
            d.GradeLevel,
            NULL,
            d.TeacherID,
            NULL
        FROM deleted d;
    END
END;

--===============================

-- Trigger for Subjects
CREATE TRIGGER trg_Subjects_Audit
ON Subjects
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @ChangedBy VARCHAR(50) = SYSTEM_USER;

    -- Insert log for INSERT
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        INSERT INTO SubjectsLog (SubjectID, ChangeType, ChangedBy, OldSubjectName, NewSubjectName)
        SELECT 
            i.SubjectID,
            'INSERT',
            @ChangedBy,
            NULL,
            i.SubjectName
        FROM inserted i;
    END

    -- Insert log for UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO SubjectsLog (SubjectID, ChangeType, ChangedBy, OldSubjectName, NewSubjectName)
        SELECT 
            d.SubjectID,
            'UPDATE',
            @ChangedBy,
            d.SubjectName,
            i.SubjectName
        FROM inserted i
        INNER JOIN deleted d ON i.SubjectID = d.SubjectID;
    END

    -- Insert log for DELETE
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO SubjectsLog (SubjectID, ChangeType, ChangedBy, OldSubjectName, NewSubjectName)
        SELECT 
            d.SubjectID,
            'DELETE',
            @ChangedBy,
            d.SubjectName,
            NULL
        FROM deleted d;
    END
END;

--===============================

-- Trigger for Enrollments
CREATE TRIGGER trg_Enrollments_Audit
ON Enrollments
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @ChangedBy VARCHAR(50) = SYSTEM_USER;

    -- Insert log for INSERT
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        INSERT INTO EnrollmentsLog (EnrollmentID, ChangeType, ChangedBy, OldStudentID, NewStudentID, OldClassID, NewClassID, OldEnrollmentDate, NewEnrollmentDate)
        SELECT 
            i.EnrollmentID,
            'INSERT',
            @ChangedBy,
            NULL,
            i.StudentID,
            NULL,
            i.ClassID,
            NULL,
            i.EnrollmentDate
        FROM inserted i;
    END

    -- Insert log for UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO EnrollmentsLog (EnrollmentID, ChangeType, ChangedBy, OldStudentID, NewStudentID, OldClassID, NewClassID, OldEnrollmentDate, NewEnrollmentDate)
        SELECT 
            d.EnrollmentID,
            'UPDATE',
            @ChangedBy,
            d.StudentID,
            i.StudentID,
            d.ClassID,
            i.ClassID,
            d.EnrollmentDate,
            i.EnrollmentDate
        FROM inserted i
        INNER JOIN deleted d ON i.EnrollmentID = d.EnrollmentID;
    END

    -- Insert log for DELETE
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO EnrollmentsLog (EnrollmentID, ChangeType, ChangedBy, OldStudentID, NewStudentID, OldClassID, NewClassID, OldEnrollmentDate, NewEnrollmentDate)
        SELECT 
            d.EnrollmentID,
            'DELETE',
            @ChangedBy,
            d.StudentID,
            NULL,
            d.ClassID,
            NULL,
            d.EnrollmentDate,
            NULL
        FROM deleted d;
    END
END;

--===============================

-- Trigger for Grades
CREATE TRIGGER trg_Grades_Audit
ON Grades
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @ChangedBy VARCHAR(50) = SYSTEM_USER;

    -- Insert log for INSERT
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        INSERT INTO GradesLog (GradeID, ChangeType, ChangedBy, OldGrade, NewGrade, OldGradeDate, NewGradeDate)
        SELECT 
            i.GradeID,
            'INSERT',
            @ChangedBy,
            NULL,
            i.Grade,
            NULL,
            i.GradeDate
        FROM inserted i;
    END

    -- Insert log for UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO GradesLog (GradeID, ChangeType, ChangedBy, OldGrade, NewGrade, OldGradeDate, NewGradeDate)
        SELECT 
            d.GradeID,
            'UPDATE',
            @ChangedBy,
            d.Grade,
            i.Grade,
            d.GradeDate,
            i.GradeDate
        FROM inserted i
        INNER JOIN deleted d ON i.GradeID = d.GradeID;
    END

    -- Insert log for DELETE
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO GradesLog (GradeID, ChangeType, ChangedBy, OldGrade, NewGrade, OldGradeDate, NewGradeDate)
        SELECT 
            d.GradeID,
            'DELETE',
            @ChangedBy,
            d.Grade,
            NULL,
            d.GradeDate,
            NULL
        FROM deleted d;
    END
END;


--================================================

-- Select statements for UsersLog
SELECT * FROM UsersLog;

-- Select statements for TeachersLog
SELECT * FROM TeachersLog;

-- Select statements for StudentsLog
SELECT * FROM StudentsLog;

-- Select statements for ContactsLog
SELECT * FROM ContactsLog;

-- Select statements for ClassesLog
SELECT * FROM ClassesLog;

-- Select statements for SubjectsLog
SELECT * FROM SubjectsLog;

-- Select statements for EnrollmentsLog
SELECT * FROM EnrollmentsLog;

-- Select statements for GradesLog
SELECT * FROM GradesLog;
