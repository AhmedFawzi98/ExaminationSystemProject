----------------------------------------CREATING Database ---------------------------------------------------------------------------------------------
GO
CREATE DATABASE Examination_System_Final
GO
USE Examination_System_Final
GO
----------------------------------------CREATING TABLES AND CONSTRAINTS -------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 1- DEPARTMENT TABLE ---------------------------------------------------------------------------------------
CREATE TABLE Department
(
    Dept_ID INT IDENTITY(10,10),
    Dept_Name NVARCHAR(50) NOT NULL,
    Dept_Description NVARCHAR(MAX),
    Location NVARCHAR(50),
    MGR_ID INT,
    MGR_HireDate DATETIME ,
    CONSTRAINT PK_Department_DeptID PRIMARY KEY(Dept_ID)
);
GO
ALTER TABLE Department
ADD CONSTRAINT DEF_DATE DEFAULT GETDATE() FOR MGR_HireDate
GO

-------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 2- COURSES TABLE ------------------------------------------------------------------------------------------
CREATE TABLE Courses
(
    Cr_ID INT,
    Cr_Name NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_Courses_CrID PRIMARY KEY(Cr_ID)
);
GO
ALTER TABLE Courses 
ADD CONSTRAINT cr_name_unique UNIQUE(Cr_Name)
GO

