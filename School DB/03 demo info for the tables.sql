INSERT INTO Roles (RoleName) VALUES
('Admin'),
('Teacher'),
('Student');


INSERT INTO Users (Username, PasswordHash, RoleID) VALUES
('admin', HASHBYTES('SHA2_256', '123'), 1),
('admin1', HASHBYTES('SHA2_256', '123'),1),
('user', HASHBYTES('SHA2_256', '111'), 2),
('student1', HASHBYTES('SHA2_256', 'password123'), 3),
('student2', HASHBYTES('SHA2_256', 'password123'), 3),
('student3', HASHBYTES('SHA2_256', 'password123'), 3),
('student4', HASHBYTES('SHA2_256', 'password123'), 3),
('student5', HASHBYTES('SHA2_256', 'password123'), 3),
('student6', HASHBYTES('SHA2_256', 'password123'), 3),
('student7', HASHBYTES('SHA2_256', 'password123'), 3),
('student8', HASHBYTES('SHA2_256', 'password123'), 3),
('student9', HASHBYTES('SHA2_256', 'password123'), 3),
('student10', HASHBYTES('SHA2_256', 'password123'), 3),
('student11', HASHBYTES('SHA2_256', 'password123'), 3),
('student12', HASHBYTES('SHA2_256', 'password123'), 3),
('student13', HASHBYTES('SHA2_256', 'password123'), 3),
('student14', HASHBYTES('SHA2_256', 'password123'), 3),
('student15', HASHBYTES('SHA2_256', 'password123'), 3),
('student16', HASHBYTES('SHA2_256', 'password123'), 3),
('student17', HASHBYTES('SHA2_256', 'password123'), 3),
('student18', HASHBYTES('SHA2_256', 'password123'), 3),
('student19', HASHBYTES('SHA2_256', 'password123'), 3),
('student20', HASHBYTES('SHA2_256', 'password123'), 3),
('student21', HASHBYTES('SHA2_256', 'password123'), 3),
('student22', HASHBYTES('SHA2_256', 'password123'), 3),
('student23', HASHBYTES('SHA2_256', 'password123'), 3),
('student24', HASHBYTES('SHA2_256', 'password123'), 3),
('student25', HASHBYTES('SHA2_256', 'password123'), 3),
('student26', HASHBYTES('SHA2_256', 'password123'), 3),
('student27', HASHBYTES('SHA2_256', 'password123'), 3),
('student28', HASHBYTES('SHA2_256', 'password123'), 3),
('student29', HASHBYTES('SHA2_256', 'password123'), 3),
('student30', HASHBYTES('SHA2_256', 'password123'), 3);


INSERT INTO Teachers (FirstName, LastName, Email) VALUES
('Omar', 'Khan', 'omar.khan@example.com'),
('Fatima', 'Al-Zahra', 'fatima.alzahra@example.com'),
('Ali', 'Hassan', 'ali.hassan@example.com'),
('Layla', 'Salah', 'layla.salah@example.com'),
('Yasir', 'Abdul', 'yasir.abdul@example.com'),
('Noor', 'Mahmoud', 'noor.mahmoud@example.com'),
('Salim', 'Jamal', 'salim.jamal@example.com'),
('Aisha', 'Nassar', 'aisha.nassar@example.com'),
('Zain', 'Abidin', 'zain.abidin@example.com'),
('Khadija', 'Ali', 'khadija.ali@example.com'),
('Hassan', 'Faris', 'hassan.faris@example.com'),
('Nadia', 'Mohammed', 'nadia.mohammed@example.com'),
('Rami', 'Sayed', 'rami.sayed@example.com'),
('Tariq', 'El-Sayed', 'tariq.elsayed@example.com'),
('Safa', 'Al-Mansoori', 'safa.almansoori@example.com'),
('Alaa', 'Suleiman', 'alaa.suleiman@example.com'),
('Zahra', 'Khalid', 'zahra.khalid@example.com'),
('Ibrahim', 'Tawfiq', 'ibrahim.tawfiq@example.com'),
('Mona', 'Zaki', 'mona.zaki@example.com'),
('Hadi', 'Yusuf', 'hadi.yusuf@example.com'),
('Lina', 'Bashir', 'lina.bashir@example.com'),
('Adnan', 'Hussein', 'adnan.hussein@example.com'),
('Sami', 'Qureshi', 'sami.qureshi@example.com'),
('Nabil', 'Ghanem', 'nabil.ghannem@example.com'),
('Samira', 'Ameen', 'samira.ameen@example.com'),
('Othman', 'Zidan', 'othman.zidan@example.com'),
('Huda', 'Khatib', 'huda.khatib@example.com'),
('Yasmine', 'Shaheen', 'yasmine.shaheen@example.com'),
('Fadi', 'Abu-Mohammad', 'fadi.abumohammad@example.com'),
('Dalia', 'Aref', 'dalia.aref@example.com'),
('Nour', 'Bint', 'nour.bint@example.com');


