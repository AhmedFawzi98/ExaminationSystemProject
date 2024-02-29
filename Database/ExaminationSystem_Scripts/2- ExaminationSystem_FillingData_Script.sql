----------------------------------------FILLING Examination_System Database -------------------------------------------------------------------------
GO
USE Examination_System_Final
GO
-----------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------- TRUNCATE ALL TABLES -----------------------------------------------------------------------------------
--GO
--TRUNCATE TABLE Courses
--GO
--TRUNCATE TABLE Department
--GO
--TRUNCATE TABLE Exam
--GO
--TRUNCATE TABLE Exam_Questions
--GO
--TRUNCATE TABLE Instructor
--GO
--TRUNCATE TABLE Instructor_Course
--GO
--TRUNCATE TABLE Question
--GO
--TRUNCATE TABLE Question_Choices
--GO
--TRUNCATE TABLE Student
--GO
--TRUNCATE TABLE Student_Course
--GO
--TRUNCATE TABLE Student_Exam_Questions
--GO
--TRUNCATE TABLE Topic
--GO
---------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------- FILLING Database Dummy Data --------------------------------------------------------------------------------

------------------------------------ 1- FILLING Courses TABLE WITH DATA ---------------------------------------------------------------------------------
INSERT INTO Courses (Cr_ID, Cr_Name)
VALUES 
    (100, 'C#'),
    (200, 'C++'),
    (300, 'JavaScript'),
    (400, 'SQL'),
    (500, 'HTML');
GO
------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------ 2- FILLING Department TABLE WITH DATA ---------------------------------------------------------------------------------
INSERT INTO Department (Dept_Name, Dept_Description, Location, MGR_ID, MGR_HireDate)
VALUES
    ('HR', NULL, 'Cairo', NULL, '2021-05-15T10:30:00'),
    ('IT', NULL, 'Giza', NULL, '2020-06-20T09:45:00'),
    ('SD', NULL, 'Cairo', NULL, '2022-01-10T14:20:00'),
  ('OpenSource', NULL, 'Giza', NULL, '2021-08-05T11:10:00'),
	('GraphicDesign', NULL, 'Cairo', NULL, '2020-12-03T13:45:00'),
    ('Embedded', NULL, 'Alex', NULL, '2022-05-25T08:55:00'),
    ('Ui/Ux', NULL, 'Cairo', NULL, '2021-07-08T16:30:00'),
    ('VideoEffects Support', NULL, 'Giza', NULL, '2020-09-12T12:15:00'),
    ('Testing', NULL, 'Cairo', NULL, '2022-02-18T09:20:00'),
    ('Networks', NULL, 'Giza', NULL, '2021-04-02T14:50:00');
GO
------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------ 3- FILLING Instructor TABLE WITH DATA ---------------------------------------------------------------------------------
INSERT INTO Instructor (Ins_Name, Ins_Salary, Ins_Degree, Dept_ID, Username)
VALUES
    ('ahmedfawzi', 12000, 'Ph.D.', NULL, 'ahmedfawziinstructor'),
    ('mostafafoad', 8000, 'M.Sc.', NULL, 'mostafafoadinstructor'),
    ('mostafaayman', 15000, 'B.Sc.', NULL, 'mostafaaymaninstructor'),
    ('ibrahimhassan', 10000, 'M.Sc.', NULL, 'ibrahimhassaninstructor'),
    ('moazsamy', 18000, 'Ph.D.', NULL, 'moazsamyinstructor'),
	('engrami', 20000, 'Ph.D.', NULL, 'engramiinstructor'),
    ('Ahmed', 12000, 'Ph.D.', NULL, 'Ahmed'),
    ('Sara', 8000, 'M.Sc.', NULL, 'Sara'),
    ('Omar', 15000, 'B.Sc.', NULL, 'Omar'),
    ('Layla', 10000, 'M.Sc.', NULL, 'Layla'),
    ('Khalid', 18000, 'Ph.D.', NULL, 'Khalid'),
    ('Nadia', 5000, 'B.Sc.', NULL, 'Nadia'),
    ('Youssef', 9000, 'M.Sc.', NULL, 'Youssef'),
    ('Fatima', 7000, 'B.Sc.', NULL, 'Fatima'),
    ('Ali', 25000, 'Ph.D.', NULL, 'Ali'),
    ('Aisha', 3000, 'B.Sc.', NULL, 'Aisha'),
    ('Hassan', 13000, 'Ph.D.', NULL, 'Hassan'),
    ('Maha', 6000, 'B.Sc.', NULL, 'Maha'),
    ('Nasser', 11000, 'M.Sc.', NULL, 'Nasser'),
    ('Rania', 14000, 'Ph.D.', NULL, 'Rania'),
    ('Bassam', 7000, 'B.Sc.', NULL, 'Bassam'),
    ('Huda', 16000, 'Ph.D.', NULL, 'Huda'),
    ('Khalid2', 9000, 'M.Sc.', NULL, 'Khalid2'),
    ('Nada', 12000, 'Ph.D.', NULL, 'Nada'),
    ('Rami', 10000, 'B.Sc.', NULL, 'Rami'),
    ('Dina', 8000, 'M.Sc.', NULL, 'Dina'),
    ('Samir', 15000, 'Ph.D.', NULL, 'Samir'),
    ('Jihan', 4000, 'B.Sc.', NULL, 'Jihan'),
    ('Adel', 17000, 'M.Sc.', NULL, 'Adel'),
    ('Nadia2', 11000, 'Ph.D.', NULL, 'Nadia2'),
    ('Fares', 14000, 'B.Sc.', NULL, 'Fares'),
    ('Laila2', 6000, 'M.Sc.', NULL, 'Laila2'),
    ('Ziad', 12000, 'Ph.D.', NULL, 'Ziad'),
    ('Nada2', 7000, 'B.Sc.', NULL, 'Nada2'),
    ('Tamer', 10000, 'M.Sc.', NULL, 'Tamer'),
    ('Nisreen', 18000, 'Ph.D.', NULL, 'Nisreen'),
    ('Omar2', 9000, 'B.Sc.', NULL, 'Omar2'),
    ('Samar', 13000, 'M.Sc.', NULL, 'Samar'),
    ('Majida', 5000, 'Ph.D.', NULL, 'Majida'),
    ('Mazen', 14000, 'B.Sc.', NULL, 'Mazen'),
    ('Rasha', 7000, 'M.Sc.', NULL, 'Rasha'),
    ('Bassem2', 16000, 'Ph.D.', NULL, 'Bassem2'),
    ('Roula', 11000, 'B.Sc.', NULL, 'Roula'),
    ('Hassan2', 9000, 'M.Sc.', NULL, 'Hassan2'),
    ('Maha2', 12000, 'Ph.D.', NULL, 'Maha2'),
    ('Nasser2', 8000, 'B.Sc.', NULL, 'Nasser2'),
    ('Rania2', 15000, 'M.Sc.', NULL, 'Rania2'),
    ('Bassam2', 10000, 'Ph.D.', NULL, 'Bassam2'),
    ('Huda2', 14000, 'B.Sc.', NULL, 'Huda2'),
    ('Khalid3', 7000, 'M.Sc.', NULL, 'Khalid3'),
    ('Nada3', 16000, 'Ph.D.', NULL, 'Nada3'),
    ('Rami2', 11000, 'B.Sc.', NULL, 'Rami2'),
    ('Dina2', 9000, 'M.Sc.', NULL, 'Dina2');
GO
------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------ 4- FILLING Topic TABLE WITH DATA --------------------------------------------------------------------------------------
INSERT INTO Topic (Topic_Name, Cr_ID)
VALUES
('Introduction', 100),
('Basic Syntax', 100),
('Data Types', 100),
('Variables', 100),
('Operators', 100),
('Control Statements', 100),
('Classes and Objects', 100),
('Inheritance', 100),
('Polymorphism', 100),
('Exception Handling', 100),
('STL', 200),
('Basic Concepts', 200),
('Functions', 200),
('Classes and Objects', 200),
('Inheritance', 200),
('Polymorphism', 200),
('Operator Overloading', 200),
('STL', 200),
('Introduction', 300),
('Variables', 300),
('Operators', 300),
('Control Statements', 300),
('Functions', 300),
('Objects', 300),
('Events', 300),
('Cookies', 300),
('Regular Expressions', 300),
('Introduction', 400),
('Basic Queries', 400),
('Joins', 400),
('Constraints', 400),
('Functions', 400),
('Transactions', 400),
('Indexes', 400),
('Views', 400),
('Stored Procedures', 400),
('Introduction', 500),
('Basic Structure', 500),
('Elements', 500),
('Attributes', 500),
('Headings', 500),
('Paragraphs', 500),
('Formatting', 500),
('Links', 500),
('Images', 500),
('Lists', 500),
('Tables', 500),
('Forms', 500),
('Entities', 500),
('Frames', 500),
('Colors', 500),
('Text', 500),
('Layout', 500),
('Grid', 500);
GO
----------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------ 4- FILLING STUDENT TABLE WITH DATA  ---------------------------------------------------------------------------------
INSERT INTO Student (St_Name, Username, St_Email, St_Phone, St_Age, Street, City, Zip_Code, Dept_ID)
VALUES
('Mostafa Ayman', 'mostafaaymanstudent', 'mostafaayman1@gmail.com', '23123123', 24, '1 Nile St', 'Cairo', '12345', NULL),
('Moaz Samy', 'moazsamystudent', 'moazsamy1@gmail.com', '23423432423', 24, '1 Nile St', 'Cairo', '12345', NULL),
('Mostafa Foad', 'mostafafoadstudent', 'mostafafoad1@gmail.com', '324234234', 24, '1 Nile St', 'Cairo', '12345', NULL),
('Ibrahim Hassan', 'ibrahimhassanstudent', 'ibrahimhassan1@gmail.com', '234234123', 24, '1 Nile St', 'Cairo', '12345', NULL),
('Ahmed Fawzi', 'ahmedfawzistudent', 'ahmedfawzi1@gmail.com', '123234234', 24, '1 Nile St', 'Cairo', '12345', NULL),
('Ahmed Mohamed', 'AhmedMohamed', 'ahmed.mohamed1@gmail.com', '01112345678', 24, '1 Nile St', 'Cairo', '12345', NULL),
('Fatima Ali', 'FatimaAli', 'fatima.ali1@yahoo.com', '01223456789', 26, '2 Sphinx St', 'Giza', '67890', NULL),
('Amr Hassan', 'AmrHassan', 'amr.hassan1@hotmail.com', '01534567890', 23, '3 Pyramids St', 'Giza', '54321', NULL);
GO
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------ 5- FILLING Instructor_Course TABLE WITH DATA -------------------------------------------------------------------------------------------
INSERT INTO Instructor_Course (Ins_ID, Cr_ID )
VALUES
(1, 100),
(1, 200),
(1, 300),
(1, 400),
(1, 500),
(2, 100),
(2, 200),
(2, 300),
(2, 400),
(2, 500),
(3, 100),
(3, 200),
(3, 300),
(3, 400),
(3, 500),
(4, 100),
(4, 200),
(4, 300),
(4, 400),
(4, 500),
(5, 100),
(5, 200),
(5, 300),
(5, 400),
(5, 500),
(6, 100),
(6, 200),
(6, 300),
(6, 400),
(6, 500);
GO
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------ 6- FILLING Student_Course TABLE WITH DATA ---------------------------------------------------------------------------------
INSERT INTO Student_Course
VALUES
(1, 100, 0),
(1, 200, 0),
(1, 300, 0),
(1, 400, 0),
(1, 500, 0),
(2, 100, 0),
(2, 200, 0),
(2, 300, 0),
(2, 400, 0),
(2, 500, 0),
(3, 100, 0),
(3, 200, 0),
(3, 300, 0),
(3, 400, 0),
(3, 500, 0),
(4, 100, 0),
(4, 200, 0),
(4, 300, 0),
(4, 400, 0),
(4, 500, 0),
(5, 100, 0),
(5, 200, 0),
(5, 300, 0),
(5, 400, 0),
(5, 500, 0);
GO
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------ 6- FILLING Question & Question_Choices TABLE WITH DATA ---------------------------------------------------------------------------------
-- Questions related to C#
-- Easy Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (1, 'What is the syntax for declaring a variable in C#?', 2, 'Easy', 'Mcq', 'b', 100),
    (2, 'What does the keyword "using" do in C#?', 2, 'Easy', 'Mcq', 'c', 100),
    (3, 'Which of the following is a correct way to initialize an array in C#?', 2, 'Easy', 'Mcq', 'a', 100),
    (4, 'What is the output of the following code? int x = 5; int y = 2; Console.WriteLine(x % y);', 2, 'Easy', 'Mcq', 'a', 100),
    (5, 'What is the result of 10 + 10 * 2 in C#?', 2, 'Easy', 'Mcq', 'c', 100);
