-- Create Non-Clustered Indexes for Users Table
CREATE NONCLUSTERED INDEX IX_Username ON Users(Username);
CREATE NONCLUSTERED INDEX IX_RoleID ON Users(RoleID);

-- Create Non-Clustered Indexes for Teachers Table
CREATE NONCLUSTERED INDEX IX_TeacherEmail ON Teachers(Email);

-- Create Non-Clustered Indexes for Students Table
CREATE NONCLUSTERED INDEX IX_StudentEmail ON Students(Email);
CREATE NONCLUSTERED INDEX IX_StudentDOB ON Students(DateOfBirth);

-- Create Non-Clustered Indexes for Contacts Table
CREATE NONCLUSTERED INDEX IX_StudentID ON Contacts(StudentID);
CREATE NONCLUSTERED INDEX IX_Phone ON Contacts(Phone);

-- Create Non-Clustered Indexes for Classes Table
CREATE NONCLUSTERED INDEX IX_ClassName ON Classes(ClassName);
CREATE NONCLUSTERED INDEX IX_TeacherID ON Classes(TeacherID);

-- Create Non-Clustered Indexes for Subjects Table
CREATE NONCLUSTERED INDEX IX_SubjectName ON Subjects(SubjectName);

-- Create Non-Clustered Indexes for ClassSubjects Table
CREATE NONCLUSTERED INDEX IX_ClassID ON ClassSubjects(ClassID);
CREATE NONCLUSTERED INDEX IX_SubjectID ON ClassSubjects(SubjectID);

-- Create Non-Clustered Indexes for Enrollments Table
CREATE NONCLUSTERED INDEX IX_StudentID_Enrollment ON Enrollments(StudentID);
CREATE NONCLUSTERED INDEX IX_ClassID_Enrollment ON Enrollments(ClassID);
CREATE NONCLUSTERED INDEX IX_EnrollmentDate ON Enrollments(EnrollmentDate);

-- Create Non-Clustered Indexes for Grades Table
CREATE NONCLUSTERED INDEX IX_StudentID_Grade ON Grades(StudentID);
CREATE NONCLUSTERED INDEX IX_ClassSubjectID ON Grades(ClassSubjectID);
CREATE NONCLUSTERED INDEX IX_GradeDate ON Grades(GradeDate);