INSERT INTO Students (FirstName, LastName, DateOfBirth, Email) VALUES
('Ahmed', 'Saeed', '2006-01-15', 'ahmed.saeed@example.com'),
('Sara', 'Mohammed', '2005-02-20', 'sara.mohammed@example.com'),
('Youssef', 'Hossam', '2007-03-25', 'youssef.hossam@example.com'),
('Laila', 'Mohsen', '2006-04-30', 'laila.mohsen@example.com'),
('Khaled', 'Abdel', '2005-05-10', 'khaled.abdel@example.com'),
('Fatma', 'Ali', '2004-06-15', 'fatma.ali@example.com'),
('Omar', 'Khalil', '2007-07-20', 'omar.khalil@example.com'),
('Rana', 'Suleiman', '2006-08-25', 'rana.suleiman@example.com'),
('Nadia', 'Hassan', '2005-09-30', 'nadia.hassan@example.com'),
('Zain', 'Farouk', '2004-10-05', 'zain.farouk@example.com'),
('Salma', 'Nasser', '2007-11-10', 'salma.nasser@example.com'),
('Yasmin', 'Saber', '2006-12-15', 'yasmin.saber@example.com'),
('Bilal', 'Zahran', '2005-01-20', 'bilal.zahran@example.com'),
('Maya', 'Khalid', '2006-02-25', 'maya.khalid@example.com'),
('Ali', 'Nabil', '2004-03-30', 'ali.nabil@example.com'),
('Noor', 'Hadi', '2007-04-10', 'noor.hadi@example.com'),
('Jamal', 'Yusuf', '2006-05-15', 'jamal.yusuf@example.com'),
('Hana', 'Jaber', '2005-06-20', 'hana.jaber@example.com'),
('Samir', 'Abbas', '2007-07-25', 'samir.abbas@example.com'),
('Nour', 'Ibrahim', '2006-08-30', 'nour.ibrahim@example.com'),
('Fadi', 'Rahman', '2004-09-10', 'fadi.rahman@example.com'),
('Amina', 'Sadiq', '2005-10-15', 'amina.sadiq@example.com'),
('Kareem', 'Shukri', '2007-11-20', 'kareem.shukri@example.com'),
('Hiba', 'Nasr', '2006-12-25', 'hiba.nasr@example.com'),
('Mina', 'Tawfiq', '2004-01-15', 'mina.tawfiq@example.com'),
('Layla', 'Masoud', '2006-02-20', 'layla.masoud@example.com'),
('Othman', 'Kamal', '2005-03-25', 'othman.kamal@example.com'),
('Sana', 'Al-Sayed', '2007-04-30', 'sana.alsayed@example.com'),
('Yara', 'Said', '2006-05-10', 'yara.said@example.com'),
('Rami', 'Nuri', '2005-06-15', 'rami.nuri@example.com'),
('Maya', 'Raed', '2004-07-20', 'maya.raed@example.com'),
('Alaa', 'Tariq', '2006-08-25', 'alaa.tariq@example.com'),
('Tariq', 'Mansoor', '2005-09-30', 'tariq.mansoor@example.com'),
('Hassan', 'Salim', '2007-10-05', 'hassan.salim@example.com'),
('Dalia', 'Ihsan', '2006-11-10', 'dalia.ihsan@example.com');