-------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 3- TABLE INSTRUCTOR ---------------------------------------------------------------------------------------
CREATE TABLE Instructor
(
    Ins_ID  INT IDENTITY,
    Ins_Name NVARCHAR(50) NOT NULL,
    Ins_Salary MONEY NOT NULL,
    Ins_Degree NVARCHAR(50),
    Dept_ID INT,
    Username VARCHAR(50) NOT NULL UNIQUE,
    CONSTRAINT PK_Instructor_InsID PRIMARY KEY (Ins_ID),
    CONSTRAINT Salary_Check CHECK (Ins_Salary BETWEEN 3000 AND 25000),
    CONSTRAINT FK_Instructor_Department FOREIGN KEY(Dept_ID) REFERENCES Department(Dept_ID) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO

-------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 4- TABLE Instructor_Course --------------------------------------------------------------------------------
CREATE TABLE Instructor_Course
(
    Ins_ID INT,
    Cr_ID INT,
    CONSTRAINT PK_Instructor_Course_InsID_CrID PRIMARY KEY (Ins_ID, Cr_ID),
    CONSTRAINT FK_Instructor_Course_Ins_ID FOREIGN KEY (Ins_ID) REFERENCES Instructor(Ins_ID) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_Instructor_Course_Cr_ID FOREIGN KEY (Cr_ID) REFERENCES Courses(Cr_ID) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 5- TABLE Student ------------------------------------------------------------------------------------------
CREATE TABLE Student
(
    St_ID INT IDENTITY(1,1),
    St_Name NVARCHAR(50) NOT NULL, 
    St_Email NVARCHAR(50) NOT NULL UNIQUE,
    St_Phone NVARCHAR(50) UNIQUE,
    St_Age INT,
    Street NVARCHAR(50),
    City NVARCHAR(50),
    Zip_Code NVARCHAR(50),
    Dept_ID INT,
    Username VARCHAR(50) NOT NULL UNIQUE,
    CONSTRAINT PK_Student_St_ID PRIMARY KEY(St_ID),
    CONSTRAINT Age_Check CHECK(St_Age BETWEEN 21 AND 29),
    CONSTRAINT FK_Student_Department FOREIGN KEY (Dept_ID) REFERENCES Department(Dept_ID) ON DELETE SET NULL ON UPDATE CASCADE
);
GO

-------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 6- TABLE Student_Course -----------------------------------------------------------------------------------
CREATE TABLE Student_Course
(
    St_ID INT ,
    Cr_ID INT,
    St_Grade DECIMAL(5,2),
    CONSTRAINT PK_StudentCourse_StID_CrID PRIMARY KEY(St_ID,Cr_ID),
    CONSTRAINT FK_StudentCourse_Student FOREIGN KEY (St_ID) REFERENCES Student(St_ID) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_StudentCourse_Courses FOREIGN KEY (Cr_ID) REFERENCES Courses(Cr_ID) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 7- TABLE Question -----------------------------------------------------------------------------------------
CREATE TABLE Question
(
    Q_ID INT,
    Q_Head VARCHAR(MAX) NOT NULL,
    Q_Grade INT NOT NULL,
    Q_Difficulty VARCHAR(10) NOT NULL,
    Type NVARCHAR(10) NOT NULL,
    Model_Answer CHAR(1) NOT NULL,
    Cr_ID INT,
    CONSTRAINT PK_Question_QID PRIMARY KEY(Q_ID),
    CONSTRAINT FK_Question_Courses FOREIGN KEY (Cr_ID) REFERENCES Courses(Cr_ID) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 8- TABLE Question_Choices ---------------------------------------------------------------------------------
CREATE TABLE Question_Choices
(
    Q_ID INT,
    Choice_Desc VARCHAR(MAX) NOT NULL,
    Choice_Selector CHAR(1),
    CONSTRAINT PK_Question_Choices_QID_ChoiceSelector PRIMARY KEY(Q_ID, Choice_Selector),
    CONSTRAINT FK_Question_Choices_Question FOREIGN KEY (Q_ID) REFERENCES Question(Q_ID) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 9- TABLE Student_Exam_Questions ---------------------------------------------------------------------------
CREATE TABLE Student_Exam_Questions
(
    St_ID INT,
    Exam_ID INT,
    Q_ID INT,
    St_Answer CHAR(1),
    CONSTRAINT PK_Student_Exam_Questions_StID_ExamID_QID PRIMARY KEY(St_ID, Exam_ID, Q_ID),
    CONSTRAINT FK_Student_Exam_Questions_Student FOREIGN KEY (St_ID) REFERENCES Student(St_ID) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_Student_Exam_Questions_Question FOREIGN KEY (Q_ID) REFERENCES Question(Q_ID) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

--------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 10- TABLE Exam ---------------------------------------------------------------------------------------------
CREATE TABLE Exam
(
    Ex_ID INT IDENTITY,
    Cr_ID INT,
    IsAssigned CHAR(1) DEFAULT 'N',
    CONSTRAINT PK_Exam_Ex_ID PRIMARY KEY(Ex_ID)
);
GO

--------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 11- TABLE Exam_Questions -----------------------------------------------------------------------------------
CREATE TABLE Exam_Questions
(
    Q_ID INT,
    Ex_ID INT,
    CONSTRAINT PK_ExamQuestions_ExID_QID PRIMARY KEY(Q_ID,Ex_ID),
    CONSTRAINT FK_Exam_Questions_Exam FOREIGN KEY (Ex_ID) REFERENCES Exam(Ex_ID) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_Exam_Questions_Question FOREIGN KEY (Q_ID) REFERENCES Question(Q_ID) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

--------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 12- TABLE Topic --------------------------------------------------------------------------------------------
 CREATE TABLE Topic
(
    Topic_ID INT IDENTITY,
    Topic_Name varchar(20) NOT NULL,
    Cr_ID INT,
    CONSTRAINT PK_Topic_Topic_ID PRIMARY KEY(Topic_ID),
    CONSTRAINT FK_Topic_Courses FOREIGN KEY (Cr_ID) REFERENCES Courses(Cr_ID) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-------------------------------------STORED PROCEDURES CRUD OPERATIONS ON TABLES  ----------------------------------------------------------------------

---------------------------------------------------- 1- CRUD PROCEDURES FOR TABLE Department------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------- A- SELECT DEPARTMENT -------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_SELECT_Department
AS
	IF EXISTS(SELECT * FROM Department)
		SELECT * FROM Department
	ELSE
		THROW 50001,'No Departments Data exist', 1

GO
-------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------- B- DELETE FROM DEPARTMENT -------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_DELETE_Department @DeptID INT
AS
	IF NOT EXISTS (SELECT * FROM Department WHERE Dept_ID = @DeptID)
		THROW 50001,'Department does not exist, Please Insert Valid Department ID', 1
	
	DELETE FROM Department
		WHERE Dept_ID = @DeptID

	UPDATE Instructor
		SET Dept_ID = NULL
	WHERE Dept_ID = @DeptID
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------- C- INSERT INTO DEPARTMENT ---------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Insert_Department 
	@DeptName NVARCHAR(50) ,@DeptDesc NVARCHAR(MAX) = NULL, @Loc NVARCHAR(50) = NULL,
	@MGRID INT = NULL, @MGRhiredate datetime
AS
	IF NOT EXISTS (SELECT * FROM Instructor WHERE Ins_ID = @MGRID) AND @MGRID IS NOT NULL
		THROW 50001,'Manager ID does not exist, Please insert Valid ID', 1
	IF @DeptName IS NULL 
		THROW 50001,'Please, Insert Valid Department Name', 1
	INSERT INTO Department(Dept_Name, Dept_Description,	Location, MGR_ID, MGR_HireDate)
	VALUES(@DeptName, @DeptDesc, @Loc, @MGRID, @MGRhiredate)
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------- D- UPDATE DEPARTMENT ------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_UPDATE_Department 
	@DeptID INT , @DeptName NVARCHAR(50) = NULL ,@DeptDesc NVARCHAR(MAX) = NULL,
	@Loc NVARCHAR(50) = NULL ,@MGRID INT = NULL, @MGRhiredate datetime = NULL
AS
	IF NOT EXISTS (SELECT * FROM Department WHERE Dept_ID = @DeptID)
		THROW 50001,'Dept ID does not exist, Please insert Valid ID', 1
	IF NOT EXISTS (SELECT * FROM Instructor WHERE Ins_ID = @MGRID) AND @MGRID IS NOT NULL
		THROW 50001,'Manager ID does not exist, Please insert Valid ID', 1
	IF @DeptName IS NULL 
		SELECT @DeptName = Dept_name FROM Department

	UPDATE Department
		SET Dept_Name = @DeptName,
		Dept_Description = @DeptDesc,
		Location = @Loc, MGR_ID = @MGRID,
		MGR_HireDate = @MGRHireDate
	WHERE Dept_ID = @DeptID
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------

---------------------------------------------------- 2- CRUD PROCEDURES FOR TABLE Courses--------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------ A- SELECT Courses ------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_SELECT_Courses
AS
	IF EXISTS(SELECT * FROM Courses)
		SELECT * FROM Courses
	ELSE
		THROW 50001,'No Courses Data exist', 1
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------- B- DELETE FROM Courses --------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_DELETE_Courses @CrID INT
AS
	IF NOT EXISTS (SELECT * FROM Courses WHERE Cr_ID = @CrID)
		THROW 50001,'Course does not exist, Please Insert Valid Course ID', 1
	DELETE FROM Courses
		WHERE CR_ID = @CrID
	DELETE FROM Exam 
		WHERE CR_ID = @CrID
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------- C- INSERT INTO COURSES ----------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Insert_Courses @CrID INT, @CrName NVARCHAR(50)
AS
	IF @CrID IS NULL
		THROW 50001,'Please, Insert Valid Course ID', 1
	IF EXISTS(SELECT * FROM Courses WHERE CR_ID = @CrID)
		THROW 50001,'Invalid Course ID, Course ID already Exists', 1 
	IF @CrName IS NULL
		THROW 50001,'Please, Insert Valid Course Name', 1

	INSERT INTO Courses
	VALUES(@CrID, @CrName)
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------- D- UPDATE Courses ---------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_UPDATE_Courses
	@newCrID INT ,@CrName NVARCHAR(50) , @oldCrID INT
AS
	IF EXISTS (SELECT * FROM Courses WHERE Cr_ID = @newCrID)
		THROW 50001,'Invalid Course ID, Course ID already Exists', 1
	IF @newCrID IS NULL 
		THROW 50001,'Please, Insert Valid Course ID', 1
	IF @CrName IS NULL 
		THROW 50001,'Please, Insert Valid Course Name', 1

	UPDATE Courses
		SET Cr_ID = @newCrID,
		Cr_Name = @CrName
	WHERE Cr_ID = @oldCrID
	UPDATE Exam 
		SET Cr_ID = @newCrID
	WHERE CR_ID = @oldCrID
GO
------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------- 3- CRUD PROCEDURES FOR TABLE INSTRUCTOR----------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------ A- SELECT INSTRUCTOR ------------------------------------------------ -------------------------------------
CREATE OR ALTER PROCEDURE SP_Select_Instructor
AS
	IF EXISTS ( SELECT * FROM Instructor)
		SELECT * FROM Instructor
	ELSE
		THROW 500001, ' There is no Instructor available', 1
GO
------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------ B- DELETE FORM INSTRUCTOR ---------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Delete_Instructor @Ins_ID INT

AS
	IF NOT EXISTS (SELECT Ins_ID FROM Instructor WHERE Ins_ID=@Ins_ID)
		THROW 50001, 'Invalid Delete, Instructor ID is not valid', 1
	ELSE
		BEGIN
			DELETE FROM Instructor WHERE Ins_ID = @Ins_ID
		END
GO
------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------ C- INSERT INTO INSTRUCTOR ---------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Insert_Instructor @Ins_Name NVARCHAR(50), @UserName VARCHAR(50), @Ins_Salary INT, @Ins_Degree NVARCHAR(50) = NULL, @Dept_ID INT = NULL
AS
	IF @Ins_Name = NULL
		THROW 50001, 'Invalid Insertion, Instructor name is required',1
	ELSE IF @UserName = NULL
		THROW 50001, 'Invalid Insertion, Instructor Username is required',1
	ELSE IF @Ins_Salary = NULL
		THROW 50001, 'Invalid Insertion, Instructor salary is required',1
	ELSE IF @Ins_Salary NOT BETWEEN 3000 AND 25000
		THROW 50001, 'Invalid Insertion, Instructor salary must be between 3000 and 25000', 1
	ELSE
		BEGIN
			INSERT INTO Instructor (Ins_Name,Username, Ins_Salary, Ins_Degree, Dept_ID)
			VALUES (@Ins_Name, @UserName, @Ins_Salary, @Ins_Degree, @Dept_ID)
		END
GO
-----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------ D- UPDATE INSTRUCTOR -------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Update_Instructor @Ins_ID INT, @UserName VARCHAR(50), @Ins_Name NVARCHAR(50), @Ins_Salary INT, @Ins_Degree NVARCHAR(50) = NULL, @Dept_ID INT = NULL
AS
	IF NOT EXISTS ( SELECT Dept_ID FROM Department WHERE Dept_ID = @Dept_ID ) AND @Dept_ID IS NOT NULL
		THROW 50001, 'Ivalid Update, Dept ID not valid', 1
	IF @Ins_Name = NULL
		THROW 50001, 'Invalid Update, Instructor name is required', 1
	ELSE IF @UserName = NULL
		THROW 50001, 'Invalid Update, Instructor Username is required', 1
	ELSE IF @Ins_Salary = NULL
		THROW 50001, 'Invalid Update, Instructor Salary is required', 1
	ELSE IF @Ins_Salary NOT BETWEEN 3000 AND 25000
		THROW 50001, 'Invalid Update, Instructor Salary must be between 3000 and 25000', 1
	ELSE IF NOT EXISTS (SELECT Ins_ID FROM Instructor WHERE Ins_ID = @Ins_ID)
		THROW 50001, 'Invalid Update, Instructor ID is not valid', 1
	ELSE
		BEGIN
			UPDATE Instructor SET Ins_Name = @Ins_Name,Username = @UserName, Ins_Salary = @Ins_Salary, Ins_Degree = @Ins_Degree, Dept_ID = @Dept_ID
			WHERE Ins_ID = @Ins_ID
		END
GO
-----------------------------------------------------------------------------------------------------------------------------------------------------

---------------------------------------------------- 4- CRUD PROCEDURES FOR TABLE INSTRUCTOR_COURSE--------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- A- Select INSTRUCTOR_COURSE -----------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Select_Instructor_Course

AS
	IF EXISTS (SELECT * FROM Instructor_Course)
		SELECT * FROM Instructor_Course
	ELSE
		THROW 50001, 'There is not data in Instuctor Course', 1
GO
-----------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------- B- DELETE FROM INSTRI+UCTOR_COURSE --------------------------------------------------------------
GO
CREATE OR ALTER PROCEDURE SP_Delete_Instructor_Course @Ins_ID INT, @Cr_ID INT

AS
	IF NOT EXISTS (SELECT * FROM Instructor_Course WHERE Ins_ID = @Ins_ID AND Cr_ID = @Cr_ID)
		THROW 50001, 'Invalid Delete, Instuctor ID with that Course ID is not valid', 1
	ELSE
		BEGIN
			DELETE FROM Instructor_Course WHERE Ins_ID = @Ins_ID AND Cr_ID = @Cr_ID
		END
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- C- INSERT INTO INSTRUCTOR_COURSE -----------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Insert_Insructor_Course @Ins_ID INT, @Cr_ID INT

AS
	IF NOT EXISTS (SELECT Ins_ID FROM Instructor WHERE Ins_ID = @Ins_ID)
		THROW 50001, 'Invalid Insertion, Instructor ID is not valid', 1
	ELSE IF NOT EXISTS (SELECT Cr_ID FROM Courses WHERE Cr_ID = @Cr_ID)
		THROW 50001, 'Invalid Insertion, Course ID is not valid', 1
	ELSE IF EXISTS (SELECT * FROM Instructor_Course WHERE Ins_ID = @Ins_ID AND Cr_ID = @Cr_ID)
		THROW 50001, 'Invalid Insertion, Instructor ID with that course ID cannot be inserted twice', 1
	ELSE IF @Ins_ID = NULL
		THROW 50001, 'Invalid Insertion, Instructor ID is not valid', 1
	ELSE IF @Cr_ID = NULL
		THROW 50001, 'Invalid Insertion, Course ID is not valid', 1
	ELSE
		BEGIN
			INSERT INTO Instructor_Course (Ins_ID, Cr_ID) VALUES (@Ins_ID, @Cr_ID)
		END
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- D- UPDATE INSTRUCTOR_COURSE ----------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Update_Instructor_Course @Ins_ID_OLD INT, @Cr_ID_OLD INT, @Ins_ID_New INT, @Cr_ID_New INT

AS
	IF @Ins_ID_OLD = NULL
		THROW 50001, 'Invalid Update, Instructor is not valid', 1
	IF @Ins_ID_New = NULL
		THROW 50001, 'Invalid Update, Instructor new id is not valid', 1
	IF @Cr_ID_OLD = NULL
		THROW 50001, 'Invalid Update, Course ID is not valid', 1
	IF @Cr_ID_New = NULL
		THROW 50001, 'Invalid Update, Course new id is not valid', 1
	IF NOT EXISTS (SELECT Ins_ID FROM Instructor WHERE Ins_ID = @Ins_ID_OLD)
		THROW 50001, 'Invalid Update, Instructor ID is not valid', 1
	ELSE IF NOT EXISTS (SELECT Cr_ID FROM Courses WHERE Cr_ID = @Cr_ID_OLD)
		THROW 50001, 'Invalid Update, Course ID is not valid', 1
	ELSE IF NOT EXISTS (SELECT * FROM Instructor_Course WHERE Ins_ID = @Ins_ID_OLD AND Cr_ID = @Cr_ID_OLD)
		THROW 50001, 'Invalid Update, Instructor ID with that course ID is not valid', 1
	ELSE IF EXISTS (SELECT * FROM Instructor_Course WHERE Ins_ID = @Ins_ID_New AND Cr_ID = @Cr_ID_New)
		THROW 50001, 'Invalid Update, Instructor ID with that course ID is valid twice', 1
	ELSE
		BEGIN
			UPDATE Instructor_Course SET Ins_ID = @Ins_ID_New, Cr_ID = @Cr_ID_New
			WHERE Ins_ID = @Ins_ID_OLD AND Cr_ID = @Cr_ID_OLD
		END
GO
---------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------- 5- CRUD PROCEDURES FOR TABLE Student----------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- A- Student Select -------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_SELECT_Student
AS
   IF EXISTS (SELECT * FROM Student)
      SELECT * FROM Student
   ELSE
      throw 50001,'There is no any student data',1
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- B- Delete FROM Student ---------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Delete_Student @id INT
AS
   IF EXISTS (SELECT * FROM Student WHERE St_ID=@id)
   begin
      DELETE FROM Student
      where St_ID=@id
   end
   ELSE 
      throw 50001,'There no student with this id',1
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- C- INSERT INTO Student ---------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Insert_Student @Name NVARCHAR(50),@UserName VARCHAR(50), @Email NVARCHAR(50) , @Phone NVARCHAR(50) = NULL, 
                               @Age INT =NULL, @Street NVARCHAR(50) = NULL, 
							   @City NVARCHAR(50) = NULL, @Zip_Code NVARCHAR(50)=NULL, @Dept_ID INT =NULL
AS
   IF @Name IS NULL
     throw 50001,'Insert Faild because Name attribute cannot be NULL',1
   ELSE IF @UserName IS NULL
     throw 50001,'Insert Faild because UserName attribute cannot be NULL',1
   ELSE IF  @Email IS NULL
     throw 50001,'Insert Faild because Email attribute cannot be NULL',1
   ELSE IF EXISTS (SELECT * FROM Student WHERE St_Phone=@Phone)
     throw 50001,'Insert Faild because Phone attribute must be unique',1
   ELSE IF EXISTS (SELECT * FROM Student WHERE St_Email=@Email)
     throw 50001,'Insert Faild because Email attribute must be unique',1
   ELSE IF NOT EXISTS (SELECT * FROM Department WHERE Dept_ID=@Dept_ID) AND @Dept_ID IS NOT NULL
     throw 50001,'Insert Faild because There is no Department with that id',1
   Else IF @Age NOT BETWEEN 21 AND 29
     throw 50001,'Insert Faild because Age must be between 21 and 29',1
   Else
      begin
       INSERT INTO Student (Username, St_Name, St_Email, St_Phone, St_Age, Street, City, Zip_Code, Dept_ID)
       VALUES
       (@UserName, @Name, @Email, @Phone, @Age, @Street, @City, @Zip_Code, @Dept_ID)
      end
GO
----------------------------------------------------------------------------------------------------------------------------------------------------  
------------------------------------------------- D- Update Student --------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Update_Student @ID INT ,@UserName VARCHAR(50), @Name NVARCHAR(50), @Email NVARCHAR(50) ,  
                               @Age INT =NULL, @Street NVARCHAR(50) = NULL , @Phone NVARCHAR(50) = NULL,
							   @City NVARCHAR(50) = NULL, @Zip_Code NVARCHAR(50)=NULL, @Dept_ID INT =NULL
AS
   IF NOT EXISTS (select * from Student WHERE St_ID=@ID)
     throw 50001,'Update Failed because There is NO Student with that id',1
   ELSE IF @UserName IS NULL
     throw 50001,'Update Faild because UserName attribute cannot be NULL',1
   ELSE IF @Name IS NULL
     throw 50001,'Update Faild because Name attribute cannot be NULL',1
   ELSE IF  @Email IS NULL
     throw 50001,'Update Faild because Email attribute cannot be NULL',1
   ELSE IF EXISTS (SELECT * FROM Student WHERE St_Phone=@Phone and St_ID!=@ID)
     throw 50001,'Update Faild because Phone attribute must be unique',1
   ELSE IF EXISTS (SELECT * FROM Student WHERE St_Email=@Email  and St_ID!=@ID)
     throw 50001,'Update Faild because Phone attribute must be unique',1
   ELSE If NOT EXISTS (SELECT * FROM Department WHERE Dept_ID=@Dept_ID) AND @Dept_ID IS NOT NULL
     throw 50001,'Update Faild because There is no Department with that id',1
   Else if @Age<21 OR @Age>29
     throw 50001,'Update Faild because Age must be between 21 and 29',1
   ELSE 
     begin
	     UPDATE student SET
		 St_Name=@Name ,Username=@UserName, St_Email=@Email,  
         St_Age=@Age  , Street=@Street, St_Phone=@Phone ,
		 City=@City , Zip_Code=@Zip_Code , Dept_ID=@Dept_ID 
		 WHERE St_ID=@ID
	 end
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------- 6- CRUD PROCEDURES FOR TABLE Student_Course----------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- A- Student_Course Select -------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Select_Student_Course
AS
   IF EXISTS (SELECT * FROM Student_Course)
      SELECT * FROM Student_Course
   ELSE
      throw 50001,'There no any Student_Course data',1
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- B- Delete FROM Student_Course --------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Delete_Student_Course @St_ID INT,@Cr_ID INT
AS
   IF EXISTS (SELECT * FROM Student_Course WHERE St_ID=@St_ID AND Cr_ID=@Cr_ID)
   begin
      DELETE FROM Student_Course
      where St_ID=@St_ID AND Cr_ID=@Cr_ID
   end
   ELSE 
      throw 50001,'There no Student_Course with this St_ID and Cr_ID',1
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- C- INSERT INTO Student_Course --------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Insert_Student_Course @St_ID INT, @Cr_ID INT, @St_Grade DECIMAL(5,2) =NULL
AS
   IF @St_ID IS NULL
     throw 50001,'Insert Faild because St_ID attribute cannot be NULL',1
   ELSE IF  @Cr_ID IS NULL
     throw 50001,'Insert Faild because Cr_ID attribute cannot be NULL',1
   ELSE IF EXISTS (SELECT * FROM Student_Course WHERE St_ID=@St_ID AND Cr_ID=@Cr_ID)
     throw 50001,'Insert Faild because St_ID and Cr_ID must be unique',1
   ELSE IF NOT EXISTS (SELECT * FROM Student WHERE St_ID=@St_ID)
     throw 50001,'Insert Faild because there is no student with that St_ID',1
   ELSE IF NOT EXISTS (SELECT * FROM Courses WHERE Cr_ID=@Cr_ID)
     throw 50001,'Insert Faild because there is no Course with that Cr_ID',1
   Else
      begin
          INSERT INTO Student_Course
		  VALUES(@St_ID,@Cr_ID,@St_Grade)
      end
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- D- UPDATE StudentCourse --------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Update_Student_Course @oldSt_ID INT, @oldCr_ID INT, @newSt_ID INT,@newCr_ID INT ,@St_Grade DECIMAL(5,2) =NULL
AS
   IF @oldSt_ID IS NULL
     throw 50001,'Upadte Faild because oldSt_ID attribute cannot be NULL',1
   ELSE IF  @oldCr_ID IS NULL
     throw 50001,'Upadte Faild because oldCr_ID attribute cannot be NULL',1
   ELSE IF @newSt_ID IS NULL
     throw 50001,'Upadte Faild because newSt_ID attribute cannot be NULL',1
   ELSE IF  @newCr_ID IS NULL
     throw 50001,'Upadte Faild because newCr_ID attribute cannot be NULL',1
   ELSE IF NOT EXISTS (SELECT * FROM Student_Course WHERE St_ID=@oldSt_ID AND Cr_ID=@oldCr_ID)
     throw 50001,'Upadte Faild because St_ID and Cr_ID must be unique',1
   ELSE IF EXISTS (SELECT * FROM Student_Course WHERE St_ID=@newSt_ID AND Cr_ID=@newCr_ID)
     throw 50001,'Upadte Faild because St_ID and Cr_ID must be unique',1
   ELSE IF NOT EXISTS (SELECT * FROM Student WHERE St_ID=@newSt_ID)
     throw 50001,'Upadte Faild because there is no student with that St_ID',1
   ELSE IF NOT EXISTS (SELECT * FROM Courses WHERE Cr_ID=@newCr_ID)
     throw 50001,'Upadte Faild because there is no Course with that Cr_ID',1
   Else
      begin
          UPDATE Student_Course SET
		  St_ID=@newSt_ID,
		  Cr_ID=@newCr_ID,
		  St_Grade=@St_Grade
		  WHERE Cr_ID=@oldCr_ID AND St_ID=@oldSt_ID
      end
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------- 7- CRUD PROCEDURES FOR TABLE Question----------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- A- Question Select -------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_SELECT_Question
AS
	IF EXISTS(SELECT * FROM Question)
		SELECT * FROM Question
	ELSE
		THROW 50001, 'There is no Question data.', 1

GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- B- Delete FROM Question --------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_DELETE_Question @id INT
AS
	IF EXISTS(SELECT * FROM Question WHERE Q_ID = @id)
	BEGIN
		DELETE FROM Question
		WHERE Q_ID = @id
	END
	ELSE
		THROW 50001, 'There are no Question with the given ID.', 1
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- C- INSERT INTO Question --------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_INSERT_Question @id INT, @head VARCHAR(MAX), @grade INT, @difficulty VARCHAR(10),
									@type NVARCHAR(10), @model char(1), @course INT = NULL
AS
	IF @id IS NULL
		THROW 50001, 'The question must have an id', 1
	ELSE IF EXISTS(SELECT * FROM Question WHERE Q_ID = @id)
		THROW 50001, 'A Question with this ID already exists',1
	ELSE IF @head IS NULL
		THROW 50001, 'The question head cannot be empty.', 1
	ELSE IF @grade IS NULL
		THROW 50001, 'The question must have a grade.', 1
	ELSE IF @difficulty IS NULL
		THROW 50001, 'The question must have a difficulty.', 1
	ELSE IF @type IS NULL
		THROW 50001, 'The question must have a type of T/F or MCQ.', 1
	ELSE IF @model IS NULL
		THROW 50001, 'The question must have a model answer.', 1
	ELSE
		BEGIN
			INSERT INTO Question (Q_ID, Q_Head, Q_Grade, Q_Difficulty, Type, Model_Answer, Cr_ID)
			VALUES
			(@id, @head, @grade, @difficulty, @type, @model, @course)
		END
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- D- UPDATE Question -------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_UPDATE_Question @id INT, @head VARCHAR(MAX)=NULL, @grade INT=NULL, @difficulty VARCHAR(10)=NULL,
							   @type NVARCHAR(10)=NULL, @model char(1)=NULL, @course INT=0
AS
	IF @id IS NULL
		THROW 50001, 'Question ID must be provided', 1
	ELSE IF @head IS NULL
		SELECT @head = Q_Head FROM Question WHERE Q_ID = @id
	ELSE IF @grade IS NULL
		SELECT @grade = Q_Grade FROM Question WHERE Q_ID = @id
	ELSE IF @difficulty IS NULL
		SELECT @difficulty = Q_Difficulty FROM Question WHERE Q_ID = @id
	ELSE IF @type IS NULL
		SELECT @type = Type FROM Question WHERE Q_ID = @id
	ELSE IF @model IS NULL
		SELECT @model = Model_Answer FROM Question WHERE Q_ID = @id
	ELSE IF NOT EXISTS(SELECT * FROM Courses WHERE Cr_ID = @course)
		THROW 50001, 'Course provided does not exist', 1
	ELSE
		BEGIN
			UPDATE Question
			SET
			Q_Head = @head, Q_Grade = @grade, Q_Difficulty = @difficulty,
			Type = @type, Model_Answer=@model, Cr_ID = @course
			WHERE Q_ID = @id
		END

GO
------------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------- 8- CRUD PROCEDURES FOR TABLE Question_Choices----------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- A- Question_Choices Select -------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_SELECT_Question_Choices
AS
	IF EXISTS(SELECT * FROM Question_Choices)
		SELECT * FROM Question_Choices
	ELSE
		THROW 50001, 'There are no Question choices yet.', 1
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- B- Delete FROM Question_Choices
CREATE OR ALTER PROCEDURE SP_DELETE_Question_Choices @id INT, @selector CHAR(1)
AS
	IF EXISTS(SELECT * FROM Question_Choices WHERE Q_ID = @id AND Choice_Selector = @selector)
	BEGIN
		DELETE FROM Question_Choices
		WHERE Q_ID = @id AND Choice_Selector = @selector
	END
	ELSE
		THROW 50001, 'There are no Question choices with the given ID and choice.', 1
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- C- INSERT INTO Question_Choices ------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_INSERT_Question_Choices @id INT, @desc VARCHAR(MAX), @selector CHAR(1)
AS
	IF (@id IS NULL) OR (@selector IS NULL)
		THROW 50001, 'A question choice must have both an id and a choice character.', 1
	ELSE IF NOT EXISTS(SELECT * FROM Question WHERE Q_ID = @id)
		THROW 50001, 'The question ID inserted cannot be matched with a question entry.', 1
	ELSE IF @desc IS NULL
		THROW 50001, 'The choice body cannot be empty.', 1
	ELSE IF EXISTS(SELECT * FROM Question_Choices WHERE Q_ID=@id AND Choice_Selector=@selector)
		THROW 50001, 'This question choice already exists', 1
	ELSE
		BEGIN
			INSERT INTO Question_Choices (Q_ID, Choice_Desc, Choice_Selector)
			VALUES
			(@id, @desc, @selector)
		END
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- D- UPDATE Question_Choices -----------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_UPDATE_Question_Choices @id INT, @old_selector CHAR(1), @desc VARCHAR(MAX)=NULL, @new_selector CHAR(1)=NULL
AS
	IF (@id IS NULL) OR (@old_selector IS NULL)
		THROW 50001, 'Question ID and Choice must be provided', 1
	ELSE IF @desc IS NULL
		SELECT @desc = Choice_Desc FROM Question_Choices WHERE Q_ID = @id AND Choice_Selector = @old_selector
	ELSE IF @new_selector IS NULL
		SELECT @new_selector = Choice_Selector FROM Question_Choices WHERE Q_ID = @id AND Choice_Selector = @old_selector
	ELSE IF EXISTS(SELECT * FROM Question_Choices WHERE Q_ID = @id AND Choice_Selector = @new_selector)
		THROW 50001,'A question with the same ID already has the same choice.', 1
	ELSE
		BEGIN
			IF @new_selector IS NOT NULL
				BEGIN
					UPDATE Question_Choices
					SET
					Choice_Desc = @desc, Choice_Selector = @new_selector
					WHERE Q_ID = @id AND Choice_Selector = @old_selector
				END
			ELSE
				BEGIN
					UPDATE Question_Choices
					SET
					Choice_Desc = @desc
					WHERE Q_ID = @id AND Choice_Selector = @old_selector
				END
		END
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------- 9- CRUD PROCEDURES FOR TABLE Student_Exam_Questions--------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- A- Student_Exam_Questions Select -----------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_SELECT_Student_Exam_Questions
AS
	IF EXISTS(SELECT * FROM Student_Exam_Questions)
		SELECT * FROM Student_Exam_Questions
	ELSE
		THROW 50001, 'There are no answers from students yet.', 1
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- B- Delete FROM Student_Exam_Questions ------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_DELETE_Student_Exam_Questions @st_id INT, @exam_id INT, @q_id INT
AS
	IF EXISTS(SELECT * FROM Student_Exam_Questions WHERE St_ID=@st_id AND Exam_ID=@exam_id AND Q_ID=@q_id)
	BEGIN
		DELETE FROM Student_Exam_Questions
		WHERE St_ID = @st_id AND Exam_ID=@exam_id AND Q_ID=@q_id
	END
	ELSE
		THROW 50001, 'There are no answers with the given exam, student, and answer.', 1
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- C- INSERT INTO Student_Exam_Questions ------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_INSERT_Student_Exam_Questions @st_id INT, @exam_id INT, @q_id INT, @st_ans CHAR(1)=NULL
AS
	IF (@st_id IS NULL) OR (@exam_id IS NULL) OR (@q_id IS NULL)
		THROW 50001, 'This question has already been answered.', 1
	ELSE IF NOT EXISTS(SELECT * FROM Student WHERE St_ID = @st_id)
		THROW 50001, 'The student ID inserted cannot be matched with a student entry.', 1
	ELSE IF NOT EXISTS(SELECT * FROM Exam WHERE Ex_ID = @exam_id)
		THROW 50001, 'The exam ID inserted cannot be matched with an exam entry.', 1
	ELSE IF NOT EXISTS(SELECT * FROM Question WHERE Q_ID = @q_id)
		THROW 50001, 'The question ID inserted cannot be matched with a question entry.', 1
	ELSE IF EXISTS(SELECT * FROM Student_Exam_Questions WHERE Q_ID=@q_id AND St_Answer=@st_ans AND Exam_ID=@exam_id)
		THROW 50001, 'This question answer has already been recorded before.', 1
	ELSE
		BEGIN
			INSERT INTO Student_Exam_Questions (St_ID, Exam_ID, Q_ID, St_Answer)
			VALUES
			(@st_id, @exam_id, @q_id, @st_ans)
		END
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- D- UPDATE Student_Exam_Questions -----------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_UPDATE_Student_Exam_Questions @st_id INT, @exam_id INT, @q_id INT, @st_ans CHAR(1)=NULL
AS
	IF (@st_id IS NULL) OR (@exam_id IS NULL) OR (@q_id IS NULL)
		THROW 50001, 'Student, Exam, and Question must be provided', 1
	ELSE IF @st_ans IS NULL
		SELECT @st_ans = St_Answer FROM Student_Exam_Questions WHERE Q_ID = @q_id AND Exam_ID = @exam_id AND St_ID = @st_id
	ELSE
		BEGIN
			UPDATE Student_Exam_Questions
			SET
			St_Answer = @st_ans
			WHERE St_ID = @st_id AND Exam_ID = @exam_id AND Q_ID = @q_id
		END
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------- 10- CRUD PROCEDURES FOR TABLE Exam-------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- A- Exam Select -----------------------------------------------------------------------------------
 CREATE OR ALTER PROC SP_SelectFrom_Exam
 WITH ENCRYPTION
 AS
		IF EXISTS(SELECT * FROM Exam)
			SELECT *
			FROM Exam 
		ELSE
			THROW 50001, 'This Table Has No Data!!!',1
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- B- Delete FROM Exam ------------------------------------------------------------------------------
CREATE OR ALTER PROC SP_DeleteFrom_Exam @examID INT
WITH ENCRYPTION
AS		
		IF NOT EXISTS(SELECT * FROM Exam WHERE Ex_ID=@examID)
			THROW 50001, 'This ID Not Existed!!!',1
		ELSE
			Delete
			FROM Exam 
			WHERE Ex_ID = @examID
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- C- INSERT INTO Exam ------------------------------------------------------------------------------
 CREATE OR ALTER PROC SP_InsertInto_Exam @crID INT
 WITH ENCRYPTION
 AS
		IF @crID IS NULL
			THROW 50001, 'ExamID Cannot Be Null!!!',1
		ELSE
			INSERT INTO Exam (Cr_ID)
			VALUES(@crID)
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- D- UPDATE Exam -----------------------------------------------------------------------------------
CREATE OR ALTER PROC SP_Update_Exam @Cr_ID INT,@examID INT
WITH ENCRYPTION
AS
		IF NOT EXISTS(SELECT * FROM Exam WHERE Ex_ID=@examID)
			THROW 50001, 'This ID Does Not Exist!!!',1
		ELSE IF @Cr_ID IS NULL
			THROW 50001, 'CR_ID Cannot Be Null!!!',1
		ELSE
			UPDATE Exam
			SET Cr_ID = @Cr_ID
			WHERE Ex_ID = @examID

GO
----------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------- 11- CRUD PROCEDURES FOR TABLE Exam_Questions---------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- A- Exam_Questions Select -------------------------------------------------------------------------
 CREATE OR ALTER PROC SP_SelectFrom_Exam_Questions
 WITH ENCRYPTION
 AS
			IF NOT EXISTS(SELECT* FROM Exam_Questions)
				THROW 50001, 'There is no Records in the Table!!!',1
			ELSE
				SELECT *
				FROM Exam_Questions 
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- B- Delete FROM Exam_Questions --------------------------------------------------------------------
CREATE OR ALTER PROC SP_DeleteFrom_Exam_Questions @examID INT,@QuestionID INT
WITH ENCRYPTION
AS
		IF NOT EXISTS(SELECT * FROM Exam_Questions WHERE Ex_ID=@examID AND Q_ID =@QuestionID )
			THROW 50001, 'This ID Not Existed!!!',1
		ELSE
			Delete
			FROM Exam_Questions 
			WHERE Ex_ID = @examID AND Q_ID = @QuestionID
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- C- INSERT INTO Exam_Questions --------------------------------------------------------------------
 CREATE OR ALTER PROC SP_InsertInto_Exam_Questions @examID INT ,@QuestionID INT
 WITH ENCRYPTION
 AS
		IF @examID IS NULL OR @QuestionID IS NULL
			THROW 50001, 'You Cant Enter Null Values!!!',1
		IF EXISTS(SELECT @examID,@QuestionID FROM Exam_Questions WHERE Ex_ID =@examID AND Q_ID =@QuestionID )
			THROW 50001, 'This Composite ID Existed Before!!!',1
		IF NOT EXISTS(SELECT * FROM Exam WHERE Ex_ID = @examID) AND 
		   NOT EXISTS(SELECT * FROM Question WHERE Q_ID = @QuestionID) 
				THROW 50001, 'This ID Is Not In Exam Or Question Table!!!',1
		ELSE
			INSERT INTO Exam_Questions
			VALUES(@examID,@QuestionID)
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- D- UPDATE Exam_Questions -------------------------------------------------------------------------
CREATE OR ALTER PROC SP_Update_Exam_Questions @NewExamID INT ,@NewQuestionID INT,@OldExamID INT ,@OldQuestionID int
WITH ENCRYPTION
AS		
		IF NOT EXISTS(SELECT * FROM Exam_Questions WHERE Ex_ID=@OldExamID AND Q_ID = @OldQuestionID)
			THROW 50001, 'This ID Not Existed!!!',1
		ELSE IF NOT EXISTS(SELECT * FROM Exam WHERE Ex_ID = @NewExamID) AND 
			    NOT EXISTS(SELECT * FROM Question WHERE Q_ID = @NewQuestionID)
					THROW 50001, 'This ID Is Not In Exam Or Question Table!!!',1
		ELSE IF EXISTS(SELECT @NewExamID, @NewQuestionID FROM Exam_Questions)
			THROW 50001, 'This Record Exists!!!',1
		ELSE
			UPDATE Exam_Questions
			SET Ex_ID = @NewExamID ,Q_ID = @NewQuestionID
			WHERE Ex_ID = @OldExamID and Q_ID = @OldQuestionID
GO
--------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------- 12- CRUD PROCEDURES FOR TABLE Topic----------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- A- Topic Select --------------------------------------------------------------------------------
CREATE OR ALTER PROC SP_SelectFrom_Topic
 WITH ENCRYPTION
 AS
				SELECT *
				FROM Topic

GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- B- Delete FROM Topic -----------------------------------------------------------------------------
CREATE OR ALTER PROC SP_DeleteFrom_Exam @TopicID INT
WITH ENCRYPTION
AS		IF EXISTS(SELECT * FROM Topic WHERE Topic_ID = @TopicID)
			Delete
			FROM Topic 
			WHERE Topic_ID = @TopicID
		ELSE
				THROW 50001, 'This record doesnot Exists',1
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- C- INSERT INTO Topic -----------------------------------------------------------------------------
CREATE OR ALTER PROC SP_InsertInto_Topic @TopicName NVARCHAR(50),@CourseID INT
 WITH ENCRYPTION
 AS
	    IF EXISTS(SELECT * FROM Topic WHERE Topic_Name = @TopicName AND Cr_ID = @CourseID )
			THROW 50001, 'This Record Exists!!!',1
	    IF @TopicName IS NULL
			THROW 50001, 'Name Cannot Be Null!!!',1
		ELSE
			INSERT INTO Topic
			VALUES(@TopicName,@CourseID)
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- D- UPDATE Topic ----------------------------------------------------------------------------------
CREATE OR ALTER PROC SP_Update_Topic @TopicID INT,@topicName varchar(20),@cr_ID INT
WITH ENCRYPTION
AS
		
		IF EXISTS(SELECT * FROM Topic WHERE Topic_ID = @TopicID)
			UPDATE Topic
			SET Topic_Name = @topicName ,Cr_ID = @cr_ID
			WHERE Topic_ID = @TopicID
		ELSE
				THROW 50001, 'This record dose,nt Exists',1

GO
----------------------------------------------------------------------------------------------------------------------------------------------------


-------------------------------------------------- 3 MAIN PROCEDURES -------------------------------------------------------------------------------
------------------------------------ 1- Stored procedure for Generate Exams ------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Generate_Exam @Course_Name VARCHAR(10), @Mcq INT, @TF INT, @Generated_Exam_ID INT OUTPUT

AS								
    -- Getting Max , Min of the Question type with fairness of the total exam
	DECLARE @Max TABLE (X INT, Y VARCHAR(10))
	DECLARE @Min TABLE (X INT, Y VARCHAR(10))
	IF @Mcq > @TF 
		BEGIN
			INSERT INTO @Max VALUES (@Mcq ,  'Mcq')
			Insert into @Min values( @TF , 'Tf')
		END
	ELSE
		BEGIN
			INSERT INTO @Max VALUES(  @TF ,  'Tf')
		    INSERT INTO @Min VALUES(  @Mcq , 'Mcq')
		END
	
	DECLARE @Exam_ID INT
	DECLARE @Cr_ID INT
	SELECT @Cr_ID=Cr_Id FROM Courses WHERE Cr_Name = @Course_Name

	INSERT INTO Exam(Cr_ID) VALUES (@Cr_ID)
	SELECT @Exam_ID = MAX(Ex_ID) FROM Exam
	SET @Generated_Exam_ID = @Exam_ID

	DECLARE @Questions TABLE (Question_ID INT, Exam_ID INT)
	DECLARE @Course_ID INT
	SELECT @Course_ID=Cr_ID FROM Courses WHERE Cr_Name = @Course_Name
	INSERT INTO @Questions
	SELECT  TOP(3) Q_ID, @Exam_ID FROM Question WHERE Q_Difficulty = 'Easy' AND Cr_ID =@Course_ID AND Type = (SELECT Y FROM @Max) ORDER BY NEWID()
	UPDATE @Max SET X -= 3

	IF (SELECT X FROM @Max) = 2
		BEGIN
			INSERT INTO @Questions
			SELECT  TOP(2) Q_ID, @Exam_ID FROM Question WHERE Q_Difficulty = 'Hard' AND Cr_ID =@Course_ID AND Type = (SELECT Y FROM @Max) ORDER BY NEWID()
			INSERT INTO @Questions
			SELECT  TOP(1) Q_ID, @Exam_ID FROM Question WHERE Q_Difficulty = 'Hard' AND Cr_ID =@Course_ID AND Type = (SELECT Y FROM @Min) ORDER BY NEWID()
			INSERT INTO @Questions
			SELECT  TOP(4) Q_ID, @Exam_ID FROM Question WHERE Q_Difficulty = 'Medium' AND Cr_ID =@Course_ID AND Type = (SELECT Y FROM @Min) ORDER BY NEWID()
		END
	ELSE
		BEGIN
			INSERT INTO @Questions
			SELECT  TOP(3) Q_ID, @Exam_ID FROM Question WHERE Q_Difficulty = 'Hard' AND Cr_ID =@Course_ID AND Type = (SELECT Y FROM @Max) ORDER BY NEWID()
			UPDATE @Max SET X -= 3
			IF (SELECT X FROM @Max) = 0
			BEGIN
			  INSERT INTO @Questions
			  SELECT  TOP(4) Q_ID, @Exam_ID FROM Question WHERE Q_Difficulty = 'Medium' AND Cr_ID =@Course_ID AND Type = (SELECT Y FROM @Min) ORDER BY NEWID()
			END
			ELSE
			BEGIN
			   INSERT INTO @Questions
			   SELECT  TOP(SELECT X FROM @Max) Q_ID, @Exam_ID FROM Question WHERE Q_Difficulty = 'Medium' AND Cr_ID =@Course_ID AND Type = (SELECT Y FROM @MAX) ORDER BY NEWID()
			   DECLARE @MID INT=4-(SELECT X FROM @Max)
			   INSERT INTO @Questions
			   SELECT  TOP(@MID) Q_ID, @Exam_ID FROM Question WHERE Q_Difficulty = 'Medium' AND Cr_ID =@Course_ID AND Type = (SELECT Y FROM @MIN) ORDER BY NEWID()
			END
		END

		INSERT INTO Exam_Questions
		SELECT * FROM @Questions
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------ 2- Stored procedure for SUBMITTING ANSWERS ------------------------------------------------------------------------
CREATE TYPE storedTable AS TABLE
(
    ans CHAR(1)
);
GO

CREATE OR ALTER PROCEDURE SP_Submit_Answers @exam_id INT , @stud_id INT , @answersString AS storedTable READONLY
AS  
    DECLARE @Q_ID TABLE(Q_ID INT)
    INSERT INTO @Q_ID
    SELECT Q_ID 
    FROM Exam_Questions
    WHERE Ex_id = @exam_id

    DECLARE c1 CURSOR
    FOR SELECT ans
        FROM @answersString
    FOR READ only

    DECLARE @oneAns VARCHAR(1)
    OPEN c1
    FETCH NEXT FROM c1 into @oneAns
    while @@FETCH_STATUS = 0 
        BEGIN
            DECLARE @oneQid INT = (SELECT TOP(1) Q_ID FROM @Q_ID)
            INSERT INTO Student_Exam_Questions
            SELECT @stud_id, @exam_id, @oneQid, @oneAns 
            DELETE FROM @Q_id 
            WHERE Q_ID = @oneQid
            FETCH NEXT FROM c1 INTO @oneAns
        END
    CLOSE c1
    DEALLOCATE c1
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 3- Procedure to ASSIGN EXAM --------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_Assign_Student_Exam @CrID INT ,@ExamId INT OUTPUT
AS
	SELECT @ExamId = (SELECT TOP(1) Ex_ID FROM Exam WHERE IsAssigned = 'N' AND Cr_ID = @CrID ORDER BY NEWID())
	UPDATE Exam SET IsAssigned = 'Y' WHERE Ex_ID = @ExamId

GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 4- Procedure to GRADE EXAM ---------------------------------------------------------------------------------------
CREATE PROCEDURE SP_Grade_Exam @stID int, @Cr_ID INT, @ExamID int, @Grade_OUT DECIMAL OUTPUT
AS
BEGIN
    DECLARE @Grade decimal = 0, @FullMark decimal = 0;

    DECLARE c1 CURSOR FOR
        SELECT st_Answer, Q_ID
        FROM Student_Exam_Questions
        WHERE St_ID = @stID AND Exam_ID = @ExamID;

    DECLARE @stAns VARCHAR(1), @QID int;

    OPEN c1;
    FETCH NEXT FROM c1 INTO @stAns, @QID;
    WHILE @@FETCH_STATUS = 0 
    BEGIN
        DECLARE @modAns char(1), @Qgrade int;
        SELECT @modAns = Model_Answer, @Qgrade = Q_Grade
        FROM Question
        WHERE Q_ID = @QID;

        SELECT @FullMark += @Qgrade;
        IF @stAns = @modAns
            SELECT @Grade += @Qgrade;

        FETCH NEXT FROM c1 INTO @stAns, @QID;
    END;

    SET @Grade_OUT = ((@Grade * 100) / @FullMark);

    UPDATE Student_Course
    SET St_Grade = CONVERT(decimal(5,2), (@Grade * 100) / @FullMark)
    WHERE St_ID = @stID AND Cr_ID = @Cr_ID;

    CLOSE c1;
    DEALLOCATE c1;
END;
GO
----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- F- SELECT All Instructor Student Course ----------------------------------------------------------
CREATE OR ALTER PROCEDURE SP_SelectAllInstructorStudentCourses @InsID INT
AS
	SELECT C.Cr_Name AS [Course Name], S.St_Name AS [Student Name], SC.St_Grade AS [Student Grade]
	FROM Student_Course SC
	JOIN Instructor_Course IC
	ON SC.Cr_ID = IC.Cr_ID
	JOIN Student S
	ON S.St_ID = SC.St_ID
	JOIN Courses C
	ON C.Cr_ID = SC.Cr_ID
	WHERE IC.Ins_ID = @InsID
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------REPORTS STORED PROCEDURE-------------------------------------------------------------------------------------------

--•	1- Report that returns the students information according to Department No parameter
CREATE OR ALTER PROCEDURE SP_Get_Student_By_Dept_ID @ID INT
AS
SELECT * FROM Student
WHERE Dept_ID=@ID
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------
--•	2- Report that takes the student ID and returns the grades of the student in all courses
CREATE OR ALTER PROCEDURE SP_Get_Student_Grade_By_ID @ID INT
AS
SELECT C.Cr_Name AS [Course Name], SC.St_Grade AS [Grade]
FROM Courses C,Student_Course SC
WHERE SC.St_ID=@ID and SC.Cr_ID=C.Cr_ID 
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------
--•	3- Report that takes the instructor ID and returns the name of the courses that he teaches and the number of student per course
CREATE OR ALTER PROCEDURE SP_GetCourseName_and_NumberOFStudentsPerCourse_By_InstructorID @ID INT
AS
SELECT C.Cr_Name AS [Course Name], COUNT(SC.St_ID) AS [Number OF Students]
FROM Instructor_Course IC, Courses C, Student_Course SC
WHERE IC.Ins_ID=@ID AND C.Cr_ID=IC.Cr_ID AND SC.Cr_ID=C.Cr_ID
GROUP BY  C.Cr_Name
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------
--•	4- Report that takes course ID and returns its topics
CREATE OR ALTER PROCEDURE SP_Get_Topics_By_CourseID @ID INT
AS
SELECT T.Topic_Name
FROM Topic T
WHERE T.Cr_ID=@ID
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------
--•	5- Report that takes exam number and returns the Questions in it and chocies [freeform report]
CREATE OR ALTER PROCEDURE SP_Get_Questions_and_Choices_By_ExamID @ID INT
AS
SELECT Q.*, QC.Choice_Desc, QC.Choice_Selector -------why
FROM Exam_Questions EQ, Question Q , Question_Choices QC
WHERE EQ.Ex_ID=@ID AND Q.Q_ID=EQ.Q_ID AND QC.Q_ID=Q.Q_ID
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------
--•	6- Report that takes exam number and the student ID then returns the Questions in this exam with the student answers
CREATE OR ALTER PROCEDURE SP_Get_Student_Answers_By_examID_and_studID @examID INT, @studID INT
AS
SELECT Q.*, STQ.St_Answer
FROM Question Q, Student_Exam_Questions STQ
WHERE STQ.Exam_ID=@examID AND STQ.St_ID=@studID AND STQ.Q_ID=Q.Q_ID

--------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------- TRUNCATE ALL TABLES --------------------------------------------------------------------------------------------
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
--------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------

--------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------- DROP ALL TABLES ------------------------------------------------------------------------------------------------
--GO
--DROP TABLE Courses
--GO
--DROP TABLE Department
--GO
--DROP TABLE Exam
--GO
--DROP TABLE Exam_Questions
--GO
--DROP TABLE Instructor
--GO
--DROP TABLE Instructor_Course
--GO
--DROP TABLE Question
--GO
--DROP TABLE Question_Choices
--GO 
--DROP TABLE Student
--GO
--DROP TABLE Student_Course
--GO
--DROP TABLE Student_Exam_Questions
--GO
--DROP TABLE Topic
--GO