GO
-- Medium Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (6, 'What is the purpose of the "virtual" keyword in C#?', 3, 'Medium', 'Mcq', 'b', 100),
    (7, 'What is the difference between "ref" and "out" parameters in C#?', 3, 'Medium', 'Mcq', 'c', 100),
    (8, 'How do you implement inheritance in C#?', 3, 'Medium', 'Mcq', 'a', 100),
    (9, 'What is the purpose of the "sealed" keyword in C#?', 3, 'Medium', 'Mcq', 'b', 100),
    (10, 'What is the output of the following code? int x = 10; int y = x++; Console.WriteLine(y);', 3, 'Medium', 'Mcq', 'a', 100);
GO
-- Hard Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (11, 'What is a delegate in C#?', 1, 'Hard', 'Mcq', 'a', 100),
    (12, 'What is the purpose of the "async" and "await" keywords in C#?', 1, 'Hard', 'Mcq', 'b', 100),
    (13, 'What is the difference between "throw" and "throw ex" in C#?', 1, 'Hard', 'Mcq', 'c', 100),
    (14, 'What is the purpose of the "using" statement in C#?', 1, 'Hard', 'Mcq', 'd', 100),
    (15, 'What is the output of the following code? string str = "Hello"; str[0] = "J" Console.WriteLine(str);', 1, 'Hard', 'Mcq', 'c', 100);
GO
-- Choices for Questions in C#
-- Easy Questions
-- Q_ID 1
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (1, 'int x;', 'a'),
       (1, 'var x;', 'b'),
       (1, 'string x;', 'c'),
       (1, 'float x;', 'd');
GO
-- Q_ID 2
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (2, 'Defines a using statement to avoid explicitly qualifying the namespace', 'a'),
       (2, 'Defines a using statement to include a namespace in the current scope', 'b'),
       (2, 'Defines a using statement to free resources', 'c'),
       (2, 'Defines a using statement to declare a variable', 'd');
GO
-- Q_ID 3
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (3, 'int[] numbers = new int[5];', 'a'),
       (3, 'int[] numbers = {1, 2, 3, 4, 5};', 'b'),
       (3, 'int numbers[] = new int[5];', 'c'),
       (3, 'int numbers[] = {1, 2, 3, 4, 5};', 'd');
GO
-- Q_ID 4
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (4, '1', 'a'),
       (4, '2', 'b'),
       (4, '3', 'c'),
       (4, '0', 'd');
GO
-- Q_ID 5
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (5, '20', 'a'),
       (5, '25', 'b'),
       (5, '30', 'c'),
       (5, '15', 'd');
GO
-- Medium Questions
-- Q_ID 6
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (6, 'To allow a derived class to override a method in the base class', 'a'),
       (6, 'To specify that a method can be overridden in a derived class', 'b'),
       (6, 'To indicate that a method cannot be overridden', 'c'),
       (6, 'To hide a method implementation in the base class', 'd');
GO
-- Q_ID 7
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (7, 'Parameters are passed by reference, and the method can modify the parameter value', 'a'),
       (7, 'Parameters are passed by reference, but the method cannot modify the parameter value', 'b'),
       (7, 'Parameters are passed by value, and the method can modify the parameter value', 'c'),
       (7, 'Parameters are passed by value, but the method cannot modify the parameter value', 'd');
GO
-- Q_ID 8
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (8, 'By using the ":" symbol after the class name followed by the base class name', 'a'),
       (8, 'By using the "base" keyword followed by the base class name', 'b'),
       (8, 'By using the "inherits" keyword followed by the base class name', 'c'),
       (8, 'By using the "extends" keyword followed by the base class name', 'd');
GO
-- Q_ID 9
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (9, 'To indicate that a method cannot be overridden in a derived class', 'a'),
       (9, 'To allow a derived class to override a method in the base class', 'b'),
       (9, 'To specify that a method can be overridden in a derived class', 'c'),
       (9, 'To hide a method implementation in the base class', 'd');
GO
-- Q_ID 10
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (10, '10', 'a'),
       (10, '11', 'b'),
       (10, '12', 'c'),
       (10, '9', 'd');
GO
-- Hard Questions
-- Q_ID 11
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (11, 'A pointer to a function in C++', 'a'),
       (11, 'A reference to an object in C++', 'b'),
       (11, 'A pointer to an object in C++', 'c'),
       (11, 'A keyword used to define an instance of a class', 'd');
GO
-- Q_ID 12
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (12, 'To indicate that a method is asynchronous and can await the result of an asynchronous operation', 'a'),
       (12, 'To indicate that a method is asynchronous and can be awaited in the calling code', 'b'),
       (12, 'To indicate that a method is asynchronous and can be awaited in the current method', 'c'),
       (12, 'To indicate that a method is asynchronous and can return a Task object', 'd');
GO
-- Q_ID 13
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (13, 'It preserves the original stack trace information', 'a'),
       (13, 'It does not preserve the original stack trace information', 'b'),
       (13, 'It rethrows the exception', 'c'),
       (13, 'It throws a new exception', 'd');
GO
-- Q_ID 14
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (14, 'To define a scope in which resources can be used and then released automatically', 'a'),
       (14, 'To define a scope in which variables are declared and initialized', 'b'),
       (14, 'To define a scope in which exceptions can be caught and handled', 'c'),
       (14, 'To define a scope in which method parameters are defined', 'd');
GO
-- Q_ID 15
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (15, '"Hello"', 'a'),
       (15, '"HellJ"', 'b'),
       (15, '"Jello"', 'c'),
       (15, 'Compilation Error', 'd');
GO
-- Questions related to C++
-- Easy Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (16, 'What is the syntax for declaring a variable in C++?', 2, 'Easy', 'Mcq', 'b', 200),
    (17, 'What does the keyword "const" do in C++?', 2, 'Easy', 'Mcq', 'c', 200),
    (18, 'How do you declare a function in C++?', 2, 'Easy', 'Mcq', 'a', 200),
    (19, 'What is the output of the following code? int x = 5; int y = 2; cout << x % y;', 2, 'Easy', 'Mcq', 'a', 200),
    (20, 'What is the result of 10 + 10 * 2 in C++?', 2, 'Easy', 'Mcq', 'c', 200);
GO
-- Medium Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (21, 'What is the purpose of the "this" pointer in C++?', 3, 'Medium', 'Mcq', 'b', 200),
    (22, 'What is the difference between "delete" and "delete[]" in C++?', 3, 'Medium', 'Mcq', 'c', 200),
    (23, 'How do you implement inheritance in C++?', 3, 'Medium', 'Mcq', 'a', 200),
    (24, 'What is the purpose of the "static" keyword in C++?', 3, 'Medium', 'Mcq', 'b', 200),
    (25, 'What is the output of the following code? int x = 10; int y = x++; cout << y;', 3, 'Medium', 'Mcq', 'a', 200);
GO
-- Hard Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (26, 'What is the purpose of the "namespace" keyword in C++?', 1, 'Hard', 'Mcq', 'a', 200),
    (27, 'What is the purpose of the "friend" keyword in C++?', 1, 'Hard', 'Mcq', 'b', 200),
    (28, 'What is the difference between "new" and "malloc()" in C++?', 1, 'Hard', 'Mcq', 'c', 200),
    (29, 'What is the output of the following code? int x = 5; int& y = x; y++; cout << x;', 1, 'Hard', 'Mcq', 'c', 200),
    (30, 'What is the output of the following code? int arr[] = {1, 2, 3}; cout << arr[3];', 1, 'Hard', 'Mcq', 'd', 200);
GO
-- Choices for Questions in C++
-- Easy Questions
-- Q_ID 16
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (16, 'int x;', 'a'),
       (16, 'var x;', 'b'),
       (16, 'string x;', 'c'),
       (16, 'float x;', 'd');
GO
-- Q_ID 17
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (17, 'Defines a constant variable', 'a'),
       (17, 'Defines a reference variable', 'b'),
       (17, 'Defines a pointer variable', 'c'),
       (17, 'Defines a static variable', 'd');
GO
-- Q_ID 18
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (18, 'return_type function_name(parameters);', 'a'),
       (18, 'function_name(parameters) { // function body }', 'b'),
       (18, 'void function_name(parameters);', 'c'),
       (18, 'function_name { // function body }', 'd');
GO
-- Q_ID 19
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (19, '1', 'a'),
       (19, '2', 'b'),
       (19, '3', 'c'),
       (19, '0', 'd');
GO
-- Q_ID 20
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (20, '20', 'a'),
       (20, '25', 'b'),
       (20, '30', 'c'),
       (20, '15', 'd');
GO
-- Medium Questions
-- Q_ID 21
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (21, 'To refer to the current object', 'a'),
       (21, 'To refer to the base class object', 'b'),
       (21, 'To refer to a static member of the class', 'c'),
       (21, 'To refer to a global variable', 'd');
GO
-- Q_ID 22
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (22, 'delete is used to deallocate memory for a single object', 'a'),
       (22, 'delete is used to deallocate memory for an array of objects', 'b'),
       (22, 'delete[] is used to deallocate memory for a single object', 'c'),
       (22, 'delete[] is used to deallocate memory for an array of objects', 'd');
GO
-- Q_ID 23
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (23, 'By using the ":" symbol after the class name followed by the base class name', 'a'),
       (23, 'By using the "base" keyword followed by the base class name', 'b'),
       (23, 'By using the "inherits" keyword followed by the base class name', 'c'),
       (23, 'By using the "extends" keyword followed by the base class name', 'd');
GO
-- Q_ID 24
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (24, 'To define a static member of a class', 'a'),
       (24, 'To specify that a method can be overridden in a derived class', 'b'),
       (24, 'To indicate that a method cannot be overridden', 'c'),
       (24, 'To refer to the current object', 'd');

-- Q_ID 25
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (25, '10', 'a'),
       (25, '11', 'b'),
       (25, '12', 'c'),
       (25, '9', 'd');
GO
-- Hard Questions
-- Q_ID 26
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (26, 'To define a named scope', 'a'),
       (26, 'To define a scope for a set of classes', 'b'),
       (26, 'To define a scope for a set of functions', 'c'),
       (26, 'To define a scope for a set of variables', 'd');
GO
-- Q_ID 27
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (27, 'To allow access to private and protected members of a class', 'a'),
       (27, 'To specify that a function is a friend function of a class', 'b'),
       (27, 'To define a class that can access private and protected members of another class', 'c'),
       (27, 'To allow multiple classes to access each other''s private and protected members', 'd');
GO
-- Q_ID 28
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (28, 'new calls the constructor for a single object', 'a'),
       (28, 'new calls the constructor for an array of objects', 'b'),
       (28, 'malloc() allocates memory for a single object', 'c'),
       (28, 'malloc() allocates memory for an array of objects', 'd');
GO
-- Q_ID 29
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (29, '5', 'a'),
       (29, '6', 'b'),
       (29, '4', 'c'),
       (29, 'Compilation Error', 'd');
GO
-- Q_ID 30
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (30, '0', 'a'),
       (30, '1', 'b'),
       (30, '2', 'c'),
       (30, 'Undefined behavior', 'd');
GO