INSERT INTO Contacts (StudentID, Phone) VALUES
(1, '050-123-4567'),
(1, '050-765-4321'),
(2, '050-234-5678'),
(2, '050-876-5432'),
(3, '050-345-6789'),
(3, '050-987-6543'),
(4, '050-456-7890'),
(4, '050-098-7654'),
(5, '050-567-8901'),
(5, '050-109-8765'),
(6, '050-678-9012'),
(6, '050-210-9876'),
(7, '050-789-0123'),
(7, '050-321-0987'),
(8, '050-890-1234'),
(8, '050-432-1098'),
(9, '050-901-2345'),
(9, '050-543-2109'),
(10, '050-012-3456'),
(10, '050-654-3210'),
(11, '050-123-4568'),
(11, '050-765-4320'),
(12, '050-234-5679'),
(12, '050-876-5431'),
(13, '050-345-6780'),
(13, '050-987-6542'),
(14, '050-456-7891'),
(14, '050-098-7653'),
(15, '050-567-8902'),
(15, '050-109-8764'),
(16, '050-678-9013'),
(16, '050-210-9875'),
(17, '050-789-0124'),
(17, '050-321-0986'),
(18, '050-890-1235'),
(18, '050-432-1097'),
(19, '050-901-2346'),
(19, '050-543-2108'),
(20, '050-012-3457'),
(20, '050-654-3219'),
(21, '050-123-4569'),
(21, '050-765-4328'),
(22, '050-234-5680'),
(22, '050-876-5439'),
(23, '050-345-6781'),
(23, '050-987-6548'),
(24, '050-456-7892'),
(24, '050-098-7657'),
(25, '050-567-8903'),
(25, '050-109-8766'),
(26, '050-678-9014'),
(26, '050-210-9874'),
(27, '050-789-0125'),
(27, '050-321-0985'),
(28, '050-890-1236'),
(28, '050-432-1096'),
(29, '050-901-2347'),
(29, '050-543-2107'),
(30, '050-012-3458'),
(30, '050-654-3218');


INSERT INTO Classes (ClassName, GradeLevel, TeacherID) VALUES
('Class A', 1, 1),
('Class B', 1, 1),
('Class C', 2, 2),
('Class D', 2, 2),
('Class E', 3, 3),
('Class F', 3, 3),
('Class G', 4, 4),
('Class H', 4, 4),
('Class I', 5, 5),
('Class J', 5, 5),
('Class K', 6, 6),
('Class L', 6, 6),
('Class M', 7, 7),
('Class N', 7, 7),
('Class O', 8, 8),
('Class P', 8, 8),
('Class Q', 9, 9),
('Class R', 9, 9),
('Class S', 10, 10),
('Class T', 10, 10),
('Class U', 11, 11),
('Class V', 11, 11),
('Class W', 12, 12),
('Class X', 12, 12),
('Class Y', 13, 13),
('Class Z', 13, 13),
('Class AA', 14, 14),
('Class AB', 14, 14),
('Class AC', 15, 15),
('Class AD', 15, 15),
('Class AE', 16, 16);


INSERT INTO Subjects (SubjectName) VALUES
('Mathematics'),
('Science'),
('Arabic Language'),
('English Language'),
('Islamic Studies'),
('History'),
('Geography'),
('Computer Science'),
('Art'),
('Physical Education'),
('Music'),
('Social Studies'),
('Biology'),
('Chemistry'),
('Physics'),
('Health Education'),
('Business Studies'),
('Economics'),
('Psychology'),
('Environmental Studies'),
('Civics'),
('Cultural Studies'),
('Literature'),
('Statistics'),
('Algebra'),
('Geometry'),
('Calculus'),
('Statistics'),
('Drama'),
('Debate'),
('Information Technology');


INSERT INTO ClassSubjects (ClassID, SubjectID) VALUES
(1, 1),
(1, 2),
(1, 3),
(2, 1),
(2, 4),
(2, 5),
(3, 6),
(3, 2),
(3, 1),
(4, 3),
(4, 2),
(4, 5),
(5, 7),
(5, 8),
(5, 9),
(6, 10),
(6, 11),
(6, 12),
(7, 13),
(7, 14),
(7, 15),
(8, 16),
(8, 17),
(8, 18),
(9, 19),
(9, 20),
(9, 21),
(10, 22),
(10, 23),
(10, 24),
(11, 25),
(11, 26),
(11, 27),
(12, 28),
(12, 29),
(12, 30);

