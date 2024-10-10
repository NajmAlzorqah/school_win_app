USE SchoolDB

CREATE PROCEDURE InsertRole
    @RoleName VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Roles (RoleName) VALUES (@RoleName);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE UpdateRole
    @RoleID INT,
    @NewRoleName VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Roles SET RoleName = @NewRoleName WHERE RoleID = @RoleID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE DeleteRole
    @RoleID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Roles WHERE RoleID = @RoleID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE GetRoles
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Roles;
END;
GO

--=======================================================
CREATE PROCEDURE InsertUser
    @Username VARCHAR(50),
    @PasswordHash VARBINARY(64),
    @RoleID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Users (Username, PasswordHash, RoleID) VALUES (@Username, @PasswordHash, @RoleID);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE UpdateUser
    @UserID INT,
    @NewUsername VARCHAR(50),
    @NewPasswordHash VARBINARY(64),
    @NewRoleID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Users SET Username = @NewUsername, PasswordHash = @NewPasswordHash, RoleID = @NewRoleID WHERE UserID = @UserID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE DeleteUser
    @UserID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Users WHERE UserID = @UserID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE GetUsers
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Users;
END;
GO


--=======================================================
CREATE PROCEDURE InsertTeacher
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Teachers (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE UpdateTeacher
    @TeacherID INT,
    @NewFirstName VARCHAR(50),
    @NewLastName VARCHAR(50),
    @NewEmail VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Teachers SET FirstName = @NewFirstName, LastName = @NewLastName, Email = @NewEmail WHERE TeacherID = @TeacherID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE DeleteTeacher
    @TeacherID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Teachers WHERE TeacherID = @TeacherID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE GetTeachers
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Teachers;
END;
GO

--=======================================================
CREATE PROCEDURE InsertStudent
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DateOfBirth DATE,
    @Email VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Students (FirstName, LastName, DateOfBirth, Email) VALUES (@FirstName, @LastName, @DateOfBirth, @Email);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE UpdateStudent
    @StudentID INT,
    @NewFirstName VARCHAR(50),
    @NewLastName VARCHAR(50),
    @NewDateOfBirth DATE,
    @NewEmail VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Students SET FirstName = @NewFirstName, LastName = @NewLastName, DateOfBirth = @NewDateOfBirth, Email = @NewEmail WHERE StudentID = @StudentID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
-- ==================================

CREATE PROCEDURE DeleteStudent
    @StudentID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Students WHERE StudentID = @StudentID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE GetStudents
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Students;
END;
GO



--=======================================================
CREATE PROCEDURE InsertContact
    @StudentID INT,
    @Phone VARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Contacts (StudentID, Phone) VALUES (@StudentID, @Phone);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE UpdateContact
    @ContactID INT,
    @NewPhone VARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Contacts SET Phone = @NewPhone WHERE ContactID = @ContactID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE DeleteContact
    @ContactID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Contacts WHERE ContactID = @ContactID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE GetContacts
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Contacts;
END;
GO

--=======================================================
CREATE PROCEDURE InsertClass
    @ClassName VARCHAR(100),
    @GradeLevel INT,
    @TeacherID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Classes (ClassName, GradeLevel, TeacherID) VALUES (@ClassName, @GradeLevel, @TeacherID);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE UpdateClass
    @ClassID INT,
    @NewClassName VARCHAR(100),
    @NewGradeLevel INT,
    @NewTeacherID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Classes SET ClassName = @NewClassName, GradeLevel = @NewGradeLevel, TeacherID = @NewTeacherID WHERE ClassID = @ClassID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE DeleteClass
    @ClassID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        -- First, delete from Grades where the class is referenced via ClassSubjects
        DELETE g
        FROM Grades g
        JOIN ClassSubjects cs ON g.ClassSubjectID = cs.ClassSubjectID
        WHERE cs.ClassID = @ClassID;

        -- Then, delete from Enrollments where the class is referenced
        DELETE FROM Enrollments WHERE ClassID = @ClassID;

        -- Then, delete from ClassSubjects where the class is referenced
        DELETE FROM ClassSubjects WHERE ClassID = @ClassID;

        -- Finally, delete the class itself
        DELETE FROM Classes WHERE ClassID = @ClassID;

        -- Commit the transaction if all deletions succeed
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback the transaction if any error occurs
        ROLLBACK TRANSACTION;

        -- Rethrow the error
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE GetClasses
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Classes;
END;
GO
--=======================================================
CREATE PROCEDURE InsertSubject
    @SubjectName VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Subjects (SubjectName) VALUES (@SubjectName);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE UpdateSubject
    @SubjectID INT,
    @NewSubjectName VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Subjects SET SubjectName = @NewSubjectName WHERE SubjectID = @SubjectID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE DeleteSubject
    @SubjectID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        -- First, delete from ClassSubjects where the subject is referenced
        DELETE FROM ClassSubjects WHERE SubjectID = @SubjectID;

        -- Then, delete the subject itself
        DELETE FROM Subjects WHERE SubjectID = @SubjectID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        -- Rethrow the error
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE GetSubjects
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Subjects;
END;
GO

--=======================================================
CREATE PROCEDURE InsertClassSubject
    @ClassID INT,
    @SubjectID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO ClassSubjects (ClassID, SubjectID) VALUES (@ClassID, @SubjectID);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE DeleteClassSubject
    @ClassSubjectID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM ClassSubjects WHERE ClassSubjectID = @ClassSubjectID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE GetClassSubjects
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM ClassSubjects;
END;
GO

--=======================================================
CREATE PROCEDURE InsertEnrollment
    @StudentID INT,
    @ClassID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Enrollments (StudentID, ClassID, EnrollmentDate) 
        VALUES (@StudentID, @ClassID, GETDATE());
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO



CREATE PROCEDURE DeleteEnrollment
    @EnrollmentID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Enrollments WHERE EnrollmentID = @EnrollmentID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE GetEnrollments
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Enrollments;
END;
GO
--=======================================================
CREATE PROCEDURE InsertGrade
    @StudentID INT,
    @ClassID INT,
    @Grade DECIMAL(5, 2)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Grades (StudentID, ClassSubjectID, Grade) VALUES (@StudentID, @ClassID, @Grade);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE UpdateGrade
    @GradeID INT,
    @NewGrade DECIMAL(5, 2)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Grades SET Grade = @NewGrade WHERE GradeID = @GradeID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE DeleteGrade
    @GradeID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Grades WHERE GradeID = @GradeID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE GetGrades
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Grades;
END;
GO

--=====================================