-- Questions related to JavaScript
-- Easy Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (31, 'What is the syntax for declaring a variable in JavaScript?', 2, 'Easy', 'Mcq', 'b', 300),
    (32, 'How do you create a function in JavaScript?', 2, 'Easy', 'Mcq', 'a', 300),
    (33, 'Which keyword is used to declare a variable?', 2, 'Easy', 'Mcq', 'c', 300),
    (34, 'What is the output of the following code? var x = 5; var y = 2; console.log(x % y);', 2, 'Easy', 'Mcq', 'a', 300),
    (35, 'What is the result of 10 + 10 * 2 in JavaScript?', 2, 'Easy', 'Mcq', 'c', 300);
GO
-- Medium Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (36, 'What is a closure in JavaScript?', 3, 'Medium', 'Mcq', 'b', 300),
    (37, 'What is the difference between "==" and "===" in JavaScript?', 3, 'Medium', 'Mcq', 'c', 300),
    (38, 'How do you loop through an array in JavaScript?', 3, 'Medium', 'Mcq', 'a', 300),
    (39, 'What is the purpose of the "let" keyword in JavaScript?', 3, 'Medium', 'Mcq', 'b', 300),
    (40, 'What is the output of the following code? var x = 10; var y = x++; console.log(y);', 3, 'Medium', 'Mcq', 'a', 300);
GO
-- Hard Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (41, 'What is a promise in JavaScript?', 1, 'Hard', 'Mcq', 'a', 300),
    (42, 'What is the purpose of the "async" and "await" keywords in JavaScript?', 1, 'Hard', 'Mcq', 'b', 300),
    (43, 'What is the difference between "null" and "undefined" in JavaScript?', 1, 'Hard', 'Mcq', 'c', 300),
    (44, 'What is the purpose of the "use strict" directive in JavaScript?', 1, 'Hard', 'Mcq', 'd', 300),
    (45, 'What is the output of the following code? var str = "Hello"; str[0] = "J"; console.log(str);', 1, 'Hard', 'Mcq', 'c', 300);
GO
-- Choices for Questions in JavaScript
-- Easy Questions
-- Q_ID 31
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (31, 'int x;', 'a'),
       (31, 'var x;', 'b'),
       (31, 'string x;', 'c'),
       (31, 'float x;', 'd');
GO
-- Q_ID 32
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (32, 'function myFunction() { // function body }', 'a'),
       (32, 'def myFunction(): // function body', 'b'),
       (32, 'void myFunction() { // function body }', 'c'),
       (32, 'myFunction { // function body }', 'd');
GO
-- Q_ID 33
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (33, 'var', 'a'),
       (33, 'let', 'b'),
       (33, 'const', 'c'),
       (33, 'def', 'd');
GO
-- Q_ID 34
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (34, '1', 'a'),
       (34, '2', 'b'),
       (34, '3', 'c'),
       (34, '0', 'd');
GO
-- Q_ID 35
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (35, '20', 'a'),
       (35, '25', 'b'),
       (35, '30', 'c'),
       (35, '15', 'd');
GO
-- Medium Questions
-- Q_ID 36
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (36, 'A function defined inside another function', 'a'),
       (36, 'A function that has access to its outer function''s scope', 'b'),
       (36, 'A function that is used for asynchronous operations', 'c'),
       (36, 'A function that returns a value', 'd');
GO
-- Q_ID 37
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (37, 'Checks only for value equality', 'a'),
       (37, 'Checks both value and type equality', 'b'),
       (37, 'Checks only for type equality', 'c'),
       (37, 'Checks both value and reference equality', 'd');
GO
-- Q_ID 38
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (38, 'Using a for loop', 'a'),
       (38, 'Using a while loop', 'b'),
       (38, 'Using a do...while loop', 'c'),
       (38, 'Using a for...in loop', 'd');
GO
-- Q_ID 39
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (39, 'To declare a block-scoped variable', 'a'),
       (39, 'To declare a function-scoped variable', 'b'),
       (39, 'To declare a constant', 'c'),
       (39, 'To declare a variable with global scope', 'd');
GO
-- Q_ID 40
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (40, '10', 'a'),
       (40, '11', 'b'),
       (40, '12', 'c'),
       (40, '9', 'd');
GO
-- Hard Questions
-- Q_ID 41
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (41, 'An object representing the eventual completion or failure of an asynchronous operation', 'a'),
       (41, 'A function that handles asynchronous operations', 'b'),
       (41, 'A function that is executed after a delay', 'c'),
       (41, 'An object that encapsulates a value that may not be available yet', 'd');
GO
-- Q_ID 42
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (42, 'To define a synchronous function', 'a'),
       (42, 'To define an asynchronous function', 'b'),
       (42, 'To define a function that waits for a specified time', 'c'),
       (42, 'To define a function that executes in a separate thread', 'd');
GO
-- Q_ID 43
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (43, 'null is an explicitly assigned value representing "no value"', 'a'),
       (43, 'undefined means a variable has been declared but not defined', 'b'),
       (43, 'null is automatically assigned to variables that have not been initialized', 'c'),
       (43, 'undefined is a value that represents an empty or null value', 'd');
GO
-- Q_ID 44
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (44, 'To enable strict mode, which catches common coding mistakes and "unsafe" actions', 'a'),
       (44, 'To use additional features not available in standard JavaScript', 'b'),
       (44, 'To define a set of strict rules for coding style', 'c'),
       (44, 'To indicate that the script should be executed in a strict environment', 'd');
GO
-- Q_ID 45
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (45, '"Jello"', 'a'),
       (45, '"Hello"', 'b'),
       (45, '"Hllo"', 'c'),
       (45, '"Undefined behavior"', 'd');
GO


-- Questions related to SQL
-- Easy Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (46, 'What does SQL stand for?', 2, 'Easy', 'Mcq', 'b', 400),
    (47, 'Which statement is used to select all columns from a table in SQL?', 2, 'Easy', 'Mcq', 'c', 400),
    (48, 'Which SQL keyword is used to retrieve a maximum value?', 2, 'Easy', 'Mcq', 'a', 400),
    (49, 'What is the output of the following SQL query? SELECT * FROM table_name;', 2, 'Easy', 'Mcq', 'a', 400),
    (50, 'What is the result of 10 + 10 in SQL?', 2, 'Easy', 'Mcq', 'c', 400);
GO
-- Medium Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (51, 'What is a primary key in SQL?', 3, 'Medium', 'Mcq', 'b', 400),
    (52, 'What is the difference between INNER JOIN and LEFT JOIN in SQL?', 3, 'Medium', 'Mcq', 'c', 400),
    (53, 'How do you add a new record to a table in SQL?', 3, 'Medium', 'Mcq', 'a', 400),
    (54, 'What is the purpose of the GROUP BY statement in SQL?', 3, 'Medium', 'Mcq', 'b', 400),
    (55, 'What is the output of the following SQL query? SELECT COUNT(*) FROM table_name;', 3, 'Medium', 'Mcq', 'a', 400);
GO
-- Hard Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (56, 'What is a subquery in SQL?', 1, 'Hard', 'Mcq', 'a', 400),
    (57, 'What is the purpose of the HAVING clause in SQL?', 1, 'Hard', 'Mcq', 'b', 400),
    (58, 'What is the difference between UNION and UNION ALL in SQL?', 1, 'Hard', 'Mcq', 'c', 400),
    (59, 'How do you update data in a table in SQL?', 1, 'Hard', 'Mcq', 'd', 400),
    (60, 'What is the output of the following SQL query? SELECT DISTINCT column_name FROM table_name;', 1, 'Hard', 'Mcq', 'c', 400);
GO
-- Choices for Questions in SQL
-- Easy Questions
-- Q_ID 46
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (46, 'Structured Query Language', 'a'),
       (46, 'Standard Query Language', 'b'),
       (46, 'Simple Query Language', 'c'),
       (46, 'None of the above', 'd');
GO
-- Q_ID 47
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (47, 'SELECT * FROM table_name;', 'a'),
       (47, 'SELECT * FROM table_name', 'b'),
       (47, 'SELECT * table_name', 'c'),
       (47, 'SELECT table_name', 'd');
GO
-- Q_ID 48
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (48, 'MAX', 'a'),
       (48, 'MIN', 'b'),
       (48, 'TOP', 'c'),
       (48, 'SUM', 'd');
GO
-- Q_ID 49
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (49, 'All records from table_name', 'a'),
       (49, 'Selected columns from table_name', 'b'),
       (49, 'Selected rows from table_name', 'c'),
       (49, 'None of the above', 'd');
GO
-- Q_ID 50
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (50, '10', 'a'),
       (50, '20', 'b'),
       (50, '30', 'c'),
       (50, '40', 'd');
GO
-- Medium Questions
-- Q_ID 51
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (51, 'A column that uniquely identifies each row in a table', 'a'),
       (51, 'A table that contains unique values', 'b'),
       (51, 'A constraint that allows only unique values in a column', 'c'),
       (51, 'A column that is a primary identifier', 'd');
GO
-- Q_ID 52
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (52, 'INNER JOIN returns only the matching rows between the tables', 'a'),
       (52, 'LEFT JOIN returns all rows from the left table and the matched rows from the right table', 'b'),
       (52, 'There is no difference between INNER JOIN and LEFT JOIN', 'c'),
       (52, 'INNER JOIN returns all rows from both tables', 'd');
GO
-- Q_ID 53
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (53, 'INSERT INTO table_name (column1, column2, ...) VALUES (value1, value2, ...)', 'a'),
       (53, 'ADD RECORD table_name (column1, column2, ...) VALUES (value1, value2, ...)', 'b'),
       (53, 'ADD NEW table_name (column1, column2, ...) VALUES (value1, value2, ...)', 'c'),
       (53, 'INSERT RECORDS table_name (column1, column2, ...) VALUES (value1, value2, ...)', 'd');
GO
-- Q_ID 54
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (54, 'To group rows that have the same values', 'a'),
       (54, 'To order the rows in a specific sequence', 'b'),
       (54, 'To filter rows based on a condition', 'c'),
       (54, 'To perform calculations on grouped rows', 'd');
GO
-- Q_ID 55
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (55, 'The number of rows in table_name', 'a'),
       (55, 'The number of distinct values in column_name', 'b'),
       (55, 'The number of columns in table_name', 'c'),
       (55, 'The number of unique columns in table_name', 'd');
GO
-- Hard Questions
-- Q_ID 56
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (56, 'A query nested inside another query', 'a'),
       (56, 'A query that returns multiple result sets', 'b'),
       (56, 'A query that joins multiple tables', 'c'),
       (56, 'A query that combines multiple queries into a single result', 'd');
GO
-- Q_ID 57
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (57, 'To filter the results of an aggregate function', 'a'),
       (57, 'To group the results of a query', 'b'),
       (57, 'To specify a condition for grouped rows', 'c'),
       (57, 'To order the results of a query', 'd');
GO
-- Q_ID 58
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (58, 'UNION combines the results of two or more SELECT statements, removing duplicates', 'a'),
       (58, 'UNION ALL combines the results of two or more SELECT statements, including duplicates', 'b'),
       (58, 'UNION combines the results of two or more SELECT statements, including duplicates', 'c'),
       (58, 'UNION ALL combines the results of two or more SELECT statements, removing duplicates', 'd');
GO
-- Q_ID 59
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (59, 'UPDATE table_name SET column1 = value1, column2 = value2, ... WHERE condition', 'a'),
       (59, 'MODIFY table_name SET column1 = value1, column2 = value2, ... WHERE condition', 'b'),
       (59, 'CHANGE table_name SET column1 = value1, column2 = value2, ... WHERE condition', 'c'),
       (59, 'ALTER table_name SET column1 = value1, column2 = value2, ... WHERE condition', 'd');
GO
-- Q_ID 60
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (60, 'All values in column_name of table_name', 'a'),
       (60, 'Distinct values in column_name of table_name', 'b'),
       (60, 'Unique values in column_name of table_name', 'c'),
       (60, 'Number of rows in table_name', 'd');
GO