INSERT INTO Enrollments (StudentID, ClassID, EnrollmentDate) VALUES
(1, 1, '2022-09-01'),
(1, 2, '2022-09-01'),
(2, 1, '2022-09-01'),
(3, 1, '2022-09-01'),
(4, 2, '2022-09-01'),
(5, 3, '2022-09-01'),
(6, 4, '2022-09-01'),
(7, 5, '2022-09-01'),
(8, 6, '2022-09-01'),
(9, 7, '2022-09-01'),
(10, 8, '2022-09-01'),
(11, 9, '2022-09-01'),
(12, 10, '2022-09-01'),
(13, 11, '2022-09-01'),
(14, 12, '2022-09-01'),
(15, 13, '2022-09-01'),
(16, 14, '2022-09-01'),
(17, 15, '2022-09-01'),
(18, 16, '2022-09-01'),
(19, 17, '2022-09-01'),
(20, 18, '2022-09-01'),
(21, 19, '2022-09-01'),
(22, 20, '2022-09-01'),
(23, 21, '2022-09-01'),
(24, 22, '2022-09-01'),
(25, 23, '2022-09-01'),
(26, 24, '2022-09-01'),
(27, 25, '2022-09-01'),
(28, 26, '2022-09-01'),
(29, 27, '2022-09-01'),
(30, 28, '2022-09-01');


INSERT INTO Grades (StudentID, ClassSubjectID, Grade, GradeDate) VALUES
(1, 1, 85, '2023-06-01'),
(1, 2, 90, '2023-06-01'),
(2, 1, 75, '2023-06-01'),
(3, 1, 88, '2023-06-01'),
(4, 2, 80, '2023-06-01'),
(5, 3, 92, '2023-06-01'),
(6, 4, 78, '2023-06-01'),
(7, 5, 83, '2023-06-01'),
(8, 6, 95, '2023-06-01'),
(9, 7, 67, '2023-06-01'),
(10, 8, 84, '2023-06-01'),
(11, 9, 77, '2023-06-01'),
(12, 10, 89, '2023-06-01'),
(13, 11, 91, '2023-06-01'),
(14, 12, 85, '2023-06-01'),
(15, 13, 93, '2023-06-01'),
(16, 14, 70, '2023-06-01'),
(17, 15, 88, '2023-06-01'),
(18, 16, 82, '2023-06-01'),
(19, 17, 87, '2023-06-01'),
(20, 18, 79, '2023-06-01'),
(21, 19, 76, '2023-06-01'),
(22, 20, 91, '2023-06-01'),
(23, 21, 83, '2023-06-01'),
(24, 22, 90, '2023-06-01'),
(25, 23, 88, '2023-06-01'),
(26, 24, 84, '2023-06-01'),
(27, 25, 76, '2023-06-01'),
(28, 26, 91, '2023-06-01'),
(29, 27, 78, '2023-06-01'),
(30, 28, 82, '2023-06-01');


--================================================================
-- Select all records from Students Table
SELECT * FROM Students;

-- Select all records from Contacts Table
SELECT * FROM Contacts;

-- Select all records from Classes Table
SELECT * FROM Classes;

-- Select all records from Subjects Table
SELECT * FROM Subjects;

-- Select all records from ClassSubjects Table
SELECT * FROM ClassSubjects;

-- Select all records from Enrollments Table
SELECT * FROM Enrollments;

-- Select all records from Grades Table
SELECT * FROM Grades;

-- Example 1: Students with Their Contacts
SELECT s.StudentID, s.FirstName, s.LastName, c.Phone
FROM Students s
JOIN Contacts c ON s.StudentID = c.StudentID;

-- Example 2: Students with Their Classes
SELECT s.StudentID, s.FirstName, s.LastName, c.ClassName
FROM Students s
JOIN Enrollments e ON s.StudentID = e.StudentID
JOIN Classes c ON e.ClassID = c.ClassID;

-- Example 3: Grades of Students with Subjects
SELECT s.FirstName, s.LastName, sub.SubjectName, g.Grade
FROM Grades g
JOIN Students s ON g.StudentID = s.StudentID
JOIN ClassSubjects cs ON g.ClassSubjectID = cs.ClassSubjectID
JOIN Subjects sub ON cs.SubjectID = sub.SubjectID;

