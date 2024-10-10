/*Description of Each View:
StudentEnrollments: Displays students and their enrolled classes along with teachers.
TeacherClasses: Shows teachers and the classes they teach.
ClassGrades: Provides student grades for subjects in their classes.
StudentContacts: Lists student contact information.
EnrollmentStatistics: Counts the number of students enrolled in each class.
StudentGrades: Calculates the average grade for each student.
ClassSubjectsView: Displays classes along with their subjects.
StudentEnrollmentDetails: Shows student enrollment dates along with their classes.
TeacherSubjects: Lists teachers and the subjects they teach.
UserRoles: Displays user details and their corresponding roles.*/
	--==================================================
	-- Select statement for Student Enrollments
SELECT * FROM StudentEnrollments;

-- Select statement for Teacher Classes
SELECT * FROM TeacherClasses;

-- Select statement for Class Grades
SELECT * FROM ClassGrades;

-- Select statement for Contacts of Students
SELECT * FROM StudentContacts;

-- Select statement for Enrollment Statistics
SELECT * FROM EnrollmentStatistics;

-- Select statement for All Students and Their Grades
SELECT * FROM StudentGrades;

-- Select statement for Classes and Subjects
SELECT * FROM ClassSubjectsView;

-- Select statement for All Students with Enrollment Dates
SELECT * FROM StudentEnrollmentDetails;

-- Select statement for Teacher and Their Subjects
SELECT * FROM TeacherSubjects;

-- Select statement for User Roles
SELECT * FROM UserRoles;
--===============================================

USE SchoolDB

-- Create View for Student Enrollments
CREATE VIEW StudentEnrollments AS
SELECT 
    s.StudentID,
	c.ClassID,
    s.FirstName AS StudentFirstName,
    s.LastName AS StudentLastName,
    c.ClassName,
    t.FirstName AS TeacherFirstName,
    t.LastName AS TeacherLastName,
    e.EnrollmentDate
FROM 
    Students s
JOIN 
    Enrollments e ON s.StudentID = e.StudentID
JOIN 
    Classes c ON e.ClassID = c.ClassID
JOIN 
    Teachers t ON c.TeacherID = t.TeacherID;

-- Create View for Teacher Classes
CREATE VIEW TeacherClasses AS
SELECT 
    t.TeacherID,
    t.FirstName AS TeacherFirstName,
    t.LastName AS TeacherLastName,
    c.ClassName,
    c.GradeLevel
FROM 
    Teachers t
JOIN 
    Classes c ON t.TeacherID = c.TeacherID;

-- Create View for Class Grades
CREATE VIEW ClassGrades AS
SELECT 
    s.StudentID,
    s.FirstName AS StudentFirstName,
    s.LastName AS StudentLastName,
    c.ClassName,
	c.ClassID,
    sub.SubjectName,
	g.GradeID,
    g.Grade,
    g.GradeDate
FROM 
    Grades g
JOIN 
    Students s ON g.StudentID = s.StudentID
JOIN 
    ClassSubjects cs ON g.ClassSubjectID = cs.ClassSubjectID
JOIN 
    Classes c ON cs.ClassID = c.ClassID
JOIN 
    Subjects sub ON cs.SubjectID = sub.SubjectID;
DROP VIEW ClassGrades 

-- Create View for Contacts of Students
CREATE VIEW StudentContacts AS
SELECT 
    s.StudentID,
    s.FirstName AS StudentFirstName,
    s.LastName AS StudentLastName,
    c.Phone AS ContactPhone
FROM 
    Students s
JOIN 
    Contacts c ON s.StudentID = c.StudentID;

-- Create View for Enrollment Statistics
CREATE VIEW EnrollmentStatistics AS
SELECT 
    c.ClassName,
    COUNT(e.StudentID) AS TotalEnrollments
FROM 
    Classes c
LEFT JOIN 
    Enrollments e ON c.ClassID = e.ClassID
GROUP BY 
    c.ClassName;

-- Create View for All Students and Their Grades
CREATE VIEW StudentGrades AS
SELECT 
    s.StudentID,
    s.FirstName AS StudentFirstName,
    s.LastName AS StudentLastName,
    AVG(g.Grade) AS AverageGrade
FROM 
    Students s
JOIN 
    Grades g ON s.StudentID = g.StudentID
GROUP BY 
    s.StudentID, s.FirstName, s.LastName;

-- Create View for Classes and Subjects
CREATE VIEW ClassSubjectsView AS
SELECT 
    c.ClassID,
    c.ClassName,
	c.GradeLevel,
	c.TeacherID,
    sub.SubjectName
FROM 
    Classes c
JOIN 
    ClassSubjects cs ON c.ClassID = cs.ClassID
JOIN 
    Subjects sub ON cs.SubjectID = sub.SubjectID;


	
SELECT * FROM ClassSubjectsView csv

-- Create View for All Students with Enrollment Dates
CREATE VIEW StudentEnrollmentDetails AS
SELECT 
    s.StudentID,
    s.FirstName AS StudentFirstName,
    s.LastName AS StudentLastName,
    e.EnrollmentID,
	e.EnrollmentDate,
	c.ClassID,
    c.ClassName
FROM 
    Students s
JOIN 
    Enrollments e ON s.StudentID = e.StudentID
JOIN 
    Classes c ON e.ClassID = c.ClassID;

	SELECT * FROM Enrollments
	DROP VIEW StudentEnrollmentDetails

-- Create View for Teacher and Their Subjects
CREATE VIEW TeacherSubjects AS
SELECT 
    t.TeacherID,
    t.FirstName AS TeacherFirstName,
    t.LastName AS TeacherLastName,
	t.Email,
    sub.SubjectName
FROM 
    Teachers t
JOIN 
    Classes c ON t.TeacherID = c.TeacherID
JOIN 
    ClassSubjects cs ON c.ClassID = cs.ClassID
JOIN 
    Subjects sub ON cs.SubjectID = sub.SubjectID;

-- Create View for User Roles
CREATE VIEW UserRoles AS
SELECT 
    u.UserID,
    u.Username,
    r.RoleName
FROM 
    Users u
JOIN 
    Roles r ON u.RoleID = r.RoleID;