-- Questions related to HTML
-- Easy Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (61, 'What does HTML stand for?', 2, 'Easy', 'Mcq', 'b', 500),
    (62, 'Which tag is used to define a hyperlink in HTML?', 2, 'Easy', 'Mcq', 'c', 500),
    (63, 'Which HTML attribute is used to define inline styles?', 2, 'Easy', 'Mcq', 'a', 500),
    (64, 'What is the output of the following HTML code? <p style="color:red;">This is a red paragraph.</p>', 2, 'Easy', 'Mcq', 'a', 500),
    (65, 'Which character is used to indicate an end tag?', 2, 'Easy', 'Mcq', 'c', 500);
GO
-- Medium Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (66, 'What is the purpose of the alt attribute in HTML?', 3, 'Medium', 'Mcq', 'b', 500),
    (67, 'What is the difference between HTML and XHTML?', 3, 'Medium', 'Mcq', 'c', 500),
    (68, 'How do you create a numbered list in HTML?', 3, 'Medium', 'Mcq', 'a', 500),
    (69, 'What is the purpose of the <div> tag in HTML?', 3, 'Medium', 'Mcq', 'b', 500),
    (70, 'What is the output of the following HTML code? <img src="pic.jpg" width="500" height="600">', 3, 'Medium', 'Mcq', 'a', 500);
GO
-- Hard Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (71, 'What is the purpose of the <canvas> tag in HTML5?', 1, 'Hard', 'Mcq', 'a', 500),
    (72, 'What is the purpose of the <thead> tag in HTML?', 1, 'Hard', 'Mcq', 'b', 500),
    (73, 'What is the difference between <div> and <span> tags in HTML?', 1, 'Hard', 'Mcq', 'c', 500),
    (74, 'How do you create a hyperlink that will send an email in HTML?', 1, 'Hard', 'Mcq', 'd', 500),
    (75, 'What is the output of the following HTML code? <p><span>Hello</span> <span>World</span></p>', 1, 'Hard', 'Mcq', 'c', 500);
GO

-- Choices for Questions related to HTML
-- Easy Questions
-- Q_ID 61
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (61, 'Hyper Text Markup Language', 'a'),
       (61, 'Hyperlinks and Text Markup Language', 'b'),
       (61, 'Home Tool Markup Language', 'c'),
       (61, 'None of the above', 'd');
GO
-- Q_ID 62
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (62, '<a>', 'a'),
       (62, '<link>', 'b'),
       (62, '<href>', 'c'),
       (62, '<url>', 'd');
GO
-- Q_ID 63
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (63, 'style', 'a'),
       (63, 'css', 'b'),
       (63, 'font', 'c'),
       (63, 'class', 'd');
GO
-- Q_ID 64
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (64, 'A red paragraph', 'a'),
       (64, 'A blue paragraph', 'b'),
       (64, 'A green paragraph', 'c'),
       (64, 'A black paragraph', 'd');
GO
-- Q_ID 65
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (65, '<', 'a'),
       (65, '>', 'b'),
       (65, '/', 'c'),
       (65, '\\', 'd');
GO
-- Medium Questions
-- Q_ID 66
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (66, 'Alternative text for an image', 'a'),
       (66, 'A tag to define an alternative image', 'b'),
       (66, 'A tag to define alternative content', 'c'),
       (66, 'A tag to define alternative styles', 'd');
GO
-- Q_ID 67
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (67, 'HTML is a stricter and cleaner version of HTML', 'a'),
       (67, 'XHTML is a stricter and cleaner version of HTML', 'b'),
       (67, 'XHTML is the latest version of HTML', 'c'),
       (67, 'There is no difference between HTML and XHTML', 'd');
GO
-- Q_ID 68
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (68, '<ol></ol>', 'a'),
       (68, '<ul></ul>', 'b'),
       (68, '<li></li>', 'c'),
       (68, '<nl></nl>', 'd');
GO
-- Q_ID 69
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (69, 'To define a division or a section in an HTML document', 'a'),
       (69, 'To define a variable in JavaScript', 'b'),
       (69, 'To define a link to an external resource', 'c'),
       (69, 'To define a style for an element', 'd');
GO
-- Q_ID 70
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (70, 'An image with a width of 500 pixels and a height of 600 pixels', 'a'),
       (70, 'An image with a width of 600 pixels and a height of 500 pixels', 'b'),
       (70, 'An image with a width of 500 pixels and a height of 500 pixels', 'c'),
       (70, 'An image with a width of 600 pixels and a height of 600 pixels', 'd');
GO
-- Hard Questions
-- Q_ID 71
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (71, 'To draw graphics on the fly', 'a'),
       (71, 'To create a container for graphics', 'b'),
       (71, 'To define a canvas for images', 'c'),
       (71, 'To define a canvas for text', 'd');
GO
-- Q_ID 72
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (72, 'To define a header for a table', 'a'),
       (72, 'To define the head content for a document', 'b'),
       (72, 'To define a header cell in a table', 'c'),
       (72, 'To define the header content of a document', 'd');
GO
-- Q_ID 73
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (73, '<div> is a block-level element, while <span> is an inline element', 'a'),
       (73, '<div> is an inline element, while <span> is a block-level element', 'b'),
       (73, '<div> is a container element, while <span> is a text-level element', 'c'),
       (73, '<div> is a text-level element, while <span> is a container element', 'd');
GO
-- Q_ID 74
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (74, '<a href="mailto:email@example.com">', 'a'),
       (74, '<a href="email@example.com">', 'b'),
       (74, '<mail>email@example.com</mail>', 'c'),
       (74, '<mailto>email@example.com</mailto>', 'd');
GO
-- Q_ID 75
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES (75, 'Hello World', 'a'),
       (75, 'Hello', 'b'),
       (75, 'World', 'c'),
       (75, 'Hello <span>World</span>', 'd');
GO

-- C# Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (76, 'What is the default access modifier for a class in C#?', 2, 'Easy', 'Mcq', 'a', 100),
    (77, 'What is the purpose of the `using` directive in C#?', 2, 'Easy', 'Mcq', 'a', 100),
    (78, 'What is a namespace in C#?', 2, 'Easy', 'Mcq', 'a', 100),
    (79, 'What is the correct way to declare a variable to store an integer value in C#?', 2, 'Easy', 'Mcq', 'a', 100),
    (80, 'Which of the following is a correct comment format in C#?', 2, 'Easy', 'Mcq', 'a', 100);
GO
-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (81, 'What is a constructor in C#?', 3, 'Medium', 'Mcq', 'b', 100),
    (82, 'What is the difference between `==` and `===` in C#?', 3, 'Medium', 'Mcq', 'b', 100),
    (83, 'How do you define a method in C#?', 3, 'Medium', 'Mcq', 'b', 100),
    (84, 'What is the purpose of the `this` keyword in C#?', 3, 'Medium', 'Mcq', 'b', 100),
    (85, 'What is the output of the following code? int x = 5; int y = x++; Console.WriteLine(y);', 3, 'Medium', 'Mcq', 'a', 100);
GO
-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (86, 'What is a delegate in C#?', 1, 'Hard', 'Mcq', 'a', 100),
    (87, 'What is the difference between `throw` and `throw ex` in C#?', 1, 'Hard', 'Mcq', 'a', 100),
    (88, 'What is the purpose of the `async` and `await` keywords in C#?', 1, 'Hard', 'Mcq', 'a', 100),
    (89, 'What is the purpose of the `using` statement in C#?', 1, 'Hard', 'Mcq', 'a', 100),
    (90, 'What is the output of the following code? string str = "Hello"; str[0] = "J"; Console.WriteLine(str);', 1, 'Hard', 'Mcq', 'a', 100);
GO
-- C# Questions
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (76, 'public', 'a'),
    (76, 'private', 'b'),
    (76, 'protected', 'c'),
    (76, 'internal', 'd'),

    (77, 'Define a namespace', 'a'),
    (77, 'Import a namespace', 'b'),
    (77, 'Create an alias for a namespace', 'c'),
    (77, 'Specify the scope of a namespace', 'd'),

    (78, 'A type that contains methods and variables', 'a'),
    (78, 'A group of related classes and interfaces', 'b'),
    (78, 'A way to organize code', 'c'),
    (78, 'A predefined class in C#', 'd'),

    (79, 'var number;', 'a'),
    (79, 'int number;', 'b'),
    (79, 'integer number;', 'c'),
    (79, 'number;', 'd'),

    (80, '// Single-line comment', 'a'),
    (80, '/* Multi-line comment */', 'b'),
    (80, '/** XML documentation comment */', 'c'),
    (80, '%%% Custom comment format %%%', 'd');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (81, 'A special method that gets called when an object is created', 'a'),
    (81, 'A method used to destroy objects', 'b'),
    (81, 'A method used to copy objects', 'c'),
    (81, 'A method used to compare objects', 'd'),

    (82, 'They are identical', 'a'),
    (82, '== compares values, === compares values and types', 'b'),
    (82, '== compares references, === compares values', 'c'),
    (82, '== compares values, === compares references', 'd'),

    (83, 'public void MethodName()', 'a'),
    (83, 'void MethodName()', 'b'),
    (83, 'MethodName()', 'c'),
    (83, 'public MethodName()', 'd'),

    (84, 'Refers to the current instance of a class', 'a'),
    (84, 'Refers to the base class of a class', 'b'),
    (84, 'Refers to a static method in the class', 'c'),
    (84, 'Refers to the parent class of a class', 'd'),

    (85, '5', 'a'),
    (85, '6', 'b'),
    (85, '7', 'c'),
    (85, '8', 'd');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (86, 'A type that holds a reference to a method', 'a'),
    (86, 'A type that holds a reference to a variable', 'b'),
    (86, 'A type that holds a reference to a class', 'c'),
    (86, 'A type that holds a reference to an object', 'd'),

    (87, 'They both throw an exception', 'a'),
    (87, 'throw re-throws the current exception, throw ex creates a new exception', 'b'),
    (87, 'throw ex re-throws the current exception, throw creates a new exception', 'c'),
    (87, 'They are used to catch exceptions', 'd'),

    (88, 'They are used for asynchronous programming', 'a'),
    (88, 'They are used for synchronous programming', 'b'),
    (88, 'They are used for exception handling', 'c'),
    (88, 'They are used for event handling', 'd'),

    (89, 'To ensure that resources are properly disposed', 'a'),
    (89, 'To define a new namespace', 'b'),
    (89, 'To specify the access level of a class', 'c'),
    (89, 'To specify the data type of a variable', 'd'),

    (90, 'Hello', 'a'),
    (90, 'Jello', 'b'),
    (90, 'Error', 'c'),
    (90, 'No output', 'd');
GO
-- C++ Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (91, 'What is the default access modifier for members of a class in C++?', 2, 'Easy', 'Mcq', 'a', 200),
    (92, 'What does the `const` keyword do in C++?', 2, 'Easy', 'Mcq', 'a', 200),
    (93, 'How do you declare a variable in C++?', 2, 'Easy', 'Mcq', 'a', 200),
    (94, 'What is the correct way to initialize an array in C++?', 2, 'Easy', 'Mcq', 'a', 200),
    (95, 'Which of the following is a correct way to comment in C++?', 2, 'Easy', 'Mcq', 'a', 200);

-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (96, 'What is a pointer in C++?', 3, 'Medium', 'Mcq', 'b', 200),
    (97, 'What is the difference between `delete` and `delete[]` in C++?', 3, 'Medium', 'Mcq', 'b', 200),
    (98, 'How do you define a function in C++?', 3, 'Medium', 'Mcq', 'b', 200),
    (99, 'What is the purpose of the `static` keyword in C++?', 3, 'Medium', 'Mcq', 'b', 200),
    (100, 'What is the output of the following code? int x = 10; int y = x++; cout << y;', 3, 'Medium', 'Mcq', 'a', 200);

-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (101, 'What is a namespace in C++?', 1, 'Hard', 'Mcq', 'a', 200),
    (102, 'What is the purpose of the `friend` keyword in C++?', 1, 'Hard', 'Mcq', 'a', 200),
    (103, 'What is the difference between `new` and `malloc()` in C++?', 1, 'Hard', 'Mcq', 'a', 200),
    (104, 'What is the purpose of the `const` keyword in C++?', 1, 'Hard', 'Mcq', 'a', 200),
    (105, 'What is the output of the following code? int x = 5; int& y = x; y++; cout << x;', 1, 'Hard', 'Mcq', 'a', 200);
GO
-- C++ Questions
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (91, 'private', 'a'),
    (91, 'public', 'b'),
    (91, 'protected', 'c'),
    (91, 'internal', 'd'),

    (92, 'Makes a variable constant', 'a'),
    (92, 'Makes a variable global', 'b'),
    (92, 'Defines a constant value', 'c'),
    (92, 'Defines a constant function', 'd'),

    (93, 'int x;', 'a'),
    (93, 'integer x;', 'b'),
    (93, 'x int;', 'c'),
    (93, 'variable x;', 'd'),

    (94, 'int arr[5];', 'a'),
    (94, 'arr = new int[5];', 'b'),
    (94, 'int[] arr = new int[5];', 'c'),
    (94, 'int arr = [5];', 'd'),

    (95, '// Single-line comment', 'a'),
    (95, '/* Multi-line comment */', 'b'),
    (95, '/** XML documentation comment */', 'c'),
    (95, '%%% Custom comment format %%%', 'd');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (96, 'A variable that stores memory address', 'a'),
    (96, 'A variable that stores value', 'b'),
    (96, 'A variable that stores reference', 'c'),
    (96, 'A variable that stores pointer', 'd'),

    (97, 'delete releases memory for a single object, delete[] releases memory for an array', 'a'),
    (97, 'delete releases memory for an array, delete[] releases memory for a single object', 'b'),
    (97, 'delete[] releases memory for an array, delete releases memory for a single object', 'c'),
    (97, 'There is no difference', 'd'),

    (98, 'return-type function-name(parameters)', 'a'),
    (98, 'function-name(parameters) return-type', 'b'),
    (98, 'function-name return-type(parameters)', 'c'),
    (98, 'parameters function-name return-type', 'd'),

    (99, 'To define a class member that is shared among all instances of a class', 'a'),
    (99, 'To define a static method that can be called without an instance of the class', 'b'),
    (99, 'To define a constant variable', 'c'),
    (99, 'To define a variable that can be accessed from other files', 'd'),

    (100, '10', 'a'),
    (100, '11', 'b'),
    (100, '12', 'c'),
    (100, '13', 'd');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (101, 'A scope in which identifiers have meaning', 'a'),
    (101, 'A type that holds a reference to a variable', 'b'),
    (101, 'A type that holds a reference to a class', 'c'),
    (101, 'A type that holds a reference to an object', 'd'),

    (102, 'To allow access to private and protected members of a class', 'a'),
    (102, 'To define a new class', 'b'),
    (102, 'To define a new function', 'c'),
    (102, 'To define a new variable', 'd'),

    (103, 'new is used for objects, malloc() is used for memory allocation', 'a'),
    (103, 'new is used for memory allocation, malloc() is used for objects', 'b'),
    (103, 'new is a C++ keyword, malloc() is a C keyword', 'c'),
    (103, 'There is no difference', 'd'),

    (104, 'To declare a constant variable', 'a'),
    (104, 'To define a constant function', 'b'),
    (104, 'To declare a constant object', 'c'),
    (104, 'To define a constant class', 'd'),

    (105, '6', 'a'),
    (105, '5', 'b'),
    (105, '4', 'c'),
    (105, '7', 'd');

GO
-- JavaScript Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (106, 'What is the syntax for declaring a variable in JavaScript?', 2, 'Easy', 'Mcq', 'a', 300),
    (107, 'How do you create a function in JavaScript?', 2, 'Easy', 'Mcq', 'a', 300),
    (108, 'Which keyword is used to declare a variable in JavaScript?', 2, 'Easy', 'Mcq', 'a', 300),
    (109, 'What is the output of the following code? var x = 5; var y = 2; console.log(x % y);', 2, 'Easy', 'Mcq', 'a', 300),
    (110, 'What is the result of 10 + 10 * 2 in JavaScript?', 2, 'Easy', 'Mcq', 'a', 300);

-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (111, 'What is a closure in JavaScript?', 3, 'Medium', 'Mcq', 'b', 300),
    (112, 'What is the difference between `==` and `===` in JavaScript?', 3, 'Medium', 'Mcq', 'b', 300),
    (113, 'How do you loop through an array in JavaScript?', 3, 'Medium', 'Mcq', 'b', 300),
    (114, 'What is the purpose of the `let` keyword in JavaScript?', 3, 'Medium', 'Mcq', 'b', 300),
    (115, 'What is the output of the following code? var x = 10; var y = x++; console.log(y);', 3, 'Medium', 'Mcq', 'a', 300);

-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (116, 'What is a promise in JavaScript?', 1, 'Hard', 'Mcq', 'a', 300),
    (117, 'What is the purpose of the `async` and `await` keywords in JavaScript?', 1, 'Hard', 'Mcq', 'a', 300),
    (118, 'What is the difference between `null` and `undefined` in JavaScript?', 1, 'Hard', 'Mcq', 'a', 300),
    (119, 'What is the purpose of the `use strict` directive in JavaScript?', 1, 'Hard', 'Mcq', 'a', 300),
    (120, 'What is the output of the following code? var str = "Hello"; str[0] = "J"; console.log(str);', 1, 'Hard', 'Mcq', 'a', 300);
GO
-- JavaScript Questions
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (106, 'var', 'a'),
    (106, 'int', 'b'),
    (106, 'let', 'c'),
    (106, 'const', 'd'),

    (107, 'function myFunction()', 'a'),
    (107, 'myFunction()', 'b'),
    (107, 'create function myFunction()', 'c'),
    (107, 'new function myFunction()', 'd'),

    (108, 'var', 'a'),
    (108, 'let', 'b'),
    (108, 'const', 'c'),
    (108, 'variable', 'd'),

    (109, '1', 'a'),
    (109, '2', 'b'),
    (109, '0', 'c'),
    (109, '5', 'd'),

    (110, '30', 'a'),
    (110, '20', 'b'),
    (110, 'NaN', 'c'),
    (110, '22', 'd');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (111, 'A function defined inside another function', 'a'),
    (111, 'A function that can access its lexical scope even when executed outside that scope', 'b'),
    (111, 'A function that has a dynamic scope', 'c'),
    (111, 'A function that is immediately invoked after being defined', 'd'),

    (112, 'They both perform type coercion before comparison', 'a'),
    (112, '== only compares values, === compares both values and types', 'b'),
    (112, '== compares values and types, === compares values only', 'c'),
    (112, '== compares references, === compares values', 'd'),

    (113, 'for loop', 'a'),
    (113, 'while loop', 'b'),
    (113, 'forEach method', 'c'),
    (113, 'All of the above', 'd'),

    (114, 'To declare a block-scoped variable', 'a'),
    (114, 'To declare a variable with function scope', 'b'),
    (114, 'To declare a variable with global scope', 'c'),
    (114, 'To declare a constant variable', 'd'),

    (115, '10', 'a'),
    (115, '11', 'b'),
    (115, '9', 'c'),
    (115, '0', 'd');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (116, 'A placeholder for a future value', 'a'),
    (116, 'A guaranteed result of an asynchronous operation', 'b'),
    (116, 'An object representing the eventual completion or failure of an asynchronous operation', 'c'),
    (116, 'A data structure used to store multiple values', 'd'),

    (117, 'They are used for asynchronous programming', 'a'),
    (117, 'They are used for synchronous programming', 'b'),
    (117, 'They are used for exception handling', 'c'),
    (117, 'They are used for event handling', 'd'),

    (118, 'null is an object, undefined is a type', 'a'),
    (118, 'null indicates a deliberate non-value, undefined indicates a variable that has not been assigned a value', 'b'),
    (118, 'null is a type, undefined is an object', 'c'),
    (118, 'null indicates an empty value, undefined indicates a value that is not empty', 'd'),

    (119, 'To enforce stricter parsing and error handling in JavaScript', 'a'),
    (119, 'To enable strict mode in JavaScript', 'b'),
    (119, 'To restrict the use of certain features in JavaScript', 'c'),
    (119, 'To prevent certain actions from being taken in JavaScript', 'd'),

    (120, 'Hello', 'a'),
    (120, 'Jello', 'b'),
    (120, 'Error', 'c'),
    (120, 'No output', 'd');
GO

-- SQL Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (121, 'What does SQL stand for?', 2, 'Easy', 'Mcq', 'a', 400),
    (122, 'Which statement is used to select all columns from a table in SQL?', 2, 'Easy', 'Mcq', 'a', 400),
    (123, 'Which SQL keyword is used to retrieve a maximum value?', 2, 'Easy', 'Mcq', 'a', 400),
    (124, 'What is the output of the following SQL query? SELECT * FROM table_name;', 2, 'Easy', 'Mcq', 'a', 400),
    (125, 'What is the result of 10 + 10 in SQL?', 2, 'Easy', 'Mcq', 'a', 400);
GO
-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (126, 'What is a primary key in SQL?', 3, 'Medium', 'Mcq', 'b', 400),
    (127, 'What is the difference between `INNER JOIN` and `LEFT JOIN` in SQL?', 3, 'Medium', 'Mcq', 'b', 400),
    (128, 'How do you add a new record to a table in SQL?', 3, 'Medium', 'Mcq', 'b', 400),
    (129, 'What is the purpose of the `GROUP BY` statement in SQL?', 3, 'Medium', 'Mcq', 'b', 400),
    (130, 'What is the output of the following SQL query? SELECT COUNT(*) FROM table_name;', 3, 'Medium', 'Mcq', 'a', 400);
GO
-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (131, 'What is a subquery in SQL?', 1, 'Hard', 'Mcq', 'a', 400),
    (132, 'What is the purpose of the `HAVING` clause in SQL?', 1, 'Hard', 'Mcq', 'a', 400),
    (133, 'What is the difference between `UNION` and `UNION ALL` in SQL?', 1, 'Hard', 'Mcq', 'a', 400),
    (134, 'How do you update data in a table in SQL?', 1, 'Hard', 'Mcq', 'a', 400),
    (135, 'What is the output of the following SQL query? SELECT DISTINCT column_name FROM table_name;', 1, 'Hard', 'Mcq', 'a', 400);
GO
	-- SQL Questions
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (121, 'Structured Query Language', 'a'),
    (121, 'Standard Query Language', 'b'),
    (121, 'Sequential Query Language', 'c'),
    (121, 'Simple Query Language', 'd'),

    (122, 'SELECT *', 'a'),
    (122, 'SELECT ALL', 'b'),
    (122, 'SELECT', 'c'),
    (122, 'SELECT COLUMN', 'd'),

    (123, 'MAX', 'a'),
    (123, 'TOP', 'b'),
    (123, 'MAXIMUM', 'c'),
    (123, 'HIGH', 'd'),

    (124, 'All records from the table', 'a'),
    (124, 'Syntax error', 'b'),
    (124, 'No output', 'c'),
    (124, 'Some records from the table', 'd'),

    (125, '20', 'a'),
    (125, '10 + 10', 'b'),
    (125, 'Error', 'c'),
    (125, 'No output', 'd');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (126, 'A unique identifier for a record in a table', 'a'),
    (126, 'A key that is used for encryption', 'b'),
    (126, 'A key that is used for sorting records', 'c'),
    (126, 'A key that is used for indexing', 'd'),

    (127, 'INNER JOIN returns only matching rows from both tables, LEFT JOIN returns all rows from the left table and the matched rows from the right table', 'a'),
    (127, 'INNER JOIN returns all rows from both tables, LEFT JOIN returns only matching rows from the left table', 'b'),
    (127, 'INNER JOIN returns only matching rows from both tables, LEFT JOIN returns all rows from the right table and the matched rows from the left table', 'c'),
    (127, 'INNER JOIN returns all rows from the left table and the matched rows from the right table, LEFT JOIN returns only matching rows from both tables', 'd'),

    (128, 'INSERT INTO table_name VALUES (value1, value2, ...)', 'a'),
    (128, 'ADD RECORD INTO table_name', 'b'),
    (128, 'ADD NEW INTO table_name VALUES (value1, value2, ...)', 'c'),
    (128, 'NEW RECORD table_name VALUES (value1, value2, ...)', 'd'),

    (129, 'To group rows that have the same values into summary rows', 'a'),
    (129, 'To filter groups based on a specified condition', 'b'),
    (129, 'To combine the results of two or more SELECT statements', 'c'),
    (129, 'To order the results of a query', 'd'),

    (130, 'The number of records in the table', 'a'),
    (130, 'The number of distinct values in the specified column', 'b'),
    (130, 'The number of rows returned by the query', 'c'),
    (130, 'The number of columns in the table', 'd');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (131, 'A query inside another query', 'a'),
    (131, 'A query that returns multiple rows', 'b'),
    (131, 'A query that returns a single value', 'c'),
    (131, 'A query that returns a single row', 'd'),

    (132, 'To filter groups based on a specified condition', 'a'),
    (132, 'To filter rows based on a specified condition', 'b'),
    (132, 'To filter columns based on a specified condition', 'c'),
    (132, 'To filter records based on a specified condition', 'd'),

    (133, 'UNION combines the result sets of two or more SELECT statements and removes duplicates, UNION ALL combines the result sets of two or more SELECT statements and retains duplicates', 'a'),
    (133, 'UNION combines the result sets of two or more SELECT statements and retains duplicates, UNION ALL combines the result sets of two or more SELECT statements and removes duplicates', 'b'),
    (133, 'UNION combines the result sets of two or more SELECT statements and removes duplicates, UNION ALL combines the result sets of two or more SELECT statements and removes duplicates', 'c'),
    (133, 'UNION combines the result sets of two or more SELECT statements and retains duplicates, UNION ALL combines the result sets of two or more SELECT statements and retains duplicates', 'd'),

    (134, 'To change the value of a column in a table', 'a'),
    (134, 'To add a new column to a table', 'b'),
    (134, 'To delete a column from a table', 'c'),
    (134, 'To retrieve data from a table', 'd'),

    (135, 'All distinct values in the specified column', 'a'),
    (135, 'An error', 'b'),
    (135, 'No output', 'c'),
    (135, 'Some distinct values in the specified column', 'd');
GO
-- HTML Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (136, 'What does HTML stand for?', 2, 'Easy', 'Mcq', 'a', 500),
    (137, 'Which tag is used to define a hyperlink in HTML?', 2, 'Easy', 'Mcq', 'a', 500),
    (138, 'Which HTML attribute is used to define inline styles?', 2, 'Easy', 'Mcq', 'a', 500),
    (139, 'What is the output of the following HTML code? <p style="color:red;">This is a red paragraph.</p>', 2, 'Easy', 'Mcq', 'a', 500),
    (140, 'Which character is used to indicate an end tag?', 2, 'Easy', 'Mcq', 'a', 500);
GO
-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (141, 'What is the purpose of the `alt` attribute in HTML?', 3, 'Medium', 'Mcq', 'b', 500),
    (142, 'What is the difference between HTML and XHTML?', 3, 'Medium', 'Mcq', 'b', 500),
    (143, 'How do you create a numbered list in HTML?', 3, 'Medium', 'Mcq', 'b', 500),
    (144, 'What is the purpose of the `<div>` tag in HTML?', 3, 'Medium', 'Mcq', 'b', 500),
    (145, 'What is the output of the following HTML code? <img src="pic.jpg" width="500" height="600">', 3, 'Medium', 'Mcq', 'a', 500);
GO
-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (146, 'What is the purpose of the `<canvas>` tag in HTML5?', 1, 'Hard', 'Mcq', 'a', 500),
    (147, 'What is the purpose of the `<thead>` tag in HTML?', 1, 'Hard', 'Mcq', 'a', 500),
    (148, 'What is the difference between `<div>` and `<span>` tags in HTML?', 1, 'Hard', 'Mcq', 'a', 500),
    (149, 'How do you create a hyperlink that will send an email in HTML?', 1, 'Hard', 'Mcq', 'a', 500),
    (150, 'What is the output of the following HTML code? <p><span>Hello</span> <span>World</span></p>', 1, 'Hard', 'Mcq', 'a', 500);
GO
-- HTML Questions
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (136, 'Hyper Text Markup Language', 'a'),
    (136, 'Hyperlinks and Text Markup Language', 'b'),
    (136, 'Home Tool Markup Language', 'c'),
    (136, 'None of the above', 'd'),

    (137, '<a>', 'a'),
    (137, '<link>', 'b'),
    (137, '<href>', 'c'),
    (137, '<url>', 'd'),

    (138, 'style', 'a'),
    (138, 'css', 'b'),
    (138, 'inline', 'c'),
    (138, 'class', 'd'),

    (139, 'A red paragraph', 'a'),
    (139, 'An error', 'b'),
    (139, 'No output', 'c'),
    (139, 'A black paragraph', 'd'),

    (140, '/', 'a'),
    (140, '.', 'b'),
    (140, '<', 'c'),
    (140, '>', 'd');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (141, 'Alternative text for an image', 'a'),
    (141, 'A caption for an image', 'b'),
    (141, 'A link for an image', 'c'),
    (141, 'None of the above', 'd'),

    (142, 'XHTML is stricter than HTML and follows XML syntax rules', 'a'),
    (142, 'XHTML is older than HTML', 'b'),
    (142, 'XHTML is used for dynamic web applications', 'c'),
    (142, 'XHTML is a new version of HTML', 'd'),

    (143, '<ol>', 'a'),
    (143, '<ul>', 'b'),
    (143, '<li>', 'c'),
    (143, '<dl>', 'd'),

    (144, 'To divide the content into sections', 'a'),
    (144, 'To define a division or a section in an HTML document', 'b'),
    (144, 'To create a hyperlink', 'c'),
    (144, 'To format text', 'd'),

    (145, 'An image with a width of 500 pixels and a height of 600 pixels', 'a'),
    (145, 'An error', 'b'),
    (145, 'No output', 'c'),
    (145, 'An image with the default width and height', 'd');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (146, 'To draw graphics, animations, or other visual images on the fly', 'a'),
    (146, 'To display tabular data', 'b'),
    (146, 'To create forms', 'c'),
    (146, 'To embed audio and video content', 'd'),

    (147, 'To define a header for a table', 'a'),
    (147, 'To define a footer for a table', 'b'),
    (147, 'To define a caption for a table', 'c'),
    (147, 'To define a body for a table', 'd'),

    (148, '<div> is a block-level element, <span> is an inline element', 'a'),
    (148, '<div> is an inline element, <span> is a block-level element', 'b'),
    (148, '<div> is used for styling, <span> is used for structure', 'c'),
    (148, '<div> is used for structure, <span> is used for styling', 'd'),

    (149, '<a href="mailt:email@example.com">', 'a'),
    (149, '<a href="mail:email@example.com">', 'b'),
    (149, '<a href="email@example.com">', 'c'),
    (149, '<a href="sendmail:email@example.com">', 'd'),

    (150, 'Hello World', 'a'),
    (150, 'World Hello', 'b'),
    (150, 'Error', 'c'),
    (150, 'No output', 'd');
GO

-- C# True or False Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (151, 'C# is a statically typed language.', 2, 'Easy', 'Tf', 'T', 100),
    (152, 'A class in C# can inherit from multiple classes.', 2, 'Easy', 'Tf', 'F', 100),
    (153, 'An interface in C# can contain implementation of methods.', 2, 'Easy', 'Tf', 'F', 100),
    (154, 'C# is a case-sensitive language.', 2, 'Easy', 'Tf', 'T', 100),
    (155, 'C# supports multiple inheritance.', 2, 'Easy', 'Tf', 'F', 100);
GO
-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (156, 'A delegate in C# is a type-safe function pointer.', 3, 'Medium', 'Tf', 'T', 100),
    (157, 'The `finally` block in a try-catch-finally statement is executed only if an exception is thrown.', 3, 'Medium', 'Tf', 'T', 100),
    (158, 'The `static` keyword in C# is used to create static classes.', 3, 'Medium', 'Tf', 'F', 100),
    (159, 'The `sizeof` operator in C# returns the size of a variable in bytes.', 3, 'Medium', 'Tf', 'T', 100),
    (160, 'C# supports operator overloading.', 3, 'Medium', 'Tf', 'T', 100);
GO
-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (161, 'C# does not support multiple inheritance, but it supports multiple interfaces.', 1, 'Hard', 'Tf', 'T', 100),
    (162, 'The `ref` keyword in C# is used for passing arguments by reference.', 1, 'Hard', 'Tf', 'T', 100),
    (163, 'The `readonly` keyword in C# can be used to make a field constant.', 1, 'Hard', 'Tf', 'T', 100),
    (164, 'In C#, `System.Object` is the base class for all classes.', 1, 'Hard', 'Tf', 'T', 100),
    (165, 'C# does not support pointer arithmetic like C and C++.', 1, 'Hard', 'Tf', 'F', 100);
GO
-- C# True or False Question Choices
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (151, 'True', 'a'),
    (151, 'False', 'b'),
    (152, 'True', 'a'),
    (152, 'False', 'b'),
    (153, 'True', 'a'),
    (153, 'False', 'b'),
    (154, 'True', 'a'),
    (154, 'False', 'b'),
    (155, 'True', 'a'),
    (155, 'False', 'b');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (156, 'True', 'a'),
    (156, 'False', 'b'),
    (157, 'True', 'a'),
    (157, 'False', 'b'),
    (158, 'True', 'a'),
    (158, 'False', 'b'),
    (159, 'True', 'a'),
    (159, 'False', 'b'),
    (160, 'True', 'a'),
    (160, 'False', 'b');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (161, 'True', 'a'),
    (161, 'False', 'b'),
    (162, 'True', 'a'),
    (162, 'False', 'b'),
    (163, 'True', 'a'),
    (163, 'False', 'b'),
    (164, 'True', 'a'),
    (164, 'False', 'b'),
    (165, 'True', 'a'),
    (165, 'False', 'b');
GO
-- C++ True or False Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (166, 'C++ is a high-level programming language.', 2, 'Easy', 'Tf', 'T', 200),
    (167, 'C++ supports both procedural and object-oriented programming paradigms.', 2, 'Easy', 'Tf', 'T', 200),
    (168, 'In C++, the `sizeof` operator can be used to find the size of a data type.', 2, 'Easy', 'Tf', 'T', 200),
    (169, 'C++ does not support function overloading.', 2, 'Easy', 'Tf', 'F', 200),
    (170, 'The `++` operator in C++ increments the value of a variable by 1.', 2, 'Easy', 'Tf', 'T', 200);
GO
-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (171, 'In C++, a reference is an alias for a variable.', 3, 'Medium', 'Tf', 'T', 200),
    (172, 'The `new` operator in C++ is used to allocate memory for an object.', 3, 'Medium', 'Tf', 'T', 200),
    (173, 'C++ supports automatic garbage collection.', 3, 'Medium', 'Tf', 'F', 200),
    (174, 'C++ allows function overloading.', 3, 'Medium', 'Tf', 'T', 200),
    (175, 'In C++, the `delete` operator is used to deallocate memory.', 3, 'Medium', 'Tf', 'T', 200);
GO
-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (176, 'C++ supports virtual inheritance.', 1, 'Hard', 'Tf', 'T', 200),
    (177, 'In C++, `sizeof(char)` is guaranteed to be 1.', 1, 'Hard', 'Tf', 'T', 200),
    (178, 'C++ does not support exception handling.', 1, 'Hard', 'Tf', 'F', 200),
    (179, 'The `const` keyword in C++ is used to declare constant variables.', 1, 'Hard', 'Tf', 'T', 200),
    (180, 'In C++, the `sizeof` operator returns the size of a class.', 1, 'Hard', 'Tf', 'F', 200);
GO
-- C++ True or False Question Choices
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (166, 'True', 'a'),
    (166, 'False', 'b'),
    (167, 'True', 'a'),
    (167, 'False', 'b'),
    (168, 'True', 'a'),
    (168, 'False', 'b'),
    (169, 'True', 'a'),
    (169, 'False', 'b'),
    (170, 'True', 'a'),
    (170, 'False', 'b');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (171, 'True', 'a'),
    (171, 'False', 'b'),
    (172, 'True', 'a'),
    (172, 'False', 'b'),
    (173, 'True', 'a'),
    (173, 'False', 'b'),
    (174, 'True', 'a'),
    (174, 'False', 'b'),
    (175, 'True', 'a'),
    (175, 'False', 'b');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (176, 'True', 'a'),
    (176, 'False', 'b'),
    (177, 'True', 'a'),
    (177, 'False', 'b'),
    (178, 'True', 'a'),
    (178, 'False', 'b'),
    (179, 'True', 'a'),
    (179, 'False', 'b'),
    (180, 'True', 'a'),
    (180, 'False', 'b');
GO

-- JavaScript True or False Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (181, 'JavaScript is a case-sensitive language.', 2, 'Easy', 'Tf', 'T', 300),
    (182, 'You can declare variables in JavaScript using the `var` keyword.', 2, 'Easy', 'Tf', 'T', 300),
    (183, 'JavaScript can only be used for client-side web development.', 2, 'Easy', 'Tf', 'F', 300),
    (184, 'The `===` operator in JavaScript checks for both value and type equality.', 2, 'Easy', 'Tf', 'T', 300),
    (185, 'JavaScript is a statically typed language.', 2, 'Easy', 'Tf', 'F', 300);
GO
-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (186, 'In JavaScript, `null` is an object.', 3, 'Medium', 'Tf', 'F', 300),
    (187, 'JavaScript supports both synchronous and asynchronous programming.', 3, 'Medium', 'Tf', 'T', 300),
    (188, 'You can create objects in JavaScript using the `new` keyword.', 3, 'Medium', 'Tf', 'T', 300),
    (189, 'JavaScript has built-in support for multi-threading.', 3, 'Medium', 'Tf', 'F', 300),
    (190, 'JavaScript is a compiled language.', 3, 'Medium', 'Tf', 'F', 300);
GO
-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (191, 'In JavaScript, `this` refers to the global object within a function.', 1, 'Hard', 'Tf', 'F', 300),
    (192, 'The `await` keyword in JavaScript is used to pause the execution of an async function.', 1, 'Hard', 'Tf', 'T', 300),
    (193, 'JavaScript does not support classes.', 1, 'Hard', 'Tf', 'F', 300),
    (194, 'The `typeof` operator in JavaScript returns the data type of a variable.', 1, 'Hard', 'Tf', 'T', 300),
    (195, 'JavaScript is primarily used for client-side web development.', 1, 'Hard', 'Tf', 'T', 300);
GO
-- JavaScript True or False Question Choices
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (181, 'True', 'a'),
    (181, 'False', 'b'),
    (182, 'True', 'a'),
    (182, 'False', 'b'),
    (183, 'True', 'a'),
    (183, 'False', 'b'),
    (184, 'True', 'a'),
    (184, 'False', 'b'),
    (185, 'True', 'a'),
    (185, 'False', 'b');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (186, 'True', 'a'),
    (186, 'False', 'b'),
    (187, 'True', 'a'),
    (187, 'False', 'b'),
    (188, 'True', 'a'),
    (188, 'False', 'b'),
    (189, 'True', 'a'),
    (189, 'False', 'b'),
    (190, 'True', 'a'),
    (190, 'False', 'b');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (191, 'True', 'a'),
    (191, 'False', 'b'),
    (192, 'True', 'a'),
    (192, 'False', 'b'),
    (193, 'True', 'a'),
    (193, 'False', 'b'),
    (194, 'True', 'a'),
    (194, 'False', 'b'),
    (195, 'True', 'a'),
    (195, 'False', 'b');

GO
-- SQL True or False Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (196, 'SQL stands for Structured Query Language.', 2, 'Easy', 'Tf', 'T', 400),
    (197, 'The SELECT statement is used to update data in a database.', 2, 'Easy', 'Tf', 'F', 400),
    (198, 'The DELETE statement is used to remove rows from a table.', 2, 'Easy', 'Tf', 'T', 400),
    (199, 'The UPDATE statement is used to insert new rows into a table.', 2, 'Easy', 'Tf', 'F', 400),
    (200, 'SQL is a case-insensitive language.', 2, 'Easy', 'Tf', 'T', 400);
GO
-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (201, 'The GROUP BY clause is used with aggregate functions to group the result-set by one or more columns.', 3, 'Medium', 'Tf', 'T', 400),
    (202, 'A subquery is a query within another query.', 3, 'Medium', 'Tf', 'T', 400),
    (203, 'The JOIN clause is used to combine rows from two or more tables.', 3, 'Medium', 'Tf', 'T', 400),
    (204, 'The DISTINCT keyword is used to select unique values from a table.', 3, 'Medium', 'Tf', 'T', 400),
    (205, 'SQL does not support the use of indexes.', 3, 'Medium', 'Tf', 'F', 400);
GO
-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (206, 'The INSERT INTO statement is used to add new records to a table.', 1, 'Hard', 'Tf', 'T', 400),
    (207, 'The HAVING clause is used to filter records based on a specified condition.', 1, 'Hard', 'Tf', 'T', 400),
    (208, 'SQL is a programming language.', 1, 'Hard', 'Tf', 'F', 400),
    (209, 'The ORDER BY clause is used to sort the result-set in ascending or descending order.', 1, 'Hard', 'Tf', 'T', 400),
    (210, 'SQL does not support the use of transactions.', 1, 'Hard', 'Tf', 'F', 400);
GO
-- SQL True or False Question Choices
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (196, 'True', 'a'),
    (196, 'False', 'b'),
    (197, 'True', 'a'),
    (197, 'False', 'b'),
    (198, 'True', 'a'),
    (198, 'False', 'b'),
    (199, 'True', 'a'),
    (199, 'False', 'b'),
    (200, 'True', 'a'),
    (200, 'False', 'b');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (201, 'True', 'a'),
    (201, 'False', 'b'),
    (202, 'True', 'a'),
    (202, 'False', 'b'),
    (203, 'True', 'a'),
    (203, 'False', 'b'),
    (204, 'True', 'a'),
    (204, 'False', 'b'),
    (205, 'True', 'a'),
    (205, 'False', 'b');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (206, 'True', 'a'),
    (206, 'False', 'b'),
    (207, 'True', 'a'),
    (207, 'False', 'b'),
    (208, 'True', 'a'),
    (208, 'False', 'b'),
    (209, 'True', 'a'),
    (209, 'False', 'b'),
    (210, 'True', 'a'),
    (210, 'False', 'b');
GO

-- HTML True or False Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (211, 'HTML stands for Hypertext Markup Language.', 2, 'Easy', 'Tf', 'T', 500),
    (212, 'HTML is a programming language.', 2, 'Easy', 'Tf', 'F', 500),
    (213, 'In HTML, elements are represented by tags.', 2, 'Easy', 'Tf', 'T', 500),
    (214, 'HTML files can only be viewed in a web browser.', 2, 'Easy', 'Tf', 'F', 500),
    (215, 'The `<img>` tag is used to define a clickable button.', 2, 'Easy', 'Tf', 'F', 500);
GO
-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (216, 'The `<div>` tag defines a division or a section in an HTML document.', 3, 'Medium', 'Tf', 'T', 500),
    (217, 'The `<a>` tag is used to define a hyperlink.', 3, 'Medium', 'Tf', 'T', 500),
    (218, 'HTML5 is the latest version of HTML.', 3, 'Medium', 'Tf', 'T', 500),
    (219, 'The `<head>` tag is used to define the main content of an HTML document.', 3, 'Medium', 'Tf', 'F', 500),
    (220, 'The `<table>` tag is used to create a list of items in HTML.', 3, 'Medium', 'Tf', 'F', 500);
GO
-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (221, 'The `<canvas>` tag in HTML is used for vector graphics.', 1, 'Hard', 'Tf', 'T', 500),
    (222, 'The `<thead>` tag in HTML defines the header of a table.', 1, 'Hard', 'Tf', 'T', 500),
    (223, 'HTML comments are visible on the webpage.', 1, 'Hard', 'Tf', 'F', 500),
    (224, 'The `<span>` tag is used to define a section in an HTML document.', 1, 'Hard', 'Tf', 'F', 500),
    (225, 'The `<form>` tag is used to create forms for user input in HTML.', 1, 'Hard', 'Tf', 'T', 500);
GO
-- HTML True or False Question Choices
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (211, 'True', 'a'),
    (211, 'False', 'b'),
    (212, 'True', 'a'),
    (212, 'False', 'b'),
    (213, 'True', 'a'),
    (213, 'False', 'b'),
    (214, 'True', 'a'),
    (214, 'False', 'b'),
    (215, 'True', 'a'),
    (215, 'False', 'b');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (216, 'True', 'a'),
    (216, 'False', 'b'),
    (217, 'True', 'a'),
    (217, 'False', 'b'),
    (218, 'True', 'a'),
    (218, 'False', 'b'),
    (219, 'True', 'a'),
    (219, 'False', 'b'),
    (220, 'True', 'a'),
    (220, 'False', 'b');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (221, 'True', 'a'),
    (221, 'False', 'b'),
    (222, 'True', 'a'),
    (222, 'False', 'b'),
    (223, 'True', 'a'),
    (223, 'False', 'b'),
    (224, 'True', 'a'),
    (224, 'False', 'b'),
    (225, 'True', 'a'),
    (225, 'False', 'b');
GO
-- C# True or False Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (226, 'C# is a high-level programming language.', 2, 'Easy', 'Tf', 'T', 100),
    (227, 'In C#, variables must be explicitly declared before they can be used.', 2, 'Easy', 'Tf', 'T', 100),
    (228, 'C# is a case-sensitive language.', 2, 'Easy', 'Tf', 'T', 100),
    (229, 'The `int` keyword in C# is used to declare floating-point variables.', 2, 'Easy', 'Tf', 'F', 100),
    (230, 'Comments in C# start with // for single-line comments and /* */ for multi-line comments.', 2, 'Easy', 'Tf', 'T', 100);
GO
-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (231, 'In C#, the `switch` statement can only be used with integer types.', 3, 'Medium', 'Tf', 'F', 100),
    (232, 'C# supports both single and multi-dimensional arrays.', 3, 'Medium', 'Tf', 'T', 100),
    (233, 'A C# method can have multiple return statements.', 3, 'Medium', 'Tf', 'T', 100),
    (234, 'The `StringBuilder` class in C# is used to create mutable strings.', 3, 'Medium', 'Tf', 'T', 100),
    (235, 'C# does not support operator overloading.', 3, 'Medium', 'Tf', 'F', 100);
GO
-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (236, 'In C#, interfaces can contain fields.', 1, 'Hard', 'Tf', 'F', 100),
    (237, 'C# supports multiple inheritance.', 1, 'Hard', 'Tf', 'F', 100),
    (238, 'The `lock` keyword in C# is used for asynchronous programming.', 1, 'Hard', 'Tf', 'F', 100),
    (239, 'C# supports pass-by-reference for method arguments.', 1, 'Hard', 'Tf', 'T', 100),
    (240, 'C# does not allow the creation of unmanaged code.', 1, 'Hard', 'Tf', 'F', 100);
GO
-- C# True or False Question Choices
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (226, 'True', 'a'),
    (226, 'False', 'b'),
    (227, 'True', 'a'),
    (227, 'False', 'b'),
    (228, 'True', 'a'),
    (228, 'False', 'b'),
    (229, 'True', 'a'),
    (229, 'False', 'b'),
    (230, 'True', 'a'),
    (230, 'False', 'b');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (231, 'True', 'a'),
    (231, 'False', 'b'),
    (232, 'True', 'a'),
    (232, 'False', 'b'),
    (233, 'True', 'a'),
    (233, 'False', 'b'),
    (234, 'True', 'a'),
    (234, 'False', 'b'),
    (235, 'True', 'a'),
    (235, 'False', 'b');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (236, 'True', 'a'),
    (236, 'False', 'b'),
    (237, 'True', 'a'),
    (237, 'False', 'b'),
    (238, 'True', 'a'),
    (238, 'False', 'b'),
    (239, 'True', 'a'),
    (239, 'False', 'b'),
    (240, 'True', 'a'),
    (240, 'False', 'b');
GO

-- C++ True or False Questions
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (241, 'C++ is an extension of the C programming language.', 2, 'Easy', 'Tf', 'T', 200),
    (242, 'In C++, variables must be explicitly declared before they can be used.', 2, 'Easy', 'Tf', 'T', 200),
    (243, 'C++ is a case-sensitive language.', 2, 'Easy', 'Tf', 'F', 200),
    (244, 'The `float` keyword in C++ is used to declare floating-point variables.', 2, 'Easy', 'Tf', 'F', 200),
    (245, 'Comments in C++ start with // for single-line comments and /* */ for multi-line comments.', 2, 'Easy', 'Tf', 'T', 200);

-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (246, 'C++ supports both single and multi-dimensional arrays.', 3, 'Medium', 'Tf', 'T', 200),
    (247, 'A C++ function can have multiple return statements.', 3, 'Medium', 'Tf', 'T', 200),
    (248, 'The `new` operator in C++ is used to allocate memory for an object.', 3, 'Medium', 'Tf', 'T', 200),
    (249, 'C++ supports function overloading.', 3, 'Medium', 'Tf', 'F', 200),
    (250, 'In C++, the `switch` statement can only be used with integral types.', 3, 'Medium', 'Tf', 'F', 200);

-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (251, 'In C++, references must be initialized when declared.', 1, 'Hard', 'Tf', 'T', 200),
    (252, 'C++ does not support exception handling.', 1, 'Hard', 'Tf', 'F', 200),
    (253, 'The `static` keyword in C++ is used to create static variables.', 1, 'Hard', 'Tf', 'F', 200),
    (254, 'C++ supports pass-by-reference for function arguments.', 1, 'Hard', 'Tf', 'T', 200),
    (255, 'C++ allows the creation of pure virtual functions.', 1, 'Hard', 'Tf', 'F', 200);
GO
-- C++ True or False Question Choices
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (241, 'True', 'a'),
    (241, 'False', 'b'),
    (242, 'True', 'a'),
    (242, 'False', 'b'),
    (243, 'True', 'a'),
    (243, 'False', 'b'),
    (244, 'True', 'a'),
    (244, 'False', 'b'),
    (245, 'True', 'a'),
    (245, 'False', 'b');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (246, 'True', 'a'),
    (246, 'False', 'b'),
    (247, 'True', 'a'),
    (247, 'False', 'b'),
    (248, 'True', 'a'),
    (248, 'False', 'b'),
    (249, 'True', 'a'),
    (249, 'False', 'b'),
    (250, 'True', 'a'),
    (250, 'False', 'b');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (251, 'True', 'a'),
    (251, 'False', 'b'),
    (252, 'True', 'a'),
    (252, 'False', 'b'),
    (253, 'True', 'a'),
    (253, 'False', 'b'),
    (254, 'True', 'a'),
    (254, 'False', 'b'),
    (255, 'True', 'a'),
    (255, 'False', 'b');
GO

-- JavaScript True or False Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (256, 'JavaScript is a case-sensitive language.', 2, 'Easy', 'Tf', 'T', 300),
    (257, 'In JavaScript, variables must be explicitly declared before they can be used.', 2, 'Easy', 'Tf', 'F', 300),
    (258, 'JavaScript is primarily a server-side scripting language.', 2, 'Easy', 'Tf', 'F', 300),
    (259, 'Comments in JavaScript start with // for single-line comments and /* */ for multi-line comments.', 2, 'Easy', 'Tf', 'T', 300),
    (260, 'The `var` keyword in JavaScript is used to declare variables.', 2, 'Easy', 'Tf', 'T', 300);

-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (261, 'In JavaScript, functions are first-class objects.', 3, 'Medium', 'Tf', 'T', 300),
    (262, 'JavaScript does not support object-oriented programming.', 3, 'Medium', 'Tf', 'F', 300),
    (263, 'The `let` keyword in JavaScript is used to declare block-scoped variables.', 3, 'Medium', 'Tf', 'T', 300),
    (264, 'JavaScript supports both synchronous and asynchronous programming.', 3, 'Medium', 'Tf', 'T', 300),
    (265, 'In JavaScript, the `==` operator checks for both value and type equality.', 3, 'Medium', 'Tf', 'F', 300);

-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (266, 'JavaScript is a strictly-typed language.', 1, 'Hard', 'Tf', 'F', 300),
    (267, 'In JavaScript, the `this` keyword always refers to the global object.', 1, 'Hard', 'Tf', 'F', 300),
    (268, 'The `async` and `await` keywords in JavaScript are used for asynchronous programming.', 1, 'Hard', 'Tf', 'T', 300),
    (269, 'JavaScript does not have a built-in module system.', 1, 'Hard', 'Tf', 'F', 300),
    (270, 'JavaScript does not support arrow functions.', 1, 'Hard', 'Tf', 'F', 300);
GO
-- JavaScript True or False Question Choices
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (256, 'True', 'a'),
    (256, 'False', 'b'),
    (257, 'True', 'a'),
    (257, 'False', 'b'),
    (258, 'True', 'a'),
    (258, 'False', 'b'),
    (259, 'True', 'a'),
    (259, 'False', 'b'),
    (260, 'True', 'a'),
    (260, 'False', 'b');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (261, 'True', 'a'),
    (261, 'False', 'b'),
    (262, 'True', 'a'),
    (262, 'False', 'b'),
    (263, 'True', 'a'),
    (263, 'False', 'b'),
    (264, 'True', 'a'),
    (264, 'False', 'b'),
    (265, 'True', 'a'),
    (265, 'False', 'b');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (266, 'True', 'a'),
    (266, 'False', 'b'),
    (267, 'True', 'a'),
    (267, 'False', 'b'),
    (268, 'True', 'a'),
    (268, 'False', 'b'),
    (269, 'True', 'a'),
    (269, 'False', 'b'),
    (270, 'True', 'a'),
    (270, 'False', 'b');
GO

-- SQL True or False Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (271, 'SQL stands for Standard Query Language.', 2, 'Easy', 'Tf', 'F', 400),
    (272, 'In SQL, the SELECT statement is used to retrieve data from a database.', 2, 'Easy', 'Tf', 'T', 400),
    (273, 'SQL is a case-insensitive language.', 2, 'Easy', 'Tf', 'T', 400),
    (274, 'Comments in SQL start with // for single-line comments and /* */ for multi-line comments.', 2, 'Easy', 'Tf', 'F', 400),
    (275, 'The `CREATE TABLE` statement in SQL is used to delete a table.', 2, 'Easy', 'Tf', 'F', 400);
GO
-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (276, 'SQL supports both single and multi-dimensional arrays.', 3, 'Medium', 'Tf', 'F', 400),
    (277, 'The `UPDATE` statement in SQL is used to modify existing records in a table.', 3, 'Medium', 'Tf', 'T', 400),
    (278, 'SQL does not support joining tables.', 3, 'Medium', 'Tf', 'F', 400),
    (279, 'The `DELETE` statement in SQL is used to remove records from a table.', 3, 'Medium', 'Tf', 'T', 400),
    (280, 'In SQL, the `GROUP BY` clause is used with aggregate functions.', 3, 'Medium', 'Tf', 'T', 400);
GO
-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (281, 'SQL does not support transaction management.', 1, 'Hard', 'Tf', 'F', 400),
    (282, 'In SQL, the `JOIN` clause is used to combine rows from two or more tables.', 1, 'Hard', 'Tf', 'T', 400),
    (283, 'The `INSERT INTO` statement in SQL is used to update existing records in a table.', 1, 'Hard', 'Tf', 'F', 400),
    (284, 'SQL does not allow the use of subqueries.', 1, 'Hard', 'Tf', 'F', 400),
    (285, 'In SQL, the `HAVING` clause is used to filter rows after grouping.', 1, 'Hard', 'Tf', 'T', 400);
GO
-- SQL True or False Question Choices
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (271, 'True', 'a'),
    (271, 'False', 'b'),
    (272, 'True', 'a'),
    (272, 'False', 'b'),
    (273, 'True', 'a'),
    (273, 'False', 'b'),
    (274, 'True', 'a'),
    (274, 'False', 'b'),
    (275, 'True', 'a'),
    (275, 'False', 'b');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (276, 'True', 'a'),
    (276, 'False', 'b'),
    (277, 'True', 'a'),
    (277, 'False', 'b'),
    (278, 'True', 'a'),
    (278, 'False', 'b'),
    (279, 'True', 'a'),
    (279, 'False', 'b'),
    (280, 'True', 'a'),
    (280, 'False', 'b');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (281, 'True', 'a'),
    (281, 'False', 'b'),
    (282, 'True', 'a'),
    (282, 'False', 'b'),
    (283, 'True', 'a'),
    (283, 'False', 'b'),
    (284, 'True', 'a'),
    (284, 'False', 'b'),
    (285, 'True', 'a'),
    (285, 'False', 'b');
GO

-- HTML True or False Questions
-- Easy
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (286, 'HTML stands for Hyper Text Markup Language.', 2, 'Easy', 'Tf', 'T', 500),
    (287, 'In HTML, the <p> tag is used to define a paragraph.', 2, 'Easy', 'Tf', 'T', 500),
    (288, 'HTML is a programming language.', 2, 'Easy', 'Tf', 'F', 500),
    (289, 'The <a> tag in HTML is used to define a division or a section.', 2, 'Easy', 'Tf', 'F', 500),
    (290, 'In HTML, attributes are placed inside the opening tag of an element.', 2, 'Easy', 'Tf', 'T', 500);
GO
-- Medium
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (291, 'HTML is used to create the structure of web pages.', 3, 'Medium', 'Tf', 'T', 500),
    (292, 'The <img> tag in HTML is used to display images.', 3, 'Medium', 'Tf', 'T', 500),
    (293, 'HTML supports inline styles using the `style` attribute.', 3, 'Medium', 'Tf', 'T', 500),
    (294, 'The <div> tag in HTML is used to define a clickable button.', 3, 'Medium', 'Tf', 'F', 500),
    (295, 'HTML is a case-sensitive language.', 3, 'Medium', 'Tf', 'F', 500);
GO
-- Hard
INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
VALUES
    (296, 'HTML5 introduced the <canvas> element for drawing graphics.', 1, 'Hard', 'Tf', 'T', 500),
    (297, 'In HTML, the <table> tag is used to create a dropdown list.', 1, 'Hard', 'Tf', 'F', 500),
    (298, 'HTML does not support the use of external CSS files.', 1, 'Hard', 'Tf', 'F', 500),
    (299, 'The <thead> tag in HTML is used to define the main content of a page.', 1, 'Hard', 'Tf', 'F', 500),
    (300, 'HTML does not provide a way to create forms for user input.', 1, 'Hard', 'Tf', 'F', 500);
GO
-- HTML True or False Question Choices
-- Easy
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (286, 'True', 'a'),
    (286, 'False', 'b'),
    (287, 'True', 'a'),
    (287, 'False', 'b'),
    (288, 'True', 'a'),
    (288, 'False', 'b'),
    (289, 'True', 'a'),
    (289, 'False', 'b'),
    (290, 'True', 'a'),
    (290, 'False', 'b');
GO
-- Medium
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (291, 'True', 'a'),
    (291, 'False', 'b'),
    (292, 'True', 'a'),
    (292, 'False', 'b'),
    (293, 'True', 'a'),
    (293, 'False', 'b'),
    (294, 'True', 'a'),
    (294, 'False', 'b'),
    (295, 'True', 'a'),
    (295, 'False', 'b');
GO
-- Hard
INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
VALUES
    (296, 'True', 'a'),
    (296, 'False', 'b'),
    (297, 'True', 'a'),
    (297, 'False', 'b'),
    (298, 'True', 'a'),
    (298, 'False', 'b'),
    (299, 'True', 'a'),
    (299, 'False', 'b'),
    (300, 'True', 'a'),
    (300, 'False', 'b');
GO
-----------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------